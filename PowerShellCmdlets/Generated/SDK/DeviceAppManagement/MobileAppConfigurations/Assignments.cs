// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignemenets for app configration.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneMobileAppConfigurationPolicyAssignment", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class Get_IntuneMobileAppConfigurationPolicyAssignment : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Sortable]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments/{managedDeviceMobileAppConfigurationAssignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignemenets for app configration.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneMobileAppConfigurationPolicyAssignment", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    [ResourceReference]
    public class New_IntuneMobileAppConfigurationPolicyAssignment : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String managedDeviceMobileAppConfigurationAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments/{managedDeviceMobileAppConfigurationAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignemenets for app configration.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneMobileAppConfigurationPolicyAssignment", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Update_IntuneMobileAppConfigurationPolicyAssignment : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments/{managedDeviceMobileAppConfigurationAssignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments/managedDeviceMobileAppConfigurationAssignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of group assignemenets for app configration.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneMobileAppConfigurationPolicyAssignment", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ResourceTypePropertyName("assignmentODataType")]
    public class Remove_IntuneMobileAppConfigurationPolicyAssignment : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationAssignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}/assignments/{managedDeviceMobileAppConfigurationAssignmentId}";
        }
    }
}