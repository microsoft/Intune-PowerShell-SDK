// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceInstallState&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceInstallState&quot; objects in the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceIdPropertyName("DeviceStateId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String UserStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String ManagedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String DeviceStateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.installState")]
        [Selectable]
        [Sortable]
        public System.String InstallState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ErrorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OsDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates/{DeviceStateId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceInstallState&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceInstallState&quot; object to the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceInstallState")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String UserStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String ManagedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        public System.String InstallState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ErrorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceInstallState&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceInstallState")]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceIdPropertyName("DeviceStateId")]
    public class Update_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String DeviceStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String UserStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String ManagedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        public System.String InstallState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ErrorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates/{DeviceStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceInstallState&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates/DeviceStateId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceInstallState&quot; object from the &quot;deviceStates&quot; collection.</para>
    ///     <para type="description">The install state of the eBook.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceInstallState")]
    [ResourceIdPropertyName("DeviceStateId")]
    public class Remove_DeviceAppManagement_ManagedEBooks_UserStateSummary_DeviceStates : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceInstallState&quot; object in the &quot;deviceStates&quot; collection.")]
        public System.String DeviceStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String UserStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String ManagedEBookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{ManagedEBookId}/userStateSummary/{UserStateSummaryId}/deviceStates/{DeviceStateId}";
        }
    }
}