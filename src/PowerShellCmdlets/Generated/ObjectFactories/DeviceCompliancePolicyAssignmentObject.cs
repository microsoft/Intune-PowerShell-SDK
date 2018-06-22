// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Device compliance policy assignment.</para>
    /// </summary>
    [Cmdlet("New", "DeviceCompliancePolicyAssignmentObject", DefaultParameterSetName = @"#microsoft.graph.deviceCompliancePolicyAssignment")]
    [ODataType("microsoft.graph.deviceCompliancePolicyAssignment")]
    public class New_DeviceCompliancePolicyAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot; type.</para>
        ///     <para type="description">Target for the compliance policy assignment.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCompliancePolicyAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }
    }
}