// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "UpdateWindowsDeviceAccountActionParameterObject", DefaultParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter")]
    [ODataType("microsoft.graph.updateWindowsDeviceAccountActionParameter")]
    public class New_UpdateWindowsDeviceAccountActionParameterObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceAccount&quot; property, of type &quot;microsoft.graph.windowsDeviceAccount&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsDeviceAccount", "microsoft.graph.windowsDeviceAzureADAccount", "microsoft.graph.windowsDeviceADAccount")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;deviceAccount&quot; property, of type &quot;microsoft.graph.windowsDeviceAccount&quot;.")]
        public System.Object deviceAccount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRotationEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;passwordRotationEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRotationEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;calendarSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean calendarSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceAccountEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;deviceAccountEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceAccountEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeServer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;exchangeServer&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeServer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sessionInitiationProtocalAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.updateWindowsDeviceAccountActionParameter&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.updateWindowsDeviceAccountActionParameter", HelpMessage = @"The &quot;sessionInitiationProtocalAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sessionInitiationProtocalAddress { get; set; }
    }
}