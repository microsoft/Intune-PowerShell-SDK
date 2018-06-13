// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that create references from an OData resource to a single entity.
    /// </summary>
    public abstract class PutReferenceToEntityCmdlet : ODataCmdlet
    {
        internal override string GetHttpMethod()
        {
            return "PUT";
        }
    }
}
