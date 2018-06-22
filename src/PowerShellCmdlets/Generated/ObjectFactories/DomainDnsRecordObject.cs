// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.domainDnsRecord&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.domainDnsRecord&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DomainDnsRecordObject", DefaultParameterSetName = @"#microsoft.graph.domainDnsCnameRecord")]
    [ODataType("microsoft.graph.domainDnsRecord")]
    public class New_DomainDnsRecordObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;isOptional&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isOptional { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;label&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;label&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String label { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;recordType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String recordType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;supportedService&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String supportedService { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;ttl&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ttl { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsUnavailableRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsUnavailableRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsUnavailableRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsUnavailableRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsUnavailableRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsUnavailableRecord", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsTxtRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsTxtRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsTxtRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsTxtRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsTxtRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsTxtRecord", HelpMessage = @"The &quot;text&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String text { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsSrvRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsSrvRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nameTarget&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;nameTarget&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String nameTarget { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;port&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;port&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 port { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 priority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protocol&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;protocol&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String protocol { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;service&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;service&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String service { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;weight&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsSrvRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsSrvRecord", HelpMessage = @"The &quot;weight&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 weight { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsMxRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsMxRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsMxRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsMxRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailExchange&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsMxRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;mailExchange&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mailExchange { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preference&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsMxRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsMxRecord", HelpMessage = @"The &quot;preference&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 preference { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsCnameRecord&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.domainDnsCnameRecord")]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.domainDnsCnameRecord&quot; type.")]
        public System.Management.Automation.SwitchParameter domainDnsCnameRecord { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canonicalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainDnsCnameRecord&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domainDnsCnameRecord", HelpMessage = @"The &quot;canonicalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String canonicalName { get; set; }
    }
}