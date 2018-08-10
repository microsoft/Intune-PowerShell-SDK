// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;

    internal abstract class AuthException : Exception
    {
        internal AuthException(string message) : base(message)
        {
        }

        internal AuthException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
