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

        /// <summary>
        /// The URL placeholder properties on the cmdlet instance that we need to set before getting the resource URL.
        /// </summary>
        private readonly IEnumerable<PropertyInfo> _placeholderProperties;

        internal ReferencePathGenerator(ODataCmdletBase cmdletInstance)
        {
            this._cmdletInstance = cmdletInstance ?? throw new ArgumentNullException(nameof(cmdletInstance));

            // Get the type of this cmdlet
            Type cmdletType = this._cmdletInstance.GetType();

            // Get the "id" property
            this._idProperty = cmdletType.GetProperties()
                .Where(prop => prop.GetCustomAttribute<AliasAttribute>()?.AliasNames?
                    .Contains(ODataConstants.RequestProperties.Id) == true)
                .FirstOrDefault();

            // Get the placeholder properties
            this._placeholderProperties = cmdletType.GetProperties()
                .Where(prop =>
                    // ID properties (except the entity ID property that we just retrieved)
                    (prop != this._idProperty && prop.GetCustomAttribute<IdParameterAttribute>() != null)
                    // Type cast properties
                    || prop.GetCustomAttribute<TypeCastParameterAttribute>() != null);
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
        /// <param name="currentCmdlet">The currently running cmdlet (which has the properties that represent URL placeholders)</param>
        /// <param name="id">The ID of the object being referenced</param>
        /// <returns>The generated URL.</returns>
        internal string GenerateResourcePath(ODataCmdletBase currentCmdlet, string id)
        {
            // Set the entity ID
            this._idProperty?.SetValue(this._cmdletInstance, id);

            // Set the placeholder properties
            foreach (PropertyInfo property in this._placeholderProperties)
            {
                // Get the equivalent property on the current cmdlet (if the type is different)
                PropertyInfo currentCmdletProperty = property;
                Type currentCmdletType = currentCmdlet.GetType();
                if (currentCmdletType != this._cmdletInstance.GetType())
                {
                    // The property name and type must match
                    currentCmdletProperty = currentCmdletType.GetProperty(property.Name, property.PropertyType);
                }

                // Get the value from the currently running cmdlet
                object propertyValue = currentCmdletProperty.GetValue(currentCmdlet);

                // Set the cached cmdlet instance's equivalent property to the same value
                property.SetValue(this._cmdletInstance, propertyValue);
            }

            // Create the relative resource path
            string path = this._cmdletInstance.GetResourcePath();

            return path;
        }
    }
}
