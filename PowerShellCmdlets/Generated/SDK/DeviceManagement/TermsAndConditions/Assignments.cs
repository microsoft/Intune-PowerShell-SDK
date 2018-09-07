// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.termsAndConditionsAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/termsAndConditions/{termsAndConditionId}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.termsAndConditionsAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_TermsAndConditions_Assignments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.termsAndConditionsAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    [ResourceReference]
    public class Get_DeviceManagement_TermsAndConditions_Assignments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Sortable]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/assignments/{assignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/termsAndConditions/{termsAndConditionId}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_TermsAndConditions_Assignments", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.termsAndConditionsAssignment")]
    [ODataType("microsoft.graph.termsAndConditionsAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    [ResourceReference]
    public class New_DeviceManagement_TermsAndConditions_Assignments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditionsAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/assignments/{assignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.termsAndConditionsAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/termsAndConditions/{termsAndConditionId}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_TermsAndConditions_Assignments", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.termsAndConditionsAssignment")]
    [ODataType("microsoft.graph.termsAndConditionsAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    public class Update_DeviceManagement_TermsAndConditions_Assignments : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditionsAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/assignments/{assignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/termsAndConditions/{termsAndConditionId}/assignments/assignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_TermsAndConditions_Assignments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.termsAndConditionsAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceIdPropertyName("assignmentId")]
    public class Remove_DeviceManagement_TermsAndConditions_Assignments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/assignments/{assignmentId}";
        }
    }
}