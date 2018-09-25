// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileAppAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/mobileApps/{mobileAppId}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileAppAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignments for this mobile app.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_MobileApps_Assignments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileAppAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class Get_DeviceAppManagement_MobileApps_Assignments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String mobileAppAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The install intent defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [Sortable]
        public System.String intent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The target group assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Sortable]
        public System.Object target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The settings for target assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppAssignmentSettings", "microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings", "microsoft.graph.iosVppAppAssignmentSettings", "microsoft.graph.iosStoreAppAssignmentSettings", "microsoft.graph.iosLobAppAssignmentSettings")]
        [Selectable]
        [Sortable]
        public System.Object settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/assignments/{mobileAppAssignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mobileAppAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/mobileApps/{mobileAppId}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mobileAppAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignments for this mobile app.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_MobileApps_Assignments", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.mobileAppAssignment")]
    [ODataType("microsoft.graph.mobileAppAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class New_DeviceAppManagement_MobileApps_Assignments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String mobileAppAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The install intent defined by the admin.</para>
        ///     <para type="description">
        ///          Valid values: &apos;available&apos;, &apos;required&apos;, &apos;uninstall&apos;, &apos;availableWithoutEnrollment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [ValidateSet(@"available", @"required", @"uninstall", @"availableWithoutEnrollment")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String intent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The target group assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The settings for target assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppAssignmentSettings", "microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings", "microsoft.graph.iosVppAppAssignmentSettings", "microsoft.graph.iosStoreAppAssignmentSettings", "microsoft.graph.iosLobAppAssignmentSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.")]
        public System.Object settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/assignments/{mobileAppAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mobileAppAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/mobileApps/{mobileAppId}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignments for this mobile app.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_MobileApps_Assignments", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.mobileAppAssignment")]
    [ODataType("microsoft.graph.mobileAppAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Update_DeviceAppManagement_MobileApps_Assignments : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String mobileAppAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The install intent defined by the admin.</para>
        ///     <para type="description">
        ///          Valid values: &apos;available&apos;, &apos;required&apos;, &apos;uninstall&apos;, &apos;availableWithoutEnrollment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [ValidateSet(@"available", @"required", @"uninstall", @"availableWithoutEnrollment")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String intent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The target group assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The settings for target assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppAssignmentSettings", "microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings", "microsoft.graph.iosVppAppAssignmentSettings", "microsoft.graph.iosStoreAppAssignmentSettings", "microsoft.graph.iosLobAppAssignmentSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.")]
        public System.Object settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/assignments/{mobileAppAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mobileAppAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/mobileApps/{mobileAppId}/assignments/mobileAppAssignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mobileAppAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignments for this mobile app.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_MobileApps_Assignments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Remove_DeviceAppManagement_MobileApps_Assignments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String mobileAppAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/assignments/{mobileAppAssignmentId}";
        }
    }
}