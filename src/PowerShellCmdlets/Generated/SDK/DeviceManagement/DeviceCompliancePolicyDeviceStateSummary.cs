// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceCompliancePolicyDeviceStateSummary&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicyDeviceStateSummary</para>
    ///     <para type="description">Retrieves the &quot;deviceCompliancePolicyDeviceStateSummary&quot; object (which is of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;).</para>
    ///     <para type="description">The device compliance state summary for this account.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicyDeviceStateSummary", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicyDeviceStateSummary : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that are in grace period</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 InGracePeriodCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that have compliance managed by System Center Configuration Manager</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConfigManagerCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicyDeviceStateSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicyDeviceStateSummary</para>
    ///     <para type="description">Creates the &quot;deviceCompliancePolicyDeviceStateSummary&quot; object (which is of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;).</para>
    ///     <para type="description">The device compliance state summary for this account.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicyDeviceStateSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicyDeviceStateSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that are in grace period</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 InGracePeriodCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that have compliance managed by System Center Configuration Manager</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigManagerCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConflictDeviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicyDeviceStateSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicyDeviceStateSummary</para>
    ///     <para type="description">Updates the &quot;deviceCompliancePolicyDeviceStateSummary&quot; object (which is of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;).</para>
    ///     <para type="description">The device compliance state summary for this account.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicyDeviceStateSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    public class Update_DeviceManagement_DeviceCompliancePolicyDeviceStateSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that are in grace period</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inGracePeriodCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 InGracePeriodCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of devices that have compliance managed by System Center Configuration Manager</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configManagerCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigManagerCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyDeviceStateSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConflictDeviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicyDeviceStateSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicyDeviceStateSummary</para>
    ///     <para type="description">Removes the &quot;deviceCompliancePolicyDeviceStateSummary&quot; object (which is of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;).</para>
    ///     <para type="description">The device compliance state summary for this account.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicyDeviceStateSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
    public class Remove_DeviceManagement_DeviceCompliancePolicyDeviceStateSummary : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicyDeviceStateSummary";
        }
    }
}