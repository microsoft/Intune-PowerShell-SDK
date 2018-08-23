// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileAppAssignmentSettings&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileAppAssignmentSettings&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MobileAppAssignmentSettingsObject", DefaultParameterSetName = @"microsoft.graph.mobileAppAssignmentSettings")]
    [ODataType("microsoft.graph.mobileAppAssignmentSettings")]
    public class New_MobileAppAssignmentSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings")]
        [Parameter(ParameterSetName = @"microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings&quot; type.")]
        public System.Management.Automation.SwitchParameter microsoftStoreForBusinessAppAssignmentSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;useDeviceContext&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings&quot; type.</para>
        ///     <para type="description">Whether or not to use device execution context for Microsoft Store for Business mobile app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.microsoftStoreForBusinessAppAssignmentSettings", HelpMessage = @"The &quot;useDeviceContext&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean useDeviceContext { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppAppAssignmentSettings&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosVppAppAssignmentSettings")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppAppAssignmentSettings", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppAppAssignmentSettings&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppAppAssignmentSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;useDeviceLicensing&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppAppAssignmentSettings&quot; type.</para>
        ///     <para type="description">Whether or not to use device licensing.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppAppAssignmentSettings", HelpMessage = @"The &quot;useDeviceLicensing&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean useDeviceLicensing { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vpnConfigurationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppAppAssignmentSettings&quot; type.</para>
        ///     <para type="description">The VPN Configuration Id to apply for this app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosVppAppAssignmentSettings", HelpMessage = @"The &quot;vpnConfigurationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosStoreAppAssignmentSettings", HelpMessage = @"The &quot;vpnConfigurationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosLobAppAssignmentSettings", HelpMessage = @"The &quot;vpnConfigurationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String vpnConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosStoreAppAssignmentSettings&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosStoreAppAssignmentSettings")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosStoreAppAssignmentSettings", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosStoreAppAssignmentSettings&quot; type.")]
        public System.Management.Automation.SwitchParameter iosStoreAppAssignmentSettings { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosLobAppAssignmentSettings&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosLobAppAssignmentSettings")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosLobAppAssignmentSettings", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosLobAppAssignmentSettings&quot; type.")]
        public System.Management.Automation.SwitchParameter iosLobAppAssignmentSettings { get; set; }
    }
}