// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; (or one of its derived types).</para>
    ///     <para type="description">The type for deployment of groups or apps.</para>
    /// </summary>
    [Cmdlet("New", "TargetedManagedAppPolicyAssignmentObject", DefaultParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment")]
    [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
    public class New_TargetedManagedAppPolicyAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot; type.</para>
        ///     <para type="description">Identifier for deployment of a group or app</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppPolicyAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }
    }
}