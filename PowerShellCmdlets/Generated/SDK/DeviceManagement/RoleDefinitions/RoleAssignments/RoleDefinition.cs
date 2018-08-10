// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;roleDefinition&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition</para>
    ///     <para type="description">Retrieves the &quot;roleDefinition&quot; object (which is of type &quot;microsoft.graph.roleDefinition&quot;).</para>
    ///     <para type="description">Role definition this assignment is part of.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinition", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.roleDefinition")]
    public class Get_DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinition : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Display Name of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Description of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</para>
        /// </summary>
        [ODataType("microsoft.graph.rolePermission")]
        [Selectable]
        public System.Object[] rolePermissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isBuiltIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role assignments for this role definition.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] roleAssignments { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;roleDefinition&quot; object reference.</para>
    ///     <para type="description">GET ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref</para>
    ///     <para type="description">Retrieves the &quot;roleDefinition&quot; object reference (which is of type &quot;microsoft.graph.roleDefinition&quot;).</para>
    ///     <para type="description">Role definition this assignment is part of.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.roleDefinition")]
    public class Get_DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Display Name of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Description of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</para>
        /// </summary>
        [ODataType("microsoft.graph.rolePermission")]
        [Selectable]
        public System.Object[] rolePermissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isBuiltIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role assignments for this role definition.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] roleAssignments { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;roleAssignment&quot; to a &quot;microsoft.graph.roleDefinition&quot; object.</para>
    ///     <para type="description">PUT ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref</para>
    ///     <para type="description">Creates a reference from the &quot;roleAssignment&quot; object to a &quot;roleDefinition&quot;.</para>
    ///     <para type="description">Role definition this assignment is part of.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.roleDefinition")]
    [ResourceIdPropertyName("roleDefinitionReferenceUrl")]
    public class New_DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference : PutReferenceToEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.roleDefinition&quot; object.</para>
        /// </summary>
        [Selectable]
        [Alias("deviceAndAppManagementRoleDefinitionReferenceUrl")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.roleDefinition&quot; object.")]
        public System.String roleDefinitionReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;roleAssignment&quot; to a &quot;microsoft.graph.roleDefinition&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref</para>
    ///     <para type="description">Removes a reference from the &quot;roleAssignment&quot; object to a &quot;roleDefinition&quot;.</para>
    ///     <para type="description">Role definition this assignment is part of.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.roleDefinition")]
    public class Remove_DeviceManagement_RoleDefinitions_RoleAssignments_RoleDefinitionReference : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}/roleDefinition/$ref";
        }
    }
}