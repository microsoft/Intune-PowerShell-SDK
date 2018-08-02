// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    internal class AdalAuthException : AuthException
    {
        internal AdalAuthException(string message, AdalException innerException) : base(message, innerException)
        {
        }
    }
}
