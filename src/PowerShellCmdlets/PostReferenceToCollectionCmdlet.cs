// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that create references from an OData resource to a collection.
    /// </summary>
    public abstract class PostReferenceToCollectionCmdlet : ODataCmdletBase
    {
        internal override string GetHttpMethod()
        {
            return "POST";
        }
    }
}
