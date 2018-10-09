// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedEBookAssignment&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedEBookAssignment&quot; (or one of its derived types).</para>
    ///     <para type="description">Contains properties used to assign a eBook to a group.</para>
    /// </summary>
    [Cmdlet("New", "ManagedEBookAssignmentObject", DefaultParameterSetName = @"microsoft.graph.managedEBookAssignment")]
    [ODataType("microsoft.graph.managedEBookAssignment")]
    public class New_ManagedEBookAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.managedEBookAssignment")]
        [Parameter(ParameterSetName = @"microsoft.graph.managedEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter managedEBookAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The assignment target for eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The install intent for eBook.</para>
        ///     <para type="description">
        ///          Valid values: &apos;available&apos;, &apos;required&apos;, &apos;uninstall&apos;, &apos;availableWithoutEnrollment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [ValidateSet(@"available", @"required", @"uninstall", @"availableWithoutEnrollment")]
        [Parameter(ParameterSetName = @"microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String installIntent { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.iosVppEBookAssignment")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppEBookAssignment { get; set; }
    }
}