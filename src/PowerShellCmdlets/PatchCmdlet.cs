// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that update OData resources.
    /// </summary>
    public abstract class PatchCmdlet : PostOrPatchCmdlet
    {
        internal override string GetHttpMethod()
        {
            return "PATCH";
        }
    }
}
