// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceExchangeAccessStateSummaryObject", DefaultParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary")]
    [ODataType("microsoft.graph.deviceExchangeAccessStateSummary")]
    public class New_DeviceExchangeAccessStateSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; type.</para>
        ///     <para type="description">Total count of devices with Exchange Access State: Allowed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary", HelpMessage = @"The &quot;allowedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 allowedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;blockedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; type.</para>
        ///     <para type="description">Total count of devices with Exchange Access State: Blocked.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary", HelpMessage = @"The &quot;blockedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 blockedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quarantinedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; type.</para>
        ///     <para type="description">Total count of devices with Exchange Access State: Quarantined.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary", HelpMessage = @"The &quot;quarantinedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 quarantinedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; type.</para>
        ///     <para type="description">Total count of devices with Exchange Access State: Unknown.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unavailableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceExchangeAccessStateSummary&quot; type.</para>
        ///     <para type="description">Total count of devices for which no Exchange Access State could be found.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceExchangeAccessStateSummary", HelpMessage = @"The &quot;unavailableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unavailableDeviceCount { get; set; }
    }
}