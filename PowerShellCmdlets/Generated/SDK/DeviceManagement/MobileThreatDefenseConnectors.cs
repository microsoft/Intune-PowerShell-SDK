// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileThreatDefenseConnector&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileThreatDefenseConnector&quot; objects in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
    ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/mobileThreatDefenseConnectors</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_MobileThreatDefenseConnectors", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
    [ResourceTypePropertyName("mobileThreatDefenseConnectorODataType")]
    [ResourceReference]
    [Alias("Get-IntuneMobileThreatDefenseConnector")]
    public class Get_DeviceManagement_MobileThreatDefenseConnectors : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.")]
        public System.String mobileThreatDefenseConnectorId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">DateTime of last Heartbeat recieved from the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Data Sync Partner state for this account</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatPartnerTenantState")]
        [Selectable]
        [Sortable]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean androidEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean iosEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean androidDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean iosDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean partnerUnsupportedOsVersionBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 partnerUnresponsivenessThresholdInDays { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnectorId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object to the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
    ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/mobileThreatDefenseConnectors</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_MobileThreatDefenseConnectors", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector")]
    [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
    [ResourceTypePropertyName("mobileThreatDefenseConnectorODataType")]
    [ResourceReference]
    [Alias("New-IntuneMobileThreatDefenseConnector")]
    public class New_DeviceManagement_MobileThreatDefenseConnectors : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String mobileThreatDefenseConnectorId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">DateTime of last Heartbeat recieved from the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Data Sync Partner state for this account</para>
        ///     <para type="description">
        ///          Valid values: &apos;unavailable&apos;, &apos;available&apos;, &apos;enabled&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatPartnerTenantState")]
        [Selectable]
        [ValidateSet(@"unavailable", @"available", @"enabled", @"unresponsive")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.")]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean androidEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iosEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean androidDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iosDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean partnerUnsupportedOsVersionBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 partnerUnresponsivenessThresholdInDays { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnectorId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mobileThreatDefenseConnector&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
    ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/mobileThreatDefenseConnectors</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_MobileThreatDefenseConnectors", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector")]
    [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
    [ResourceTypePropertyName("mobileThreatDefenseConnectorODataType")]
    [Alias("Update-IntuneMobileThreatDefenseConnector")]
    public class Update_DeviceManagement_MobileThreatDefenseConnectors : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.")]
        public System.String mobileThreatDefenseConnectorId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">DateTime of last Heartbeat recieved from the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Data Sync Partner state for this account</para>
        ///     <para type="description">
        ///          Valid values: &apos;unavailable&apos;, &apos;available&apos;, &apos;enabled&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatPartnerTenantState")]
        [Selectable]
        [ValidateSet(@"unavailable", @"available", @"enabled", @"unresponsive")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.mobileThreatPartnerTenantState&quot;.")]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean androidEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iosEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean androidDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosDeviceBlockedOnMissingPartnerData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iosDeviceBlockedOnMissingPartnerData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;partnerUnsupportedOsVersionBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean partnerUnsupportedOsVersionBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileThreatDefenseConnector&quot; type.</para>
        ///     <para type="description">Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileThreatDefenseConnector", HelpMessage = @"The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;partnerUnresponsivenessThresholdInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 partnerUnresponsivenessThresholdInDays { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnectorId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object from the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
    ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/mobileThreatDefenseConnectors/mobileThreatDefenseConnectorId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_MobileThreatDefenseConnectors", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
    [ResourceTypePropertyName("mobileThreatDefenseConnectorODataType")]
    [Alias("Remove-IntuneMobileThreatDefenseConnector")]
    public class Remove_DeviceManagement_MobileThreatDefenseConnectors : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileThreatDefenseConnector&quot; object in the &quot;mobileThreatDefenseConnectors&quot; collection.")]
        public System.String mobileThreatDefenseConnectorId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/mobileThreatDefenseConnectors/{mobileThreatDefenseConnectorId}";
        }
    }
}