// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceConfigurationDeviceOverviewObject", DefaultParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview")]
    [ODataType("microsoft.graph.deviceConfigurationDeviceOverview")]
    public class New_DeviceConfigurationDeviceOverviewObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of pending devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Number of failed devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationDeviceOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceConfigurationDeviceOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }
    }
}