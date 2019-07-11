// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceInstallState&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceInstallState&quot; objects in the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    ///     <para type="description">Graph call: GET ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceTypePropertyName("deviceStateODataType")]
    [ResourceReference]
    [Alias("Get-IntuneManagedEBookUserStateSummaryDeviceState")]
    public class Get_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userInstallStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String deviceInstallStateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.installState")]
        [Selectable]
        [Sortable]
        public System.String installState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String osDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates/{deviceInstallStateId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceInstallState&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceInstallState&quot; object to the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    ///     <para type="description">Graph call: POST ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceInstallState")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceTypePropertyName("deviceStateODataType")]
    [ResourceReference]
    [Alias("New-IntuneManagedEBookUserStateSummaryDeviceState")]
    public class New_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceInstallStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userInstallStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notApplicable&apos;, &apos;installed&apos;, &apos;failed&apos;, &apos;notInstalled&apos;, &apos;uninstallFailed&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installState")]
        [Selectable]
        [ValidateSet(@"notApplicable", @"installed", @"failed", @"notInstalled", @"uninstallFailed", @"unknown")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        public System.String installState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates/{deviceInstallStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceInstallState&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceInstallState")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceTypePropertyName("deviceStateODataType")]
    [Alias("Update-IntuneManagedEBookUserStateSummaryDeviceState")]
    public class Update_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String deviceInstallStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userInstallStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notApplicable&apos;, &apos;installed&apos;, &apos;failed&apos;, &apos;notInstalled&apos;, &apos;uninstallFailed&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installState")]
        [Selectable]
        [ValidateSet(@"notApplicable", @"installed", @"failed", @"notInstalled", @"uninstallFailed", @"unknown")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        public System.String installState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates/{deviceInstallStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceInstallState&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceInstallState&quot; object from the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates/deviceInstallStateId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceTypePropertyName("deviceStateODataType")]
    [Alias("Remove-IntuneManagedEBookUserStateSummaryDeviceState")]
    public class Remove_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String deviceInstallStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userInstallStateSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userInstallStateSummaryId}/deviceStates/{deviceInstallStateId}";
        }
    }
}