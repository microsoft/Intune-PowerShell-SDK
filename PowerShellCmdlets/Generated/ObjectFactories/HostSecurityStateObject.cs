// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.hostSecurityState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.hostSecurityState&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "HostSecurityStateObject", DefaultParameterSetName = @"microsoft.graph.hostSecurityState")]
    [ODataType("microsoft.graph.hostSecurityState")]
    public class New_HostSecurityStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fqdn&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;fqdn&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fqdn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAzureAdJoined&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;isAzureAdJoined&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAzureAdJoined { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAzureAdRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;isAzureAdRegistered&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAzureAdRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isHybridAzureDomainJoined&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;isHybridAzureDomainJoined&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isHybridAzureDomainJoined { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;netBiosName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;netBiosName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String netBiosName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;os&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;os&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String os { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privateIpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;privateIpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String privateIpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publicIpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;publicIpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publicIpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hostSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.hostSecurityState", HelpMessage = @"The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String riskScore { get; set; }
    }
}