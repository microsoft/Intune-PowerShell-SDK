// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceManagementPartner&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceManagementPartner&quot; objects in the &quot;deviceManagementPartners&quot; collection.</para>
    ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/deviceManagementPartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneDeviceManagementPartner", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceManagementPartner")]
    [ResourceTypePropertyName("deviceManagementPartnerODataType")]
    [ResourceReference]
    public class Get_IntuneDeviceManagementPartner : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.")]
        public System.String deviceManagementPartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner state of this tenant</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerTenantState")]
        [Selectable]
        [Sortable]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner App type</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerAppType")]
        [Selectable]
        [Sortable]
        public System.String partnerAppType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner Single tenant App id</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String singleTenantAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Whether device management partner is configured or not</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isConfigured { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be removed</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset whenPartnerDevicesWillBeRemovedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be marked as NonCompliant</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceManagementPartners/{deviceManagementPartnerId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceManagementPartner&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceManagementPartner&quot; object to the &quot;deviceManagementPartners&quot; collection.</para>
    ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/deviceManagementPartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneDeviceManagementPartner", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceManagementPartner")]
    [ODataType("microsoft.graph.deviceManagementPartner")]
    [ResourceTypePropertyName("deviceManagementPartnerODataType")]
    [ResourceReference]
    public class New_IntuneDeviceManagementPartner : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceManagementPartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner state of this tenant</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;unavailable&apos;, &apos;enabled&apos;, &apos;terminated&apos;, &apos;rejected&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerTenantState")]
        [Selectable]
        [ValidateSet(@"unknown", @"unavailable", @"enabled", @"terminated", @"rejected", @"unresponsive")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.")]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner App type</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;singleTenantApp&apos;, &apos;multiTenantApp&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerAppType")]
        [Selectable]
        [ValidateSet(@"unknown", @"singleTenantApp", @"multiTenantApp")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.")]
        public System.String partnerAppType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner Single tenant App id</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String singleTenantAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Whether device management partner is configured or not</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isConfigured { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be removed</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeRemovedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be marked as NonCompliant</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceManagementPartners/{deviceManagementPartnerId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceManagementPartner&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.</para>
    ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/deviceManagementPartners</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneDeviceManagementPartner", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceManagementPartner")]
    [ODataType("microsoft.graph.deviceManagementPartner")]
    [ResourceTypePropertyName("deviceManagementPartnerODataType")]
    public class Update_IntuneDeviceManagementPartner : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.")]
        public System.String deviceManagementPartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastHeartbeatDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner state of this tenant</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;unavailable&apos;, &apos;enabled&apos;, &apos;terminated&apos;, &apos;rejected&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerTenantState")]
        [Selectable]
        [ValidateSet(@"unknown", @"unavailable", @"enabled", @"terminated", @"rejected", @"unresponsive")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;partnerState&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerTenantState&quot;.")]
        public System.String partnerState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner App type</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;singleTenantApp&apos;, &apos;multiTenantApp&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartnerAppType")]
        [Selectable]
        [ValidateSet(@"unknown", @"singleTenantApp", @"multiTenantApp")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;partnerAppType&quot; property, of type &quot;microsoft.graph.deviceManagementPartnerAppType&quot;.")]
        public System.String partnerAppType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner Single tenant App id</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String singleTenantAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Whether device management partner is configured or not</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isConfigured { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be removed</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeRemovedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be marked as NonCompliant</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceManagementPartners/{deviceManagementPartnerId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceManagementPartner&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceManagementPartner&quot; object from the &quot;deviceManagementPartners&quot; collection.</para>
    ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/deviceManagementPartners/deviceManagementPartnerId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneDeviceManagementPartner", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceManagementPartner")]
    [ResourceTypePropertyName("deviceManagementPartnerODataType")]
    public class Remove_IntuneDeviceManagementPartner : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementPartner&quot; object in the &quot;deviceManagementPartners&quot; collection.")]
        public System.String deviceManagementPartnerId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceManagementPartners/{deviceManagementPartnerId}";
        }
    }
}