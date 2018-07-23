// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Management.Automation;

    /// <summary>
    /// PowerShell authentication error.
    /// </summary>
    internal class PSAuthenticationError : PSGraphSDKException
    {
        /// <summary>
        /// Creates a new <see cref="PSAuthenticationError"/>.
        /// </summary>
        /// <param name="innerException">The inner exception</param>
        /// <param name="specificErrorId">The error ID which should be unique to this error type</param>
        /// <param name="errorCategory">The error category</param>
        /// <param name="targetObject">An object that can provide more debugging information (e.g. the object that caused the error)</param>
        internal PSAuthenticationError(Exception innerException, string specificErrorId, ErrorCategory errorCategory, object targetObject)
            : base(innerException, specificErrorId, errorCategory, targetObject) { }
    }
}
