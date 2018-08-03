// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceSettingState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceSettingState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Device compliance setting State for a given device.</para>
    /// </summary>
    [Cmdlet("New", "DeviceComplianceSettingStateObject", DefaultParameterSetName = @"#microsoft.graph.deviceComplianceSettingState")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    public class New_DeviceComplianceSettingStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SettingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }
    }
}