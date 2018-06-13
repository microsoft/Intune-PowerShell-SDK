// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.roleAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.roleAssignment&quot; objects in the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">List of Role assignments for this role definition.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_RoleDefinitions_RoleAssignments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.roleAssignment")]
    [ResourceIdPropertyName("roleAssignmentId")]
    [ResourceReference]
    public class Get_DeviceManagement_RoleDefinitions_RoleAssignments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] resourceScopes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Role definition this assignment is part of.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object roleDefinition { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
        public System.String[] members { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.roleAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.roleAssignment&quot; object to the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">List of Role assignments for this role definition.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_RoleDefinitions_RoleAssignments", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ODataType("microsoft.graph.roleAssignment")]
    [ResourceReference]
    public class New_DeviceManagement_RoleDefinitions_RoleAssignments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.roleAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter roleAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resourceScopes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Role definition this assignment is part of.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        public System.Object roleDefinition { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceAndAppManagementRoleAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] members { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.roleAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">List of Role assignments for this role definition.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_RoleDefinitions_RoleAssignments", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ODataType("microsoft.graph.roleAssignment")]
    [ResourceIdPropertyName("roleAssignmentId")]
    public class Update_DeviceManagement_RoleDefinitions_RoleAssignments : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String roleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.roleAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter roleAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resourceScopes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Role definition this assignment is part of.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        public System.Object roleDefinition { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceAndAppManagementRoleAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] members { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.roleAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/roleAssignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.roleAssignment&quot; object from the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">List of Role assignments for this role definition.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_RoleDefinitions_RoleAssignments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.roleAssignment")]
    [ResourceIdPropertyName("roleAssignmentId")]
    public class Remove_DeviceManagement_RoleDefinitions_RoleAssignments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
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
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}/roleAssignments/{roleAssignmentId}";
        }
    }
}