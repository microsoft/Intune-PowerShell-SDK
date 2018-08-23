// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Contains the properties used to assign an MDM app configuration to a group.</para>
    /// </summary>
    [Cmdlet("New", "ManagedDeviceMobileAppConfigurationAssignmentObject", DefaultParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
    public class New_ManagedDeviceMobileAppConfigurationAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget", "microsoft.graph.allDevicesAssignmentTarget", "microsoft.graph.groupAssignmentTarget", "microsoft.graph.exclusionGroupAssignmentTarget", "microsoft.graph.allLicensedUsersAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfigurationAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object target { get; set; }
    }
}