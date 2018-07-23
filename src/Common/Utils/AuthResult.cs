// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Net.Http.Headers;
    
    internal class AuthResult
    {
        internal string AccessTokenType { get; }

        internal string AccessToken { get; }

        internal object PSUserDisplayableInformation { get; }

        internal AuthenticationHeaderValue AuthenticationHeaderValue { get; }

        internal AuthResult(string accessTokenType, string accessToken, object psUserDisplayableInformation = null)
        {
            this.AccessTokenType = accessTokenType ?? throw new ArgumentNullException(nameof(accessTokenType));
            this.AccessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
            this.AuthenticationHeaderValue = new AuthenticationHeaderValue(accessTokenType, accessToken);
            this.PSUserDisplayableInformation = psUserDisplayableInformation;
        }
    }
}
