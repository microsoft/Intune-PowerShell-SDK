// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagementPartner&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagementPartner&quot; (or one of its derived types).</para>
    ///     <para type="description">Entity which represents a connection to device management partner.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementPartnerObject", DefaultParameterSetName = @"microsoft.graph.deviceManagementPartner")]
    [ODataType("microsoft.graph.deviceManagementPartner")]
    public class New_DeviceManagementPartnerObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;lastHeartbeatDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
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
        public System.String partnerAppType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner Single tenant App id</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;singleTenantAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String singleTenantAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Partner display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">Whether device management partner is configured or not</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;isConfigured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isConfigured { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be removed</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;whenPartnerDevicesWillBeRemovedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeRemovedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementPartner&quot; type.</para>
        ///     <para type="description">DateTime in UTC when PartnerDevices will be marked as NonCompliant</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementPartner", HelpMessage = @"The &quot;whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }
    }
}