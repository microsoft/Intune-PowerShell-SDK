// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets.Utils
{
    using System;
    using System.Management.Automation;

    internal static class ExceptionUtils
    {
        /// <summary>
        /// Writes an exception to the PowerShell console.  If the exception does not represent a PowerShell error,
        /// it will be wrapped in a PowerShell error object before being written to the console.
        /// </summary>
        /// <param name="cmdlet">The cmdlet which is writing the error</param>
        /// <param name="ex">The exception to write to the console</param>
        internal static void WriteError(this Cmdlet cmdlet, Exception ex)
        {
            ErrorRecord errorRecord;
            if (ex is IContainsErrorRecord powerShellError)
            {
                errorRecord = powerShellError.ErrorRecord;
            }
            else
            {
                errorRecord = new ErrorRecord(
                    ex,
                    PSGraphSDKException.ErrorPrefix + "UnknownError",
                    ErrorCategory.OperationStopped,
                    null);
            }

            cmdlet.WriteError(errorRecord);
        }
    }
}
