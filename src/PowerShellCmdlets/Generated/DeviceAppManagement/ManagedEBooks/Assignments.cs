// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedEBookAssignment&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedEBooks/{managedEBookId}/assignments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedEBookAssignment&quot; objects in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this eBook.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedEBooks_Assignments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedEBookAssignment")]
    [ResourceIdPropertyName("assignmentId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedEBooks_Assignments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The assignment target for eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Sortable]
        public System.Object target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The install intent for eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [Sortable]
        public System.String installIntent { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/assignments/{assignmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedEBookAssignment&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedEBooks/{managedEBookId}/assignments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedEBookAssignment&quot; object to the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this eBook.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedEBooks_Assignments", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.iosVppEBookAssignment")]
    [ODataType("microsoft.graph.managedEBookAssignment")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedEBooks_Assignments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedEBookAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter managedEBookAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The assignment target for eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
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
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String installIntent { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosVppEBookAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppEBookAssignment { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/assignments";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedEBookAssignment&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedEBooks/{managedEBookId}/assignments</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this eBook.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedEBooks_Assignments", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.iosVppEBookAssignment")]
    [ODataType("microsoft.graph.managedEBookAssignment")]
    [ResourceIdPropertyName("assignmentId")]
    public class Update_DeviceAppManagement_ManagedEBooks_Assignments : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedEBookAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter managedEBookAssignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBookAssignment&quot; type.</para>
        ///     <para type="description">The assignment target for eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
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
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installIntent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String installIntent { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosVppEBookAssignment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBookAssignment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBookAssignment&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppEBookAssignment { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/assignments/{assignmentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedEBookAssignment&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedEBooks/{managedEBookId}/assignments/assignmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedEBookAssignment&quot; object from the &quot;assignments&quot; collection.</para>
    ///     <para type="description">The list of assignments for this eBook.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedEBooks_Assignments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedEBookAssignment")]
    [ResourceIdPropertyName("assignmentId")]
    public class Remove_DeviceAppManagement_ManagedEBooks_Assignments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedEBookAssignment&quot; object in the &quot;assignments&quot; collection.")]
        public System.String assignmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/assignments/{assignmentId}";
        }
    }
}