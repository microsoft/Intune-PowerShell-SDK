// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Net.Http.Headers;
    
    internal class SdkAuthResult
    {
        internal string AccessTokenType { get; }

        internal string AccessToken { get; }

        internal object PSUserDisplayableInformation { get; }

        internal AuthenticationHeaderValue AuthenticationHeaderValue { get; }

        internal string UserUniqueId { get; }

        private DateTimeOffset ExpiresOn { get; }

        internal bool IsExpired => (ExpiresOn <= DateTimeOffset.Now);

        internal SdkAuthResult(string accessTokenType, string accessToken, string userId, DateTimeOffset expiresOn, object psUserDisplayableInformation = null)
        {
            this.AccessTokenType = accessTokenType ?? throw new ArgumentNullException(nameof(accessTokenType));
            this.AccessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
            this.UserUniqueId = userId;
            this.AuthenticationHeaderValue = new AuthenticationHeaderValue(accessTokenType, accessToken);
            this.PSUserDisplayableInformation = psUserDisplayableInformation;
            this.ExpiresOn = expiresOn;
        }
    }
}
