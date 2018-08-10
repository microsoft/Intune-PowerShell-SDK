// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Management.Automation;

    /// <summary>
    /// The exception type that is thrown by cmdlets in the PowerShell Graph SDK.
    /// </summary>
    public class PSGraphSDKException : Exception, IContainsErrorRecord
    {
        /// <summary>
        /// The prefix for the error name.
        /// </summary>
        internal const string ErrorPrefix = "PowerShellGraphSDK_";

        /// <summary>
        /// The PowerShell error record which contains the error details.
        /// </summary>
        public ErrorRecord ErrorRecord { get; private set; }

        /// <summary>
        /// Creates a <see cref="PSGraphSDKException"/>.
        /// </summary>
        /// <param name="innerException">The inner exception</param>
        /// <param name="specificErrorId">The error ID which should be unique to this error type</param>
        /// <param name="errorCategory">The error category</param>
        /// <param name="targetObject">An object that can provide more debugging information (e.g. the object that caused the error)</param>
        internal PSGraphSDKException(Exception innerException, string specificErrorId, ErrorCategory errorCategory, object targetObject)
            : base(specificErrorId, innerException)
        {
            this.ErrorRecord = new ErrorRecord(
                innerException,
                ErrorPrefix + specificErrorId,
                errorCategory,
                targetObject);
        }
    }
}
