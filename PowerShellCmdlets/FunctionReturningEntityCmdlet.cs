// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that call OData functions that return a single entity.
    /// </summary>
    public abstract class FunctionReturningEntityCmdlet : GetCmdlet
    {
        // TODO: Allow dynamic parameters once the generator supports them
        /// <summary>
        /// Creates a new <see cref="FunctionReturningEntityCmdlet"/>.
        /// </summary>
        public FunctionReturningEntityCmdlet()
        {
            this.DynamicParameters = null;
        }
    }
}
