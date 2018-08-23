// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_IosManagedAppProtections_Assignments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_IosManagedAppProtections_Assignments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.")]
        public System.String iosManagedAppProtectionODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; type.</para>
        ///     <para type="description">Identifier for deployment of a group or app</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Sortable]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments/{assignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_IosManagedAppProtections_Assignments", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    [ResourceReference]
    public class New_DeviceAppManagement_IosManagedAppProtections_Assignments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.")]
        public System.String iosManagedAppProtectionODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; type.</para>
        ///     <para type="description">Identifier for deployment of a group or app</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments/{assignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_IosManagedAppProtections_Assignments", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    public class Update_DeviceAppManagement_IosManagedAppProtections_Assignments : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.")]
        public System.String iosManagedAppProtectionODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; type.</para>
        ///     <para type="description">Identifier for deployment of a group or app</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments/{assignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments/assignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_IosManagedAppProtections_Assignments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    public class Remove_DeviceAppManagement_IosManagedAppProtections_Assignments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.iosManagedAppProtection&quot; objects.")]
        public System.String iosManagedAppProtectionODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/{iosManagedAppProtectionODataType}/assignments/{assignmentId}";
        }
    }
}