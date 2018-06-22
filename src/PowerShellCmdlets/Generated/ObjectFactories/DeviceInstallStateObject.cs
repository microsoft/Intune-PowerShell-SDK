// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceInstallState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceInstallState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Contains properties for the installation state for a device.</para>
    /// </summary>
    [Cmdlet("New", "DeviceInstallStateObject", DefaultParameterSetName = @"#microsoft.graph.deviceInstallState")]
    [ODataType("microsoft.graph.deviceInstallState")]
    public class New_DeviceInstallStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Last sync date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The install state of the eBook.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notApplicable&apos;, &apos;installed&apos;, &apos;failed&apos;, &apos;notInstalled&apos;, &apos;uninstallFailed&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.installState")]
        [Selectable]
        [ValidateSet(@"notApplicable", @"installed", @"failed", @"notInstalled", @"uninstallFailed", @"unknown")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;installState&quot; property, of type &quot;microsoft.graph.installState&quot;.")]
        public System.String installState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">The error code for install failures.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">OS Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;osDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceInstallState&quot; type.</para>
        ///     <para type="description">Device User Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceInstallState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }
    }
}