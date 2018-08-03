// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceEnrollmentPlatformRestrictionObject", DefaultParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestriction")]
    [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
    public class New_DeviceEnrollmentPlatformRestrictionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;platformBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; type.</para>
        ///     <para type="description">Block the platform from enrolling</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestriction", HelpMessage = @"The &quot;platformBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PlatformBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personalDeviceEnrollmentBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; type.</para>
        ///     <para type="description">Block personally owned devices from enrolling</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestriction", HelpMessage = @"The &quot;personalDeviceEnrollmentBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PersonalDeviceEnrollmentBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; type.</para>
        ///     <para type="description">Min OS version supported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestriction", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot; type.</para>
        ///     <para type="description">Max OS version supported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestriction", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OsMaximumVersion { get; set; }
    }
}