// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.roleDefinition&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/roleDefinitions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.roleDefinition&quot; objects in the &quot;roleDefinitions&quot; collection.</para>
    ///     <para type="description">The Role Definitions.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_RoleDefinitions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.roleDefinition", "microsoft.graph.deviceAndAppManagementRoleDefinition")]
    [ResourceTypePropertyName("roleDefinitionODataType")]
    [ResourceReference]
    public class Get_DeviceManagement_RoleDefinitions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
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
        [ODataType("microsoft.graph.roleAssignment", "microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] roleAssignments { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.roleDefinition&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/roleDefinitions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.roleDefinition&quot; object to the &quot;roleDefinitions&quot; collection.</para>
    ///     <para type="description">The Role Definitions.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_RoleDefinitions", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.roleDefinition", "microsoft.graph.deviceAndAppManagementRoleDefinition")]
    [ResourceTypePropertyName("roleDefinitionODataType")]
    [ResourceReference]
    public class New_DeviceManagement_RoleDefinitions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.roleDefinition")]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleDefinition&quot; type.")]
        public System.Management.Automation.SwitchParameter roleDefinition { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Display Name of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Description of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</para>
        /// </summary>
        [ODataType("microsoft.graph.rolePermission")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        public System.Object[] rolePermissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isBuiltIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role assignments for this role definition.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleAssignment", "microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        public System.Object[] roleAssignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.deviceAndAppManagementRoleDefinition")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceAndAppManagementRoleDefinition { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.roleDefinition&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/roleDefinitions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
    ///     <para type="description">The Role Definitions.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_RoleDefinitions", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.roleDefinition", "microsoft.graph.deviceAndAppManagementRoleDefinition")]
    [ResourceTypePropertyName("roleDefinitionODataType")]
    public class Update_DeviceManagement_RoleDefinitions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.roleDefinition")]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.roleDefinition&quot; type.")]
        public System.Management.Automation.SwitchParameter roleDefinition { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Display Name of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Description of the Role definition.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</para>
        /// </summary>
        [ODataType("microsoft.graph.rolePermission")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rolePermissions&quot; property, of type &quot;microsoft.graph.rolePermission&quot;.")]
        public System.Object[] rolePermissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isBuiltIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isBuiltIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleDefinition&quot; type.</para>
        ///     <para type="description">List of Role assignments for this role definition.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleAssignment", "microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.roleDefinition", HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.roleAssignment&quot;.")]
        public System.Object[] roleAssignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.deviceAndAppManagementRoleDefinition")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceAndAppManagementRoleDefinition { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.roleDefinition&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/roleDefinitions/roleDefinitionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.roleDefinition&quot; object from the &quot;roleDefinitions&quot; collection.</para>
    ///     <para type="description">The Role Definitions.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_RoleDefinitions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.roleDefinition", "microsoft.graph.deviceAndAppManagementRoleDefinition")]
    [ResourceTypePropertyName("roleDefinitionODataType")]
    public class Remove_DeviceManagement_RoleDefinitions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.roleDefinition&quot; object in the &quot;roleDefinitions&quot; collection.")]
        public System.String roleDefinitionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleDefinitions/{roleDefinitionId}";
        }
    }
}