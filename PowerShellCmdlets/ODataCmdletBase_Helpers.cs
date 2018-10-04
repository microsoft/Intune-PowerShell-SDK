// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Reflection;
    using System.Text;

    public abstract partial class ODataCmdletBase
    {
        internal string BuildUrl(string resourcePath)
        {
            // Check that we have a valid base address
            string baseAddress = AuthUtils.CurrentEnvironmentParameters.GraphBaseAddress;
            if (!Uri.IsWellFormedUriString(baseAddress, UriKind.Absolute))
            {
                throw new PSGraphSDKException(
                    new ArgumentException($"Invalid base URL - use the '{UpdateEnvironmentParameters.CmdletVerb}-{UpdateEnvironmentParameters.CmdletNoun}' cmdlet to set it to a valid URL", "BaseUrl"),
                    "InvalidBaseUrl",
                    ErrorCategory.InvalidArgument,
                    baseAddress);
            }

            // Get the full base URL
            string baseUrlWithSchema = $"{baseAddress.TrimEnd('/')}/{AuthUtils.CurrentEnvironmentParameters.SchemaVersion}";

            // TODO: Sanitize the URL
            //resourcePath = WebUtility.UrlEncode(resourcePath);

            // Append the relative URL to the base URL
            string result = $"{baseUrlWithSchema}/{resourcePath.Trim('/')}";

            return result;
        }

        /// <summary>
        /// Creates a JSON string from the given properties.
        /// </summary>
        /// <param name="properties">The properties on this cmdlet object which should be serialized into the JSON string</param>
        /// <param name="oDataType">The OData type (full name) to be included in the JSON string</param>
        /// <returns>The JSON string.</returns>
        internal string WriteJsonFromProperties(IEnumerable<PropertyInfo> properties, string oDataType = null)
        {
            // We need to build the JSON string manually in order to account for special handling of primitive Edm (OData) types.
            // See the spec for more details: http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part3-csdl/odata-v4.0-errata03-os-part3-csdl-complete.html#_The_edm:Documentation_Element
            StringBuilder jsonString = new StringBuilder();
            jsonString.AppendLine("{");

            bool isFirst = true;

            // Add the OData type property into the request body
            if (oDataType != null)
            {
                jsonString.Append($"    \"{ODataConstants.RequestProperties.ODataType}\": \"{oDataType}\"");
                isFirst = false;
            }

            // Add the properties into the body
            foreach (PropertyInfo property in properties)
            {
                if (!isFirst)
                {
                    jsonString.AppendLine(",");
                }
                isFirst = false;

                // Get the name and value for the given property on this instance of the cmdlet
                string propertyName = property.Name;
                object propertyValue = property.GetValue(this);

                // Get the type of this property
                string propertyODataType = property.GetODataTypeAttribute()?.TypeFullName;

                // Figure out whether this property is an array
                bool isArray = property.PropertyType.IsArray;

                // Convert the value into a JSON string
                string propertyValueString = propertyValue.ToODataString(propertyODataType, isArray);
                jsonString.Append($"    \"{propertyName}\": {propertyValueString}");
            }
            jsonString.AppendLine();
            jsonString.Append('}');

            // Return the JSON string
            return jsonString.ToString();
        }

        /// <summary>
        /// Creates the content object for a POST/PUT "$ref" call.
        /// </summary>
        /// <param name="referenceUrl">The URL which can be used to retrieve the object that is being referenced</param>
        /// <returns>The content object for a POST/PUT "$ref" call.</returns>
        internal IDictionary<string, string> GetReferenceRequestContent(string referenceUrl)
        {
            // Return the object which is to be serialized into the body of the request
            return new Dictionary<string, string>()
            {
                { ODataConstants.RequestProperties.ODataId, $"{referenceUrl}" }
            };
        }

        internal IEnumerable<PropertyInfo> GetTypeCastParameters()
        {
            return this.GetBoundProperties()
                .Where(property =>
                    property.PropertyType == typeof(string)
                    && property.GetCustomAttribute<TypeCastParameterAttribute>() != null);
        }

        /// <summary>
        /// Gets the names and values of the parameters which are used to specify type casts in the URL.
        /// </summary>
        /// <returns>The names and values of the parameters which are used to specify type casts in the URL.</returns>
        internal IDictionary<string, string> GetTypeCastParametersAndValues()
        {
            return this.GetTypeCastParameters()
                .GroupBy(property => property.Name)
                .ToDictionary(group => group.Key, group => group.First().GetValue(this) as string);
        }

        /// <summary>
        /// Gets the name of the property that should hold the object's type name.
        /// </summary>
        /// <returns>The name of the property that should hold the object's type name.</returns>
        internal string GetResourceTypePropertyName()
        {
            return this.GetType().GetCustomAttribute<ResourceTypePropertyNameAttribute>()?.ResourceTypePropertyName;
        }

        /// <summary>
        /// Gets the name of the property that should hold the object's ID.
        /// </summary>
        /// <returns>The name of the property that should hold the object's ID.</returns>
        internal string GetResourceIdPropertyName()
        {
            return this.GetProperties(false)
                .Where(prop => prop.GetCustomAttribute<ResourceIdParameterAttribute>() != null)
                .SingleOrDefault()?
                .Name;
        }

        /// <summary>
        /// Returns the ID parameters that are used to specify IDs in the URL.
        /// </summary>
        /// <returns>The ID parameters that are used to specify IDs in the URL.</returns>
        internal IEnumerable<PropertyInfo> GetIdParameterProperties()
        {
            return this.GetBoundProperties()
                .Where(property =>
                    property.PropertyType == typeof(string)
                    && property.GetCustomAttribute<IdParameterAttribute>() != null);
        }

        /// <summary>
        /// Gets the names and values of the ID parameters that are used to specify IDs in the URL.
        /// </summary>
        /// <returns>The names and values of the ID parameters that are used to specify IDs in the URL.</returns>
        internal IDictionary<string, string> GetIdParameterNamesAndValues()
        {
            return this.GetIdParameterProperties()
                .GroupBy(property => property.Name)
                .ToDictionary(group => group.Key, group => group.First().GetValue(this) as string);
        }

        internal bool IsReferencableResource()
        {
            return this.GetType().GetCustomAttribute<ResourceReferenceAttribute>() != null;
        }

        /// <summary>
        /// Processes a result object.
        /// </summary>
        /// <param name="obj">The result object to process</param>
        internal void ProcessResultObject(object obj)
        {
            if (obj is PSObject psObj)
            {
                // Track the properties to hide
                ICollection<string> propertiesToHide = new List<string>();

                // Add alias for the "id" property if it exists on the result object
                string objectId = psObj.Properties[ODataConstants.SearchResultProperties.Id]?.Value as string;
                if (objectId != null)
                {
                    // Get the name of the alias property
                    string idPropertyName = this.GetResourceIdPropertyName();
                    if (idPropertyName != null)
                    {
                        // Create the alias
                        psObj.Properties.Add(new PSAliasProperty(idPropertyName, ODataConstants.SearchResultProperties.Id));

                        // Hide this property
                        propertiesToHide.Add(idPropertyName);
                    }
                }

                // ID parameters for parent resources
                foreach (var entry in this.GetIdParameterNamesAndValues())
                {
                    // Create the property
                    string propertyName = entry.Key;
                    string propertyValue = entry.Value;
                    psObj.Properties.Add(new PSNoteProperty(propertyName, propertyValue));

                    // Hide this property
                    propertiesToHide.Add(propertyName);
                }

                // Type cast parameters for parent resources
                foreach (var entry in this.GetTypeCastParametersAndValues())
                {
                    // Add a property to store the type name
                    string propertyName = entry.Key;
                    string propertyValue = entry.Value;
                    psObj.Properties.Add(new PSNoteProperty(propertyName, propertyValue));

                    // Hide this property
                    propertiesToHide.Add(propertyName);
                }

                // Get the type name without the leading "#"
                string typeName = (psObj.Properties[ODataConstants.SearchResultProperties.ODataType]?.Value as string)?.TrimStart('#');
                if (string.IsNullOrEmpty(typeName))
                {
                    typeName = this.GetType().GetCustomAttribute<ODataTypeAttribute>(false)?.TypeFullName;
                }

                if (typeName != null)
                {
                    // Add the type name to the list of PowerShell type names for this object
                    psObj.TypeNames.Insert(0, typeName);

                    // Add the type cast property
                    string typeCastPropertyName = this.GetResourceTypePropertyName();
                    psObj.Properties.Add(new PSNoteProperty(typeCastPropertyName, typeName));

                    // Hide the type cast property
                    propertiesToHide.Add(typeCastPropertyName);

                    // If this cmdlet retrieves resources that can be referenced, add a property to represent the URL which can be used to retrieve this object
                    if (ReferencePathGenerator.TryGetFromCache(this.GetCmdletNoun(), out ReferencePathGenerator pathGenerator))
                    {
                        // Get the full resource URL
                        string referencePath = pathGenerator.GenerateResourcePath(this, objectId);
                        string referenceUrl = this.BuildUrl(referencePath);

                        // Add this reference URL as a property
                        string referenceUrlPropertyName = ODataTypeUtils.GetReferenceUrlParameterName(typeName);
                        psObj.Properties.Add(new PSNoteProperty(referenceUrlPropertyName, referenceUrl));

                        // Hide this property
                        propertiesToHide.Add(referenceUrlPropertyName);
                    }
                }

                // Hide the properties we have been tracking
                psObj.SetDefaultDisplayProperties(prop => !propertiesToHide.Contains(prop.Name));
            }
        }
    }
}
