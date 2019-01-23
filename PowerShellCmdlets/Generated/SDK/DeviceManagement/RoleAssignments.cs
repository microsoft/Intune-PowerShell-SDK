// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; objects in the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">The Role Assignments.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/roleAssignments</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneRoleAssignment", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ResourceTypePropertyName("roleAssignmentODataType")]
    [ResourceReference]
    public class Get_IntuneRoleAssignment : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String deviceAndAppManagementRoleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] resourceScopes { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleAssignments/{deviceAndAppManagementRoleAssignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object to the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">The Role Assignments.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/roleAssignments</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneRoleAssignment", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ResourceTypePropertyName("roleAssignmentODataType")]
    [ResourceReference]
    public class New_IntuneRoleAssignment : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceAndAppManagementRoleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resourceScopes { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleAssignments/{deviceAndAppManagementRoleAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">The Role Assignments.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/roleAssignments</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneRoleAssignment", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ResourceTypePropertyName("roleAssignmentODataType")]
    public class Update_IntuneRoleAssignment : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String deviceAndAppManagementRoleAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The list of ids of role member security groups. These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;members&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">The display or friendly name of the role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">Description of the Role Assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; type.</para>
        ///     <para type="description">List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceAndAppManagementRoleAssignment", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceScopes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resourceScopes { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleAssignments/{deviceAndAppManagementRoleAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object from the &quot;roleAssignments&quot; collection.</para>
    ///     <para type="description">The Role Assignments.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/roleAssignments/deviceAndAppManagementRoleAssignmentId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneRoleAssignment", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
    [ResourceTypePropertyName("roleAssignmentODataType")]
    public class Remove_IntuneRoleAssignment : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot; object in the &quot;roleAssignments&quot; collection.")]
        public System.String deviceAndAppManagementRoleAssignmentId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/roleAssignments/{deviceAndAppManagementRoleAssignmentId}";
        }
    }
}