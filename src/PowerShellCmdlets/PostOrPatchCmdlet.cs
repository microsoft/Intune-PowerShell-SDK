// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Net.Http;
    using System.Reflection;

    /// <summary>
    /// The common behavior between cmdlets that create or update OData resources.
    /// </summary>
    public abstract class PostOrPatchCmdlet : ODataCmdlet
    {
        /// <summary>
        /// The name of the parameter set which allows manual selection of the OData type.
        /// </summary>
        public const string SharedParameterSet = "ManualTypeSelection";

        /// <summary>
        /// <para type="description">The value provided in a search result (i.e. GET on a collection) in the "@odata.type" property.</para>
        /// </summary>
        [Parameter(
            ParameterSetName = SharedParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [Alias(ODataConstants.RequestProperties.ODataType)]
        public string ODataType { get; set; }

        internal override object GetContent()
        {
            // Get the properties that were set by the user in this invocation of the PowerShell cmdlet
            IEnumerable<PropertyInfo> boundProperties = this.GetBoundProperties(includeInherited: false);

            // Get the OData type based on which parameters were bound
            string selectedODataType = this.GetODataType();

            // Make sure that the selected type is not null or whitespace
            if (string.IsNullOrWhiteSpace(selectedODataType))
            {
                throw new PSArgumentException("Either the ODataType parameter or a type switch parameter must be set");
            }

            // If the type is missing the leading "#", add it
            if (!selectedODataType.StartsWith("#"))
            {
                selectedODataType = "#" + selectedODataType;
                this.WriteWarning($"The ODataType should start with a '#' character.  Prepending ODataType with '#': '{selectedODataType}'");
            }

            // Get the rest of the properties that will be serialized into the request body
            IEnumerable<PropertyInfo> typeProperties = boundProperties.Where(property =>
                property.Name != nameof(this.ODataType) // don't include the ODataType parameter since we already got it
                && property.GetODataTypeName() != null // don't include properties that don't have an OData type associated
                && !this.GetParameterSetSelectorProperties().Contains(property) // don't include the switch parameters
            );

            // Create the JSON string
            string jsonBody = this.WriteJsonFromProperties(typeProperties, selectedODataType);

            return jsonBody;
        }

        internal override HttpContent WriteContent(object content)
        {
            // This should already be a serialized JSON string (provided by the GetContent() method)
            string stringContent = content as string;

            return stringContent == null ? null : new StringContent(stringContent);
        }

        #region Helper Methods

        /// <summary>
        /// Gets the currently selected OData type.
        /// </summary>
        /// <returns>The OData type.</returns>
        /// <exception cref="PSArgumentException">If neither the ODataType property nor any of the type switches are set.</exception>
        private string GetODataType()
        {
            // Get the bound properties
            IEnumerable<PropertyInfo> boundProperties = this.GetBoundProperties();

            // If ODataType was not set, pick the appropriate value based on the parameter set selector that was set
            bool isODataTypeSet = boundProperties.Any(prop => prop.Name == nameof(this.ODataType));
            if (!isODataTypeSet)
            {
                // Try to get the switch parameter which represents the OData type
                IEnumerable<PropertyInfo> typeSelectorPropertyInfos = this.GetParameterSetSelectorProperties();

                // If no parameter set selector was set, try to use the parameter set name (this may be the case for cmdlets which only deal with 1 OData type)
                if (!typeSelectorPropertyInfos.Any())
                {
                    return this.ParameterSetName; //throw new PSArgumentException("Either the ODataType parameter or one of the type switches must be set");
                }

                // If more than 1 parameter set selector was set, throw an exception
                PropertyInfo typeSelectorPropertyInfo = typeSelectorPropertyInfos.SingleOrDefault();
                if (typeSelectorPropertyInfo == null)
                {
                    throw new PSArgumentException($"Multiple type switches were set, but only 1 type switch is allowed per invocation of this cmdlet - these are the type switches that were set: [{string.Join(", ", "'" + typeSelectorPropertyInfos.Select(info => info.Name) + "'")}]");
                }

                // Get the ParameterSetSelector attribute
                ParameterSetSelectorAttribute typeSelectorSwitchAttribute = typeSelectorPropertyInfo
                    .GetCustomAttributes<ParameterSetSelectorAttribute>()
                    .SingleOrDefault();

                // Get the OData type name from the "ParameterSetSelector" attribute (parameter set name is the OData type name)
                return typeSelectorSwitchAttribute.ParameterSetName;
            }
            else
            {
                // If ODataType was set, make sure that no parameter set selector was set
                if (this.GetParameterSetSelectorProperties().Any())
                {
                    throw new PSArgumentException($"Type switches cannot be used if the '{nameof(this.ODataType)}' parameter is set");
                }

                // Set the result to the value of the ODataType parameter
                return this.ODataType;
            }
        }

        private IEnumerable<PropertyInfo> _parameterSetSelectorProperties = null;
        private IEnumerable<PropertyInfo> GetParameterSetSelectorProperties()
        {
            if (this._parameterSetSelectorProperties == null)
            {
                IEnumerable<PropertyInfo> parameterSetSelectorProperties = this.GetBoundProperties()
                    .Where(prop =>
                        prop.PropertyType == typeof(SwitchParameter) // get the switch parameters
                        && prop.GetCustomAttributes<ParameterSetSelectorAttribute>().Any() // which have the "ParameterSetSelector" attribute
                        && ((SwitchParameter)prop.GetValue(this)).IsPresent); // and are also set to true

                this._parameterSetSelectorProperties = parameterSetSelectorProperties;
            }

            return this._parameterSetSelectorProperties;
        }

        #endregion Helper Methods
    }
}
