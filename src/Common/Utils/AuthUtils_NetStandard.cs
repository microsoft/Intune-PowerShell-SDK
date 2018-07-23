// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

#if NETSTANDARD

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    internal static partial class AuthUtils
    {
        /// <summary>
        /// Authenticates using the device code flow. See here for more information:
        /// https://azure.microsoft.com/en-us/resources/samples/active-directory-dotnet-deviceprofile/.
        /// </summary>
        /// <param name="displayDeviceCodeMessageToUser">
        /// The action which displays the message from ADAL (containing the retrieved device code) to the user.
        /// The message will instruct the user to enter the device code by navigating to http://aka.ms/devicelogin/.
        /// </param>
        /// <param name="useAdminConsentFlow">
        /// Whether or not to trigger the admin consent flow for this app ID.
        /// </param>
        /// <returns>The HTTP header to use when making calls.</returns>
        internal static AuthResult AuthWithDeviceCode(
            Action<string> displayDeviceCodeMessageToUser,
            bool useAdminConsentFlow = false)
        {
            if (displayDeviceCodeMessageToUser == null)
            {
                throw new ArgumentNullException(nameof(displayDeviceCodeMessageToUser));
            }

            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.CurrentEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);

            if (useAdminConsentFlow)
            {
                // Remove this user's token from the token cache so they have to log in again (we must use the "Auto" Prompt behavior to add query parameters)
                AuthenticationResult currentLogin = AuthUtils.LatestAuthResult;
                if (currentLogin != null)
                {
                    // Find all the items in the cache with the logged in user ID, client ID and resource ID
                    IEnumerable<TokenCacheItem> toRemove = authContext.TokenCache.ReadItems()
                        .Where(
                            tokenCacheItem => tokenCacheItem.UniqueId == currentLogin.UserInfo.UniqueId
                            && tokenCacheItem.ClientId == environmentParameters.AppId
                            && tokenCacheItem.Resource == environmentParameters.ResourceId);

                    // Remove the items
                    foreach (TokenCacheItem tokenCacheItem in toRemove)
                    {
                        authContext.TokenCache.DeleteItem(tokenCacheItem);
                    }
                }
            }

            // Get the device code
            DeviceCodeResult deviceCodeResult = authContext.AcquireDeviceCodeAsync(
                environmentParameters.ResourceId,
                environmentParameters.AppId,
                useAdminConsentFlow ? AuthUtils.AdminConsentQueryParameter : null)
                .GetAwaiter().GetResult();

            // Display the device code
            displayDeviceCodeMessageToUser(deviceCodeResult.Message);

            // Get the auth token
            //TODO: Figure out why this call hangs and crashes the PowerShell session if the first login was cancelled and the second login times out
            AuthenticationResult authResult = authContext.AcquireTokenByDeviceCodeAsync(deviceCodeResult).GetAwaiter().GetResult();

            // Save the auth result
            AuthUtils.LatestAuthResult = authResult;

            return authResult.ToAuthResult();
        }
    }
}

#endif
