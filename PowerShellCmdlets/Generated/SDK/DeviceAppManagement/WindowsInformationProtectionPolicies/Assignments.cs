// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneWindowsInformationProtectionPolicyAssignment", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class Get_IntuneWindowsInformationProtectionPolicyAssignment : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String targetedManagedAppPolicyAssignmentId { get; set; }

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
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments/{targetedManagedAppPolicyAssignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneWindowsInformationProtectionPolicyAssignment", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class New_IntuneWindowsInformationProtectionPolicyAssignment : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String targetedManagedAppPolicyAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; type.</para>
        ///     <para type="description">Identifier for deployment of a group or app</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments/{targetedManagedAppPolicyAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneWindowsInformationProtectionPolicyAssignment", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Update_IntuneWindowsInformationProtectionPolicyAssignment : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String targetedManagedAppPolicyAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

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
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments/{targetedManagedAppPolicyAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments/targetedManagedAppPolicyAssignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneWindowsInformationProtectionPolicyAssignment", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Remove_IntuneWindowsInformationProtectionPolicyAssignment : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String targetedManagedAppPolicyAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/assignments/{targetedManagedAppPolicyAssignmentId}";
        }
    }
}