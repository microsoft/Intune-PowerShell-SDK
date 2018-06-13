// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class AuthUtils
    {
        internal static EnvironmentParameters DefaultEnvironmentParameters { get; private set; } = null;

        internal static AuthenticationResult LatestAuthResult { get; private set; }

        private const string AdminConsentQueryParameter = "prompt=admin_consent";

        /// <summary>
        /// Authenticates with the given environment parameters.
        /// </summary>
        /// <param name="promptBehavior">The ADAL prompt behavior</param>
        /// <returns>The authentication result.</returns>
        /// <exception cref="AdalException">If authentication fails</exception>
        internal static AuthenticationResult Auth(PromptBehavior promptBehavior = PromptBehavior.Auto)
        {
            if (AuthUtils.DefaultEnvironmentParameters == null)
            {
                AuthUtils.DefaultEnvironmentParameters = EnvironmentParameters.Prod.Copy();
                promptBehavior = PromptBehavior.SelectAccount;
            }

            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.DefaultEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);

            // Get the AuthenticationResult from AAD
            LatestAuthResult = authContext.AcquireTokenAsync(
               environmentParameters.ResourceId,
               environmentParameters.ClientId,
               new Uri(environmentParameters.RedirectLink),
               new PlatformParameters(promptBehavior))
               .GetAwaiter().GetResult();

            // Update the cached EnvironmentParameters
            DefaultEnvironmentParameters = environmentParameters;

            return LatestAuthResult;
        }

        /// <summary>
        /// Performs an admin consent interaction.
        /// </summary>
        internal static AuthenticationResult GrantAdminConsent()
        {
            if (AuthUtils.DefaultEnvironmentParameters == null)
            {
                AuthUtils.DefaultEnvironmentParameters = EnvironmentParameters.Prod.Copy();
            }

            // Get the environment parameters
            EnvironmentParameters environmentParameters = AuthUtils.DefaultEnvironmentParameters;

            // Create auth context that we will use to connect to the AAD endpoint
            AuthenticationContext authContext = new AuthenticationContext(environmentParameters.AuthUrl);

            // Remove this user's token from the token cache so they have to log in again
            AuthenticationResult currentLogin = AuthUtils.LatestAuthResult;
            if (currentLogin != null)
            {
                // Find all the items in the cache with the logged in user ID, client ID and resource ID
                IEnumerable<TokenCacheItem> toRemove = authContext.TokenCache.ReadItems()
                    .Where(
                        tokenCacheItem => tokenCacheItem.UniqueId == currentLogin.UserInfo.UniqueId
                        && tokenCacheItem.ClientId == environmentParameters.ClientId
                        && tokenCacheItem.Resource == environmentParameters.ResourceId);

                // Remove the items
                foreach (TokenCacheItem tokenCacheItem in toRemove)
                {
                    authContext.TokenCache.DeleteItem(tokenCacheItem);
                }
            }

            // Get the AuthenticationResult from AAD
            AuthenticationResult result = authContext.AcquireTokenAsync(
               environmentParameters.ResourceId,
               environmentParameters.ClientId,
               new Uri(environmentParameters.RedirectLink),
               new PlatformParameters(PromptBehavior.Auto),
               UserIdentifier.AnyUser,
               AdminConsentQueryParameter)
               .GetAwaiter().GetResult();

            return result;
        }
    }
}
