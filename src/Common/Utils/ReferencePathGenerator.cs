// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Reflection;
    using PowerShellGraphSDK.PowerShellCmdlets;

    internal class ReferencePathGenerator
    {
        /// <summary>
        /// The cache of cmdlet nouns to <see cref="ReferencePathGenerator"/> objects.
        /// </summary>
        private static IDictionary<string, ReferencePathGenerator> Cache { get; } = new Dictionary<string, ReferencePathGenerator>();

        /// <summary>
        /// An instance of the cmdlet type that we should use to get the resource URL.
        /// </summary>
        private readonly ODataCmdletBase _cmdletInstance;

        /// <summary>
        /// The "id" property on the cmdlet instance that we need to set before getting the resource URL.
        /// </summary>
        private readonly PropertyInfo _idProperty;

        internal ReferencePathGenerator(ODataCmdletBase cmdletInstance)
        {
            this._cmdletInstance = cmdletInstance ?? throw new ArgumentNullException(nameof(cmdletInstance));

            // Get the type of this cmdlet
            Type cmdletType = this._cmdletInstance.GetType();

            // Get the "id" property
            PropertyInfo idProperty = cmdletType.GetProperties()
                .Where(prop => prop.GetCustomAttribute<AliasAttribute>()?.AliasNames?
                    .Contains(ODataConstants.RequestProperties.Id.ToPascalCase()) == true)
                .FirstOrDefault();

            this._idProperty = idProperty;
        }

        internal static void AddToCache(string cmdletNoun, ReferencePathGenerator referencePathGenerator)
        {
            if (string.IsNullOrEmpty(cmdletNoun))
            {
                throw new ArgumentException("Cmdlet noun cannot be null or empty", nameof(cmdletNoun));
            }
            if (referencePathGenerator == null)
            {
                throw new ArgumentNullException(nameof(referencePathGenerator));
            }

            Cache.Add(cmdletNoun, referencePathGenerator);
        }

        internal static bool TryGetFromCache(string cmdletNoun, out ReferencePathGenerator referencePathGenerator)
        {
            if (string.IsNullOrEmpty(cmdletNoun))
            {
                throw new ArgumentException("Cmdlet noun cannot be null or empty", nameof(cmdletNoun));
            }

            return Cache.TryGetValue(cmdletNoun, out referencePathGenerator);
        }

        /// <summary>
        /// Generates a resource path from the given object ID.
        /// </summary>
        /// <param name="id">The ID of the object being referenced</param>
        /// <returns>The generated URL.</returns>
        internal string GenerateResourcePath(string id)
        {
            // Set the ID
            this._idProperty?.SetValue(this._cmdletInstance, id);

            // Create the relative resource path
            string path = this._cmdletInstance.GetResourcePath();

            return path;
        }
    }
}
