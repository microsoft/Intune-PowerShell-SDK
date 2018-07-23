// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Net.Http.Headers;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    internal static partial class AuthUtils
    {
        /// <summary>
        /// The query parameter to use when triggering the admin consent flow.
        /// </summary>
        private const string AdminConsentQueryParameter = "prompt=admin_consent";

        /// <summary>
        /// The last successful authentication attempt's result.
        /// </summary>
        private static AuthenticationResult LatestAuthResult { get; set; }

        /// <summary>
        /// The current environment parameters.
        /// </summary>
        internal static EnvironmentParameters CurrentEnvironmentParameters { get; } = EnvironmentParameters.Prod.Copy();

        /// <summary>
        /// True if the user has never logged in, otherwise false.
        /// </summary>
        internal static bool UserHasNeverLoggedIn => LatestAuthResult == null;

        /// <summary>
        /// Refreshes the access token if required, otherwise returns the most recent still-valid refresh token.
        /// </summary>
        /// <returns>A valid access token.</returns>
        /// <exception cref="AdalException">If the silent login attempt fails</exception>
        internal static AuthResult RefreshAuthIfRequired()
        {
            // Make sure there was at least 1 successful login
            if (AuthUtils.UserHasNeverLoggedIn)
            {
                throw new ArgumentException($"No successful login attempts were found. Check for this using the '{nameof(AuthUtils)}.{nameof(UserHasNeverLoggedIn)}' property before calling the '{nameof(RefreshAuthIfRequired)}()' method");
            }

            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.CurrentEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);

            // Check if the existing token has expired
            AuthenticationResult authResult = AuthUtils.LatestAuthResult;
            if (authResult.ExpiresOn <= DateTimeOffset.Now)
            {
                // Try to get a new token for the same user
                authResult = authContext.AcquireTokenSilentAsync(
                    environmentParameters.ResourceId,
                    environmentParameters.AppId,
                    new UserIdentifier(AuthUtils.LatestAuthResult.UserInfo.UniqueId, UserIdentifierType.UniqueId))
                    .GetAwaiter().GetResult();

                // Save the auth result
                AuthUtils.LatestAuthResult = authResult;
            }

            return authResult.ToAuthResult();
        }

        private static AuthResult ToAuthResult(this AuthenticationResult authResult)
        {
            return new AuthResult(
                authResult.AccessTokenType,
                authResult.AccessToken,
                psUserDisplayableInformation: new
                {
                    UPN = authResult.UserInfo.DisplayableId,
                    TenantId = authResult.TenantId,
                });
        }
    }
}
