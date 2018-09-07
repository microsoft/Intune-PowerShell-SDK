// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.userInstallStateSummary&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.userInstallStateSummary&quot; objects in the &quot;userStateSummary&quot; collection.</para>
    ///     <para type="description">The list of installation states for this eBook.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedEBooks_UserStateSummary", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.userInstallStateSummary")]
    [ResourceTypePropertyName("userStateSummaryODataType")]
    [ResourceIdPropertyName("userStateSummaryId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedEBooks_UserStateSummary : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">User name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Installed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Failed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Not installed device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceInstallState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userStateSummaryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.userInstallStateSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.userInstallStateSummary&quot; object to the &quot;userStateSummary&quot; collection.</para>
    ///     <para type="description">The list of installation states for this eBook.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedEBooks_UserStateSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.userInstallStateSummary")]
    [ODataType("microsoft.graph.userInstallStateSummary")]
    [ResourceTypePropertyName("userStateSummaryODataType")]
    [ResourceIdPropertyName("userStateSummaryId")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedEBooks_UserStateSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String userStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">User name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Installed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Failed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Not installed device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceInstallState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        public System.Object[] deviceStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userStateSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.userInstallStateSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
    ///     <para type="description">The list of installation states for this eBook.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedEBooks_UserStateSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.userInstallStateSummary")]
    [ODataType("microsoft.graph.userInstallStateSummary")]
    [ResourceTypePropertyName("userStateSummaryODataType")]
    [ResourceIdPropertyName("userStateSummaryId")]
    public class Update_DeviceAppManagement_ManagedEBooks_UserStateSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">User name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Installed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Failed Device Count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">Not installed device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userInstallStateSummary&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceInstallState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.userInstallStateSummary", HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        public System.Object[] deviceStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userStateSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.userInstallStateSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/userStateSummaryId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.userInstallStateSummary&quot; object from the &quot;userStateSummary&quot; collection.</para>
    ///     <para type="description">The list of installation states for this eBook.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedEBooks_UserStateSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.userInstallStateSummary")]
    [ResourceTypePropertyName("userStateSummaryODataType")]
    [ResourceIdPropertyName("userStateSummaryId")]
    public class Remove_DeviceAppManagement_ManagedEBooks_UserStateSummary : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userInstallStateSummary&quot; object in the &quot;userStateSummary&quot; collection.")]
        public System.String userStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/userStateSummary/{userStateSummaryId}";
        }
    }
}