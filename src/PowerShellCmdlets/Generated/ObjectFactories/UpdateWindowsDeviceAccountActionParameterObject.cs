// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "UpdateWindowsDeviceAccountActionParameterObject", DefaultParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter")]
    [ODataType("microsoft.graph.updateWindowsDeviceAccountActionParameter")]
    public class New_UpdateWindowsDeviceAccountActionParameterObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceAccount&quot; property, of type &quot;microsoft.graph.windowsDeviceAccount&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsDeviceAccount")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;deviceAccount&quot; property, of type &quot;microsoft.graph.windowsDeviceAccount&quot;.")]
        public System.Object DeviceAccount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRotationEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;passwordRotationEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PasswordRotationEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;calendarSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean CalendarSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceAccountEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;deviceAccountEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceAccountEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeServer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;exchangeServer&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ExchangeServer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sessionInitiationProtocalAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;sessionInitiationProtocalAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SessionInitiationProtocalAddress { get; set; }
    }
}