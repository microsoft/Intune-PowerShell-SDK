// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceStatusSummary&quot; object.</para>
    ///     <para type="description">GET ~/deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary</para>
    ///     <para type="description">Retrieves the &quot;deviceStatusSummary&quot; object (which is of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;).</para>
    ///     <para type="description">App configuration device status summary.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    [ResourceReference]
    public class Get_DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String MobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConfigurationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary</para>
    ///     <para type="description">Creates the &quot;deviceStatusSummary&quot; object (which is of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;).</para>
    ///     <para type="description">App configuration device status summary.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    [ResourceReference]
    public class New_DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String MobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary</para>
    ///     <para type="description">Updates the &quot;deviceStatusSummary&quot; object (which is of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;).</para>
    ///     <para type="description">App configuration device status summary.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    public class Update_DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String MobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary</para>
    ///     <para type="description">Removes the &quot;deviceStatusSummary&quot; object (which is of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;).</para>
    ///     <para type="description">App configuration device status summary.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
    public class Remove_DeviceAppManagement_MobileAppConfigurations_DeviceStatusSummary : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String MobileAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{MobileAppConfigurationId}/deviceStatusSummary";
        }
    }
}