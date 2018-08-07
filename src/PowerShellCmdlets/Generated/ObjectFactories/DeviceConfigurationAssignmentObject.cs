// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">The device configuration assignment entity assigns an AAD group to a specific device configuration.</para>
    /// </summary>
    [Cmdlet("New", "DeviceConfigurationAssignmentObject", DefaultParameterSetName = @"#microsoft.graph.deviceConfigurationAssignment")]
    [ODataType("microsoft.graph.deviceConfigurationAssignment")]
    public class New_DeviceConfigurationAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationAssignment&quot; type.</para>
        ///     <para type="description">The assignment target for the device configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }
    }
}