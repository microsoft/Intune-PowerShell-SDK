// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;

    internal class MsiAuthException : AuthException
    {
        internal MsiAuthException(string message) : base(message)
        {
        }

        internal MsiAuthException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
