// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.settingStateDeviceSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.settingStateDeviceSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Device Compilance Policy and Configuration for a Setting State summary</para>
    /// </summary>
    [Cmdlet("New", "SettingStateDeviceSummaryObject", DefaultParameterSetName = @"#microsoft.graph.settingStateDeviceSummary")]
    [ODataType("microsoft.graph.settingStateDeviceSummary")]
    public class New_SettingStateDeviceSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Name of the setting</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SettingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;instancePath&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Name of the InstancePath for the setting</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;instancePath&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String InstancePath { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device Unkown count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device Not Applicable count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device Compliant count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device Compliant count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device NonCompliant count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device error count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.settingStateDeviceSummary&quot; type.</para>
        ///     <para type="description">Device conflict error count for the setting</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.settingStateDeviceSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConflictDeviceCount { get; set; }
    }
}