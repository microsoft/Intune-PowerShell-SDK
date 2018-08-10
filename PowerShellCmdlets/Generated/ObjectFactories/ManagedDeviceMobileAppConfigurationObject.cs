// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">An abstract class for Mobile app configuration for enrolled devices.</para>
    /// </summary>
    [Cmdlet("New", "ManagedDeviceMobileAppConfigurationObject", DefaultParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration")]
    public class New_ManagedDeviceMobileAppConfigurationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">the associated app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] targetedMobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignemenets for app configration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration device status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        public System.Object deviceStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration user status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        public System.Object userStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosMobileAppConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter iosMobileAppConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">mdm app configuration Base64 binary.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] encodedSettingXml { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">app configuration setting items.</para>
        /// </summary>
        [ODataType("microsoft.graph.appConfigurationSettingItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.")]
        public System.Object[] settings { get; set; }
    }
}