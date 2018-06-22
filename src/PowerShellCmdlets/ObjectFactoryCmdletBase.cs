// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Linq;
    using System.Management.Automation;
    using PowerShellGraphSDK;

    /// <summary>
    /// The common behavior between all cmdlets that are used to create PowerShell objects which represent entities in the OData schema.
    /// </summary>
    public abstract class ObjectFactoryCmdletBase : PSCmdlet
    {
        /// <summary>
        /// The method that the PowerShell runtime will call.  This is the entry point for the cmdlet.
        /// </summary>
        protected override void ProcessRecord()
        {
            // Create a PowerShell object from the bound properties
            object result = this.GetBoundProperties()
                .ToDictionary(
                    prop => prop.Name,
                    prop => prop.GetValue(this))
                .ToPowerShellObject();

            // Send the object to the pipeline
            this.WriteObject(result);
        }
    }
}
