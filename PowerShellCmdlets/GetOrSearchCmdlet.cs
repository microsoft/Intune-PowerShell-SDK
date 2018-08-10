// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Management.Automation;
    using System.Net.Http.Headers;
    using System.Reflection;

    /// <summary>
    /// The common behavior between all OData PowerShell SDK cmdlets that support
    /// $select, $expand, $filter, $orderBy, $skip and $top query parameters.
    /// </summary>
    public abstract class GetOrSearchCmdlet : GetCmdlet
    {
        /// <summary>
        /// The operation name.
        /// </summary>
        public new const string OperationName = "Search";

        /// <summary>
        /// The string that should be postfixed to the property name to sort results in ascending order.
        /// </summary>
        private const string OrderByAscPostfix = "asc";

        /// <summary>
        /// The string that should be postfixed to the property name to sort results in descending order.
        /// </summary>
        private const string OrderByDescPostfix = "desc";

        /// <summary>
        /// <para type="description">The "$filter" query option value.</para>
        /// </summary>
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        public string Filter { get; set; }

        /// <summary>
        /// The list of "$orderBy" query option values (i.e. property names).
        /// 
        /// This value is declared as a dynamic parameter so that values can be validated per cmdlet.
        /// </summary>
        public string[] OrderBy = null;

        /// <summary>
        /// <para type="description">The "$skip" query option value.</para>
        /// </summary>
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        public int? Skip { get; set; }

        /// <summary>
        /// <para type="description">The "$top" query option value.</para>
        /// </summary>
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        [Alias("First")] // Required to be compatible with the PowerShell paging parameters
        public int? Top { get; set; }

        /// <summary>
        /// <para type="description">The "Prefer: odata.maxpagesize" header value.</para>
        /// </summary>
        [Parameter(ParameterSetName = GetOrSearchCmdlet.OperationName)]
        public int? MaxPageSize { get; set; }

        /// <summary>
        /// Creates a new <see cref="GetOrSearchCmdlet"/>.
        /// </summary>
        public GetOrSearchCmdlet()
        {
            // Get the properties
            IEnumerable<PropertyInfo> properties = this.GetProperties(false);

            // Create the "OrderBy" parameter
            IEnumerable<string> orderByValidValues = properties
                .Where(param => Attribute.IsDefined(param, typeof(SortableAttribute)))
                .SelectMany(param => new string[] { $"{param.Name} {OrderByAscPostfix}", $"{param.Name} {OrderByDescPostfix}" });
            if (orderByValidValues.Any())
            {
                // Create the collection of attributes
                var orderByParameter = new RuntimeDefinedParameter(
                    nameof(this.OrderBy),
                    typeof(string[]),
                    new Collection<Attribute>()
                    {
                        new ParameterAttribute() { ParameterSetName = GetOrSearchCmdlet.OperationName },
                        new ValidateSetAttribute(orderByValidValues.ToArray()),
                    });

                // Add to the dictionary of dynamic parameters
                this.DynamicParameters?.Add(nameof(this.OrderBy), orderByParameter);
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
                // OrderBy
                if (this.DynamicParameters.TryGetValue(nameof(this.OrderBy), out RuntimeDefinedParameter orderByParam)
                    && orderByParam.IsSet)
                {
                    this.OrderBy = orderByParam.Value as string[];
                }
            }
        }

        internal override IDictionary<string, string> GetUrlQueryOptions()
        {
            IDictionary<string, string> queryOptions = base.GetUrlQueryOptions();

            // OrderBy
            if (this.OrderBy != null && this.OrderBy.Any())
            {
                IEnumerable<string> sortable = this.OrderBy.Select(param =>
                {
                    string propertyName;
                    string postfix;
                    int i;
                    if ((i = param.LastIndexOf($" {OrderByAscPostfix}")) != -1)
                    {
                        propertyName = param.Substring(0, i);
                        postfix = OrderByAscPostfix;
                    }
                    else if ((i = param.LastIndexOf($" {OrderByDescPostfix}")) != -1)
                    {
                        propertyName = param.Substring(0, i);
                        postfix = OrderByDescPostfix;
                    }
                    else
                    {
                        // This should never happen since we set it up in the constructor
                        throw new PSArgumentOutOfRangeException(nameof(this.OrderBy), param, "Expected the OrderBy parameter to contain property names ending with ' asc' or ' desc'");
                    }
                    this.WriteObject(propertyName);
                    return $"{this.TypeCastMappings[propertyName]} {postfix}";
                });
                queryOptions.Add(ODataConstants.QueryParameters.OrderBy, string.Join(",", sortable));
            }

            // Filter
            if (!string.IsNullOrEmpty(this.Filter))
            {
                queryOptions.Add(ODataConstants.QueryParameters.Filter, this.Filter);
            }

            // Skip
            if (this.Skip != null)
            {
                queryOptions.Add(ODataConstants.QueryParameters.Skip, this.Skip.ToString());
            }

            // Top
            if (this.Top != null)
            {
                queryOptions.Add(ODataConstants.QueryParameters.Top, this.Top.ToString());
            }

            return queryOptions;
        }

        internal override HttpRequestHeaders GetHeaders()
        {
            HttpRequestHeaders headers = base.GetHeaders();
            if (this.MaxPageSize != null)
            {
                headers.Add("Prefer", $"odata.maxpagesize={this.MaxPageSize}");
            }

            return headers;
        }
    }
}
