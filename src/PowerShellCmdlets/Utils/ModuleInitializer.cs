// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Reflection;

    /// <summary>
    /// Initializes this PowerShell module.
    /// </summary>
    public class ModuleInitializer : IModuleAssemblyInitializer
    {
        /// <summary>
        /// The initialization logic for this PowerShell module.
        /// </summary>
        public void OnImport()
        {
            InitReferenceUrlGeneratorCache();
        }

        /// <summary>
        /// Creates the reference URL generator cache.
        /// </summary>
        private void InitReferenceUrlGeneratorCache()
        {
            // Get all the types in all assemblies
            IEnumerable<Type> allTypes = AppDomain.CurrentDomain.GetAssemblies()
                // Get all types in all assemblies
                .SelectMany(assembly => assembly.GetTypes());

            // Get all the cmdlets that return resources (i.e. not "$ref", function or action cmdlets)
            IEnumerable<Type> referenceableCmdletTypes = allTypes
                // Select only the types that represent "$ref" cmdlets
                .Where(type => type.IsClass && !type.IsAbstract
                    // Namespace is "PowerShellGraphSDK.PowerShellCmdlets"
                    && type.Namespace == $"{nameof(PowerShellGraphSDK)}.{nameof(PowerShellGraphSDK.PowerShellCmdlets)}"
                    // Is a "GET" cmdlet that returns resources that can be referenced
                    && typeof(GetCmdlet).IsAssignableFrom(type) && type.GetCustomAttribute<ResourceReferenceAttribute>() != null);

            // For each "GET" cmdlet, create a mapping to a ReferencePathGenerator
            foreach (Type cmdletType in referenceableCmdletTypes)
            {
                // Construct an instance of the cmdlet
                ODataCmdlet cmdlet = cmdletType
                    .GetConstructor(Array.Empty<Type>())?
                    .Invoke(Array.Empty<object>())
                    as ODataCmdlet;

                // Get this cmdlet name's noun
                string cmdletNoun = cmdletType.GetCmdletNoun();

                // Make sure we were able to construct an instance of the cmdlet
                if (cmdlet != null)
                {
                    // Create the URL generator
                    ReferencePathGenerator urlGenerator = new ReferencePathGenerator(cmdlet);

                    // Add the mapping
                    ReferencePathGenerator.AddToCache(cmdletNoun, urlGenerator);
                }
            }
        }
    }
}
