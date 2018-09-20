// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsFirewallNetworkProfileObject", DefaultParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile")]
    [ODataType("microsoft.graph.windowsFirewallNetworkProfile")]
    public class New_WindowsFirewallNetworkProfileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;firewallEnabled&quot; property, of type &quot;microsoft.graph.stateManagementSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the host device to allow or block the firewall and advanced security enforcement for the network profile.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notConfigured&apos;, &apos;blocked&apos;, &apos;allowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.stateManagementSetting")]
        [Selectable]
        [ValidateSet(@"notConfigured", @"blocked", @"allowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;firewallEnabled&quot; property, of type &quot;microsoft.graph.stateManagementSetting&quot;.")]
        public System.String firewallEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;stealthModeBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Prevent the server from operating in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;stealthModeBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean stealthModeBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;incomingTrafficBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to block all incoming traffic regardless of other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;incomingTrafficBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean incomingTrafficBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unicastResponsesToMulticastBroadcastsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to block unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;unicastResponsesToMulticastBroadcastsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean unicastResponsesToMulticastBroadcastsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inboundNotificationsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Prevents the firewall from displaying notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;inboundNotificationsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean inboundNotificationsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;authorizedApplicationRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to merge authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;authorizedApplicationRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean authorizedApplicationRulesFromGroupPolicyMerged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;globalPortRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to merge global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;globalPortRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean globalPortRulesFromGroupPolicyMerged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;connectionSecurityRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to merge connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;connectionSecurityRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean connectionSecurityRulesFromGroupPolicyMerged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outboundConnectionsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to block all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;outboundConnectionsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean outboundConnectionsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inboundConnectionsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to block all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;inboundConnectionsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean inboundConnectionsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securedPacketExemptionAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to allow the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;securedPacketExemptionAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securedPacketExemptionAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;policyRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsFirewallNetworkProfile&quot; type.</para>
        ///     <para type="description">Configures the firewall to merge Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsFirewallNetworkProfile", HelpMessage = @"The &quot;policyRulesFromGroupPolicyMerged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean policyRulesFromGroupPolicyMerged { get; set; }
    }
}