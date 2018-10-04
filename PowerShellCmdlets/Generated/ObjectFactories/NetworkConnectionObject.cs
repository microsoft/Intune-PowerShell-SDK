// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.networkConnection&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.networkConnection&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "NetworkConnectionObject", DefaultParameterSetName = @"microsoft.graph.networkConnection")]
    [ODataType("microsoft.graph.networkConnection")]
    public class New_NetworkConnectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String applicationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;destinationAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;destinationAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;destinationDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;destinationDomain&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;destinationPort&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;destinationPort&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationPort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;destinationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;destinationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;direction&quot; property, of type &quot;microsoft.graph.connectionDirection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;inbound&apos;, &apos;outbound&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.connectionDirection")]
        [Selectable]
        [ValidateSet(@"unknown", @"inbound", @"outbound", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;direction&quot; property, of type &quot;microsoft.graph.connectionDirection&quot;.")]
        public System.String direction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;domainRegisteredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;domainRegisteredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset domainRegisteredDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;localDnsName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;localDnsName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String localDnsName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;natDestinationAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;natDestinationAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String natDestinationAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;natDestinationPort&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;natDestinationPort&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String natDestinationPort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;natSourceAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;natSourceAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String natSourceAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;natSourcePort&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;natSourcePort&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String natSourcePort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protocol&quot; property, of type &quot;microsoft.graph.securityNetworkProtocol&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;ip&apos;, &apos;icmp&apos;, &apos;igmp&apos;, &apos;ggp&apos;, &apos;ipv4&apos;, &apos;tcp&apos;, &apos;pup&apos;, &apos;udp&apos;, &apos;idp&apos;, &apos;ipv6&apos;, &apos;ipv6RoutingHeader&apos;, &apos;ipv6FragmentHeader&apos;, &apos;ipSecEncapsulatingSecurityPayload&apos;, &apos;ipSecAuthenticationHeader&apos;, &apos;icmpV6&apos;, &apos;ipv6NoNextHeader&apos;, &apos;ipv6DestinationOptions&apos;, &apos;nd&apos;, &apos;raw&apos;, &apos;ipx&apos;, &apos;spx&apos;, &apos;spxII&apos;, &apos;unknownFutureValue&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.securityNetworkProtocol")]
        [Selectable]
        [ValidateSet(@"ip", @"icmp", @"igmp", @"ggp", @"ipv4", @"tcp", @"pup", @"udp", @"idp", @"ipv6", @"ipv6RoutingHeader", @"ipv6FragmentHeader", @"ipSecEncapsulatingSecurityPayload", @"ipSecAuthenticationHeader", @"icmpV6", @"ipv6NoNextHeader", @"ipv6DestinationOptions", @"nd", @"raw", @"ipx", @"spx", @"spxII", @"unknownFutureValue", @"unknown")]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;protocol&quot; property, of type &quot;microsoft.graph.securityNetworkProtocol&quot;.")]
        public System.String protocol { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String riskScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;sourceAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sourceAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourcePort&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;sourcePort&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sourcePort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.connectionStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;attempted&apos;, &apos;succeeded&apos;, &apos;blocked&apos;, &apos;failed&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.connectionStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"attempted", @"succeeded", @"blocked", @"failed", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.connectionStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;urlParameters&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.networkConnection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.networkConnection", HelpMessage = @"The &quot;urlParameters&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String urlParameters { get; set; }
    }
}