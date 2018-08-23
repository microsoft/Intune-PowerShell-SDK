// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceCompliancePolicyDeviceStateSummaryObject", DefaultParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    public class New_DeviceCompliancePolicyDeviceStateSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that are in grace period</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 inGracePeriodCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that have compliance managed by System Center Configuration Manager</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 configManagerCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 compliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 remediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 nonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 conflictDeviceCount { get; set; }
    }
}