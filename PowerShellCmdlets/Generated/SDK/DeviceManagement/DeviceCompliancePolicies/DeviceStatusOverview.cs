// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceStatusOverview&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview</para>
    ///     <para type="description">Retrieves the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;).</para>
    ///     <para type="description">Device compliance devices status overview</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
    [ResourceTypePropertyName("deviceStatusOverviewODataType")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 pendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 notApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 successCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 errorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 failedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 configurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview</para>
    ///     <para type="description">Creates the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;).</para>
    ///     <para type="description">Device compliance devices status overview</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview")]
    [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
    [ResourceTypePropertyName("deviceStatusOverviewODataType")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 successCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 configurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview</para>
    ///     <para type="description">Updates the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;).</para>
    ///     <para type="description">Device compliance devices status overview</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview")]
    [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
    [ResourceTypePropertyName("deviceStatusOverviewODataType")]
    public class Update_DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 successCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceDeviceOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 configurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceDeviceOverview&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview</para>
    ///     <para type="description">Removes the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;).</para>
    ///     <para type="description">Device compliance devices status overview</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
    [ResourceTypePropertyName("deviceStatusOverviewODataType")]
    public class Remove_DeviceManagement_DeviceCompliancePolicies_DeviceStatusOverview : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/deviceStatusOverview";
        }
    }
}