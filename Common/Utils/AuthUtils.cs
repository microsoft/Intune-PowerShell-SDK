// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal static partial class AuthUtils
    {
        /// <summary>
        /// The query parameter to use when triggering the admin consent flow.
        /// </summary>
        private const string AdminConsentQueryParameter = "prompt=admin_consent";

        /// <summary>
        /// The endpoint to be used if Managed Service Identity (MSI) authentication is available.
        /// </summary>
        private static string ManagedServiceIdentityEndpoint { get; } = Environment.GetEnvironmentVariable("MSI_ENDPOINT");

        /// <summary>
        /// The last successful ADAL authentication attempt's result.
        /// </summary>
        private static SdkAuthResult LatestAdalAuthResult { get; set; }

        /// <summary>
        /// The last successful MSI authentication attempt's result.
        /// </summary>
        private static SdkAuthResult LatestMsiAuthResult { get; set; }

        /// <summary>
        /// The current environment parameters.
        /// </summary>
        internal static EnvironmentParameters CurrentEnvironmentParameters { get; } = EnvironmentParameters.Prod.Copy();

        /// <summary>
        /// True if the user has never logged in successfully, otherwise false.
        /// </summary>
        internal static bool UserHasNeverLoggedIn => LatestAdalAuthResult == null;

        /// <summary>
        /// True if Managed Service Identity (MSI) authentication should be used, otherwise false.
        /// MSI auth will be used if the MSI_ENDPOINT environment variable has been set, and the user
        /// has never successfully logged in manually.
        /// </summary>
        internal static bool UseMsiAuth => !string.IsNullOrWhiteSpace(ManagedServiceIdentityEndpoint) && LatestAdalAuthResult == null;

        /// <summary>
        /// Refreshes the access token using ADAL if required, otherwise returns the most recent still-valid refresh token.
        /// </summary>
        /// <returns>A valid access token.</returns>
        /// <exception cref="AdalException">If the silent login attempt fails</exception>
        internal static SdkAuthResult RefreshAdalAuth()
        {
            // Make sure there was at least 1 successful login
            if (AuthUtils.UserHasNeverLoggedIn)
            {
                throw new InvalidOperationException($"No successful login attempts were found. Check for this using the '{nameof(AuthUtils)}.{nameof(UserHasNeverLoggedIn)}' property before calling the '{nameof(RefreshAdalAuth)}()' method");
            }

            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.CurrentEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);

            // Check if the existing token has expired
            SdkAuthResult authResult = AuthUtils.LatestAdalAuthResult;
            if (authResult.IsExpired)
            {
                // Try to get a new token for the same user
                AuthenticationResult adalResult;
                try
                {
                    adalResult = authContext.AcquireTokenSilentAsync(
                        environmentParameters.ResourceId,
                        environmentParameters.AppId,
                        new UserIdentifier(authResult.UserUniqueId, UserIdentifierType.UniqueId))
                        .GetAwaiter().GetResult();
                }
                catch (AdalException ex)
                {
                    throw new AdalAuthException(ex.Message, ex);
                }

                // Convert the ADAL result into our own type
                authResult = adalResult.ToSdkAuthResult();

                // Save the auth result
                AuthUtils.LatestAdalAuthResult = authResult;
            }

            return authResult;
        }

        /// <summary>
        /// Refreshes the access token using MSI auth if required, otherwise returns the most recent still-valid refresh token.
        /// </summary>
        /// <returns>A valid access token.</returns>
        /// <exception cref="MsiAuthException">If the login attempt fails</exception>
        internal static SdkAuthResult RefreshMsiAuth()
        {
            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.CurrentEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);
            
            SdkAuthResult authResult = AuthUtils.LatestMsiAuthResult;
            if (authResult == null || authResult.IsExpired)
            {
                // Create the HTTP client
                using (HttpClient client = new HttpClient())
                {

                    // Add the "Metadata:true" header
                    client.DefaultRequestHeaders.Add("Metadata", "true");

                    // Make the request for the desired resource
                    HttpResponseMessage response = client.GetAsync($"{AuthUtils.ManagedServiceIdentityEndpoint}?resource={environmentParameters.ResourceId}")
                        .GetAwaiter().GetResult();

                    // Make sure we successfully retrieved the result
                    if (!response.IsSuccessStatusCode)
                    {
                        // Extract the error code and error message from the failure response
                        string errorCode;
                        string errorMessage;
                        try
                        {
                            // Get the content of the failure response
                            string errorJsonString = response.Content.ReadAsStringAsync()
                                .GetAwaiter().GetResult();
                            JToken errorJson = JToken.Parse(errorJsonString)["error"]?.Value<JToken>();

                            // Extract error code and error message
                            errorCode = errorJson["code"].Value<string>() ?? string.Empty;
                            errorMessage = errorJson["message"].Value<string>() ?? string.Empty;
                        }
                        catch (Exception ex)
                        {
                            throw new MsiAuthException("Unable to authenticate using MSI", ex);
                        }

                        // Build the exception message
                        string exceptionMessage;
                        if (!string.IsNullOrWhiteSpace(errorMessage))
                        {
                            exceptionMessage = errorMessage;
                        }
                        else
                        {
                            exceptionMessage = "Unknown MSI authentication error";
                        }

                        if (!string.IsNullOrWhiteSpace(errorCode))
                        {
                            exceptionMessage = $"{errorCode}: {exceptionMessage}";
                        }

                        // Throw the exception
                        throw new MsiAuthException(exceptionMessage);
                    }

                    // Convert the response from JSON into an object
                    MsiAuthResult msiResult = JsonConvert.DeserializeObject<MsiAuthResult>(response.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult());

                    // Convert the MSI auth result to our own type
                    authResult = msiResult.ToSdkAuthResult();
                }
            }

            return authResult;
        }

        /// <summary>
        /// Utility method for converting an ADAL <see cref="AuthenticationResult"/> into an <see cref="SdkAuthResult"/>.
        /// </summary>
        /// <param name="authenticationResult">The <see cref="AuthenticationResult"/></param>
        /// <returns>An <see cref="SdkAuthResult"/>.</returns>
        private static SdkAuthResult ToSdkAuthResult(this AuthenticationResult authenticationResult)
        {
            return new SdkAuthResult(
                accessTokenType: authenticationResult.AccessTokenType,
                accessToken: authenticationResult.AccessToken,
                userId: authenticationResult.UserInfo.UniqueId,
                expiresOn: authenticationResult.ExpiresOn,
                psUserDisplayableInformation: new
                {
                    UPN = authenticationResult.UserInfo.DisplayableId,
                    TenantId = authenticationResult.TenantId,
                });
        }

        /// <summary>
        /// Represents an auth result from an MSI endpoint.
        /// </summary>
        private class MsiAuthResult
        {
            [JsonProperty(PropertyName = "token_type")]
            internal string AccessTokenType { get; set; }

            [JsonProperty(PropertyName = "access_token")]
            internal string AccessToken { get; set; }

            [JsonProperty(PropertyName = "expires_on")]
            internal DateTimeOffset ExpiresOn { get; set; }

            internal SdkAuthResult ToSdkAuthResult()
            {
                // Use a temporary variable to manipulate the access token
                string accessToken = this.AccessToken;

                // Pad the access token with '=' until it's length is divisible by 4
                accessToken += Enumerable.Repeat('=', 4 - (this.AccessToken.Length % 4));

                // Replace invalid characters
                accessToken = accessToken
                    .Replace('-', '+')
                    .Replace('_', '/');

                // Convert from base64 to a string
                string decodedAccessToken = Encoding.ASCII.GetString(Convert.FromBase64String(accessToken));

                // Convert to an object so we can extract values
                JToken deserializedAccessToken = JToken.Parse(decodedAccessToken);

                // Extract the user data
                string uniqueUserId = deserializedAccessToken["unique_name"]?.Value<string>();
                string tenantId = deserializedAccessToken["tid"]?.Value<string>();

                // TODO: Validate access token by checking its signature

                // Build and return the result
                return new SdkAuthResult(
                    accessTokenType: this.AccessTokenType,
                    accessToken: this.AccessToken,
                    userId: null,
                    expiresOn: this.ExpiresOn,
                    psUserDisplayableInformation: new
                    {
                        UPN = uniqueUserId,
                        TenantId = tenantId,
                    });
            }
        }
    }
}
