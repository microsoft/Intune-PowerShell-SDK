// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that retrieve data streams.
    /// </summary>
    public abstract class GetStreamCmdlet : ODataCmdletBase
    {
        internal override object ReadResponse(string content)
        {
            return content;
        }
    }
}
