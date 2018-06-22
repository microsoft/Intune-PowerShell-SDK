// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedDeviceOverview&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedDeviceOverview&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Summary data for managed devices</para>
    /// </summary>
    [Cmdlet("New", "ManagedDeviceOverviewObject", DefaultParameterSetName = @"#microsoft.graph.managedDeviceOverview")]
    [ODataType("microsoft.graph.managedDeviceOverview")]
    public class New_ManagedDeviceOverviewObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;enrolledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceOverview&quot; type.</para>
        ///     <para type="description">Total enrolled device count. Does not include PC devices managed via Intune PC Agent</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceOverview", HelpMessage = @"The &quot;enrolledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 enrolledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmEnrolledCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceOverview&quot; type.</para>
        ///     <para type="description">The number of devices enrolled in MDM</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceOverview", HelpMessage = @"The &quot;mdmEnrolledCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 mdmEnrolledCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dualEnrolledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceOverview&quot; type.</para>
        ///     <para type="description">The number of devices enrolled in both MDM and EAS</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceOverview", HelpMessage = @"The &quot;dualEnrolledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 dualEnrolledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceOperatingSystemSummary&quot; property, of type &quot;microsoft.graph.deviceOperatingSystemSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceOverview&quot; type.</para>
        ///     <para type="description">Device operating system summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceOperatingSystemSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceOverview", HelpMessage = @"The &quot;deviceOperatingSystemSummary&quot; property, of type &quot;microsoft.graph.deviceOperatingSystemSummary&quot;.")]
        public System.Object deviceOperatingSystemSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceExchangeAccessStateSummary&quot; property, of type &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceOverview&quot; type.</para>
        ///     <para type="description">Distribution of Exchange Access State in Intune</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceExchangeAccessStateSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceOverview", HelpMessage = @"The &quot;deviceExchangeAccessStateSummary&quot; property, of type &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot;.")]
        public System.Object deviceExchangeAccessStateSummary { get; set; }
    }
}