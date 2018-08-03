// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Contains properties, inherited properties and actions for an MDM mobile app configuration status for a user.</para>
    /// </summary>
    [Cmdlet("New", "ManagedDeviceMobileAppConfigurationUserStatusObject", DefaultParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
    public class New_ManagedDeviceMobileAppConfigurationUserStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">User name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Devices count for that user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus", HelpMessage = @"The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DevicesCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String Status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }
    }
}