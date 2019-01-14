// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.roleDefinition&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.roleDefinition&quot; (or one of its derived types).</para>
    ///     <para type="description">The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.</para>
    /// </summary>
    [Cmdlet("New", "RoleDefinitionObject", DefaultParameterSetName = @"microsoft.graph.roleDefinition")]
    [ODataType("microsoft.graph.roleDefinition")]
    public class New_RoleDefinitionObject : ObjectFactoryCmdletBase
    {
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
        public System.Boolean isBuiltIn { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.deviceAndAppManagementRoleDefinition")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleDefinition", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceAndAppManagementRoleDefinition&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceAndAppManagementRoleDefinition { get; set; }
    }
}