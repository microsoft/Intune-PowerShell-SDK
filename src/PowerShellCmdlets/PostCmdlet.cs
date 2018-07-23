// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that create OData resources.
    /// </summary>
    public abstract class PostCmdlet : PostOrPatchCmdlet
    {
        internal override string GetHttpMethod()
        {
            return "POST";
        }

        internal override object ReadResponse(string content)
        {
            // Convert the string content into a C# object
            object result = base.ReadResponse(content);

            // Check if this is a JSON response
            if (result is PSObject response)
            {
                // Process the result object
                this.ProcessResultObject(result);
            }

            return result;
        }
    }
}
