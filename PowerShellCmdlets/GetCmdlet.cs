// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Management.Automation;
    using System.Net;
    using System.Reflection;

    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that support $select and $expand query parameters.
    /// </summary>
    public abstract class GetCmdlet : ODataCmdletBase
    {
        /// <summary>
        /// The operation name.
        /// </summary>
        public const string OperationName = "Get";

        /// <summary>
        /// Mapping between parameter names and their type cast.
        /// </summary>
        protected IDictionary<string, string> PropertyNameMappings = new Dictionary<string, string>();

        /// <summary>
        /// The list of $select query option values (i.e. property names).
        /// 
        /// This value is declared as a dynamic parameter so that values can be validated per cmdlet.
        /// </summary>
        private string[] Select = null;

        /// <summary>
        /// The list of $expand query option values (i.e. property names).
        /// 
        /// This value is declared as a dynamic parameter so that values can be validated per cmdlet.
        /// </summary>
        private string[] Expand = null;

        #region Setup

        /// <summary>
        /// Creates a new instance of <see cref="GetCmdlet"/>.
        /// </summary>
        public GetCmdlet()
        {
            // Get the properties
            IEnumerable<PropertyInfo> properties = this.GetProperties(false);

            // Set up type casts
            foreach (PropertyInfo prop in properties)
            {
                // Store the mapping between the parameter name and its type cast if necessary
                if (Attribute.IsDefined(prop, typeof(DerivedTypeAttribute)))
                {
                    DerivedTypeAttribute selectableAttr = prop.GetCustomAttribute<DerivedTypeAttribute>(false);
                    if (!string.IsNullOrWhiteSpace(selectableAttr.FullName))
                    {
                        this.PropertyNameMappings.Add(prop.Name, $"{selectableAttr.FullName}/{prop.Name}");
                    }
                }
            }

            // Create the "Select" parameter if required
            IEnumerable<string> selectValidValues = properties
                .Where(param => Attribute.IsDefined(param, typeof(SelectableAttribute)))
                .Select(param => Attribute.IsDefined(param, typeof(ResourceIdParameterAttribute))
                    ? ODataConstants.SearchResultProperties.Id
                    : param.Name);
            if (selectValidValues.Any())
            {
                var selectParameter = new RuntimeDefinedParameter(
                    nameof(this.Select),
                    typeof(string[]),
                    new Collection<Attribute>()
                    {
                        new ParameterAttribute() { ParameterSetName = GetCmdlet.OperationName },
                        new ParameterAttribute() { ParameterSetName = GetOrSearchCmdlet.OperationName },
                        new ValidateSetAttribute(selectValidValues.ToArray()),
                    });

                // Add to the dictionary of dynamic parameters
                this.DynamicParameters?.Add(nameof(this.Select), selectParameter);
            }

            // Create the "Expand" parameter if required
            IEnumerable<string> expandValidValues = properties
                .Where(param => Attribute.IsDefined(param, typeof(ExpandableAttribute)))
                .Select(param => param.Name);
            if (expandValidValues.Any())
            {
                var expandParameter = new RuntimeDefinedParameter(
                    nameof(this.Expand),
                    typeof(string[]),
                    new Collection<Attribute>()
                    {
                        new ParameterAttribute() { ParameterSetName = GetCmdlet.OperationName },
                        new ParameterAttribute() { ParameterSetName = GetOrSearchCmdlet.OperationName },
                        new ValidateSetAttribute(expandValidValues.ToArray()),
                    });

                // Add to the dictionary of dynamic parameters
                this.DynamicParameters?.Add(nameof(this.Expand), expandParameter);
            }
        }

        /// <summary>
        /// Set up the dynamic parameters.
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            if (this.DynamicParameters != null)
            {
                // Select
                if (this.DynamicParameters.TryGetValue(nameof(Select), out RuntimeDefinedParameter selectParam)
                    && selectParam.IsSet)
                {
                    this.Select = selectParam.Value as string[];
                }

                // Expand
                if (this.DynamicParameters.TryGetValue(nameof(Expand), out RuntimeDefinedParameter expandParam)
                    && expandParam.IsSet)
                {
                    this.Expand = expandParam.Value as string[];
                }
            }
        }

        #endregion Setup

        internal override string GetHttpMethod()
        {
            return "GET";
        }

        internal override IDictionary<string, string> GetUrlQueryOptions()
        {
            IDictionary<string, string> queryOptions = base.GetUrlQueryOptions();

            // Select
            if (this.Select != null && this.Select.Any())
            {
                IEnumerable<string> selectable = this.Select.Select(param =>
                    this.PropertyNameMappings.TryGetValue(param, out string mappedName)
                        ? mappedName
                        : param);
                queryOptions.Add(ODataConstants.QueryParameters.Select, string.Join(",", selectable));
            }

            // Expand
            if (this.Expand != null && this.Expand.Any())
            {
                IEnumerable<string> selectable = this.Expand.Select(param =>
                    this.PropertyNameMappings.TryGetValue(param, out string mappedName)
                        ? mappedName
                        : param);
                queryOptions.Add(ODataConstants.QueryParameters.Expand, string.Join(",", this.Expand));
            }

            return queryOptions;
        }

        internal override object ReadResponse(string content)
        {
            // Convert the string content into a C# object
            object result = base.ReadResponse(content);

            // Check if this is a JSON response
            if (result is PSObject response)
            {
                // Check if this is a collection of results
                if (// Make sure that the "@odata.context" property exists (to make sure that this is an OData response)
                    response.Properties.Any(property => property.Name == ODataConstants.SearchResultProperties.ODataContext)
                    // Make sure that this is for a collection result
                    && ((this is GetOrSearchCmdlet && this.ParameterSetName == GetOrSearchCmdlet.OperationName) || this is FunctionReturningCollectionCmdlet))
                {
                    // Process the results
                    IEnumerable<object> resultObjects = null;
                    if (response.Properties.Any(property => property.Name == ODataConstants.SearchResultProperties.Value))
                    {
                        // Get the values
                        resultObjects = response.Properties[ODataConstants.SearchResultProperties.Value].Value as IEnumerable<object>;

                        // Add an alias to the ID properties of each result object
                        foreach (object obj in resultObjects)
                        {
                            this.ProcessResultObject(obj);
                        }
                    }

                    // If there is no nextLink, unwrap and return just the result objects
                    if (!response.Properties.Any(property => property.Name == ODataConstants.SearchResultProperties.ODataNextLink))
                    {
                        // There were values in the page and there was no nextLink, so unwrap and return the values
                        result = resultObjects;
                    }
                    else
                    {
                        // There was a nextLink - return the whole response so we don't lose the link to the next page
                        result = response;
                    }
                }
                else // The response is not a collection of results, it is just a single object
                {
                    // Process the result object
                    this.ProcessResultObject(result);
                }
            }

            return result;
        }

        #region Helpers

        /// <summary>
        /// Creates the URL segment containing the function name and arguments.
        /// </summary>
        /// <returns>The URL segment containing the function name and arguments.</returns>
        public string GetFunctionUrlSegment()
        {
            Type cmdletType = this.GetType();
            if (!(this is FunctionReturningEntityCmdlet) &&
                !(this is FunctionReturningCollectionCmdlet))
            {
                throw new PSArgumentException($"Cannot call method '{nameof(GetFunctionUrlSegment)}()' on a cmdlet of type '{cmdletType}'.");
            }

            // Create the list of arguments
            IEnumerable<string> paramArguments = this.GetBoundProperties(false).Select(param =>
            {
                object paramValue = param.GetValue(this);
                Type paramType = param.PropertyType;
                string oDataType = param.GetODataTypeAttribute()?.TypeFullName;

                // Check if we need special handling of the value based on the parameter type
                string paramArgumentValue = paramValue.ToODataString(oDataType, isArray: paramType.IsArray, isUrlValue: true);

                // Create the parameter mapping
                return $"{param.Name}={WebUtility.UrlEncode(paramArgumentValue)}";
            });

            // Join the list of arguments
            string result = string.Join(",", paramArguments);

            return result;
        }

        #endregion Helpers
    }
}
