// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceAndAppManagementAssignmentTargetObject", DefaultParameterSetName = @"microsoft.graph.deviceAndAppManagementAssignmentTarget")]
    [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
    public class New_DeviceAndAppManagementAssignmentTargetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.allDevicesAssignmentTarget&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.allDevicesAssignmentTarget")]
        [Parameter(ParameterSetName = @"microsoft.graph.allDevicesAssignmentTarget", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.allDevicesAssignmentTarget&quot; type.")]
        public System.Management.Automation.SwitchParameter allDevicesAssignmentTarget { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupAssignmentTarget&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.groupAssignmentTarget")]
        [Parameter(ParameterSetName = @"microsoft.graph.groupAssignmentTarget", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupAssignmentTarget&quot; type.")]
        public System.Management.Automation.SwitchParameter groupAssignmentTarget { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupAssignmentTarget&quot; type.</para>
        ///     <para type="description">The group Id that is the target of the assignment.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupAssignmentTarget", HelpMessage = @"The &quot;groupId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.exclusionGroupAssignmentTarget", HelpMessage = @"The &quot;groupId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.exclusionGroupAssignmentTarget&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.exclusionGroupAssignmentTarget")]
        [Parameter(ParameterSetName = @"microsoft.graph.exclusionGroupAssignmentTarget", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.exclusionGroupAssignmentTarget&quot; type.")]
        public System.Management.Automation.SwitchParameter exclusionGroupAssignmentTarget { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.allLicensedUsersAssignmentTarget&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Parameter(ParameterSetName = @"microsoft.graph.allLicensedUsersAssignmentTarget", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.allLicensedUsersAssignmentTarget&quot; type.")]
        public System.Management.Automation.SwitchParameter allLicensedUsersAssignmentTarget { get; set; }
    }
}