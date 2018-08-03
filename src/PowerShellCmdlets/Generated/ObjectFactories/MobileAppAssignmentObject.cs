// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileAppAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileAppAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">A class containing the properties used for Group Assignment of a Mobile App.</para>
    /// </summary>
    [Cmdlet("New", "MobileAppAssignmentObject", DefaultParameterSetName = @"#microsoft.graph.mobileAppAssignment")]
    [ODataType("microsoft.graph.mobileAppAssignment")]
    public class New_MobileAppAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The install intent defined by the admin.</para>
        ///     <para type="description">
        ///          Valid values: &apos;available&apos;, &apos;required&apos;, &apos;uninstall&apos;, &apos;availableWithoutEnrollment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installIntent")]
        [Selectable]
        [ValidateSet(@"available", @"required", @"uninstall", @"availableWithoutEnrollment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;intent&quot; property, of type &quot;microsoft.graph.installIntent&quot;.")]
        public System.String Intent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The target group assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object Target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppAssignment&quot; type.</para>
        ///     <para type="description">The settings for target assignment defined by the admin.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppAssignmentSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileAppAssignment", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.mobileAppAssignmentSettings&quot;.")]
        public System.Object Settings { get; set; }
    }
}