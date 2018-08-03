// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceStatusOverview&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview</para>
    ///     <para type="description">Retrieves the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot;).</para>
    ///     <para type="description">Device Configuration devices status overview</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceConfigurations_DeviceStatusOverview", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceOverview")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceConfigurations_DeviceStatusOverview : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String DeviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConfigurationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview</para>
    ///     <para type="description">Creates the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot;).</para>
    ///     <para type="description">Device Configuration devices status overview</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceConfigurations_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceOverview")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceConfigurations_DeviceStatusOverview : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String DeviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview</para>
    ///     <para type="description">Updates the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot;).</para>
    ///     <para type="description">Device Configuration devices status overview</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceConfigurations_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceOverview")]
    public class Update_DeviceManagement_DeviceConfigurations_DeviceStatusOverview : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String DeviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview</para>
    ///     <para type="description">Removes the &quot;deviceStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot;).</para>
    ///     <para type="description">Device Configuration devices status overview</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceConfigurations_DeviceStatusOverview", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceConfigurationDeviceOverview")]
    public class Remove_DeviceManagement_DeviceConfigurations_DeviceStatusOverview : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String DeviceConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{DeviceConfigurationId}/deviceStatusOverview";
        }
    }
}