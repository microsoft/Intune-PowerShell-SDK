// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.roleAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.roleAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">The Role Assignment resource. Role assignments tie together a role definition with members and scopes. There can be one or more role assignments per role. This applies to custom and built-in roles.</para>
    /// </summary>
    [Cmdlet("New", "RoleAssignmentObject", DefaultParameterSetName = @"#microsoft.graph.roleAssignment")]
    [ODataType("microsoft.graph.roleAssignment")]
    public class New_RoleAssignmentObject : ObjectFactoryCmdletBase
    {
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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resourceScopes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.roleAssignment&quot; type.</para>
        ///     <para type="description">Role definition this assignment is part of.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.roleAssignment", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;roleDefinition&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
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
        public System.String[] members { get; set; }
    }
}