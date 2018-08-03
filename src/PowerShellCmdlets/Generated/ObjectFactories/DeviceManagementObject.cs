// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagement&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagement&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Singleton entity that acts as a container for all device management functionality.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementObject", DefaultParameterSetName = @"#microsoft.graph.deviceManagement")]
    [ODataType("microsoft.graph.deviceManagement")]
    public class New_DeviceManagementObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;subscriptionState&quot; property, of type &quot;microsoft.graph.deviceManagementSubscriptionState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Tenant mobile device management subscription state.</para>
        ///     <para type="description">
        ///          Valid values: &apos;pending&apos;, &apos;active&apos;, &apos;warning&apos;, &apos;disabled&apos;, &apos;deleted&apos;, &apos;blocked&apos;, &apos;lockedOut&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementSubscriptionState")]
        [Selectable]
        [ValidateSet(@"pending", @"active", @"warning", @"disabled", @"deleted", @"blocked", @"lockedOut")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;subscriptionState&quot; property, of type &quot;microsoft.graph.deviceManagementSubscriptionState&quot;.")]
        public System.String SubscriptionState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.deviceManagementSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Account level settings.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.deviceManagementSettings&quot;.")]
        public System.Object Settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intuneBrand&quot; property, of type &quot;microsoft.graph.intuneBrand&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</para>
        /// </summary>
        [ODataType("microsoft.graph.intuneBrand")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;intuneBrand&quot; property, of type &quot;microsoft.graph.intuneBrand&quot;.")]
        public System.Object IntuneBrand { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The terms and conditions associated with device management of the company.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        public System.Object[] TermsAndConditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applePushNotificationCertificate&quot; property, of type &quot;microsoft.graph.applePushNotificationCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Apple push notification certificate.</para>
        /// </summary>
        [ODataType("microsoft.graph.applePushNotificationCertificate")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;applePushNotificationCertificate&quot; property, of type &quot;microsoft.graph.applePushNotificationCertificate&quot;.")]
        public System.Object ApplePushNotificationCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOverview&quot; property, of type &quot;microsoft.graph.managedDeviceOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">Device overview</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOverview")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;managedDeviceOverview&quot; property, of type &quot;microsoft.graph.managedDeviceOverview&quot;.")]
        public System.Object ManagedDeviceOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;detectedApps&quot; property, of type &quot;microsoft.graph.detectedApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of detected apps associated with a device.</para>
        /// </summary>
        [ODataType("microsoft.graph.detectedApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;detectedApps&quot; property, of type &quot;microsoft.graph.detectedApp&quot;.")]
        public System.Object[] DetectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of managed devices.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] ManagedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurations&quot; property, of type &quot;microsoft.graph.deviceConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceConfigurations&quot; property, of type &quot;microsoft.graph.deviceConfiguration&quot;.")]
        public System.Object[] DeviceConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicies&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device compliance policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicies&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicy&quot;.")]
        public System.Object[] DeviceCompliancePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;softwareUpdateStatusSummary&quot; property, of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The software update status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;softwareUpdateStatusSummary&quot; property, of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;.")]
        public System.Object SoftwareUpdateStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyDeviceStateSummary&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device compliance state summary for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyDeviceStateSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicyDeviceStateSummary&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyDeviceStateSummary&quot;.")]
        public System.Object DeviceCompliancePolicyDeviceStateSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicySettingStateSummaries&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The summary states of compliance policy settings for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCompliancePolicySettingStateSummaries&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot;.")]
        public System.Object[] DeviceCompliancePolicySettingStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationDeviceStateSummaries&quot; property, of type &quot;microsoft.graph.deviceConfigurationDeviceStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The device configuration device state summary for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationDeviceStateSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceConfigurationDeviceStateSummaries&quot; property, of type &quot;microsoft.graph.deviceConfigurationDeviceStateSummary&quot;.")]
        public System.Object DeviceConfigurationDeviceStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosUpdateStatuses&quot; property, of type &quot;microsoft.graph.iosUpdateDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The IOS software update installation statuses for this account.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosUpdateDeviceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;iosUpdateStatuses&quot; property, of type &quot;microsoft.graph.iosUpdateDeviceStatus&quot;.")]
        public System.Object[] IosUpdateStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategories&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of device categories with the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceCategories&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.")]
        public System.Object[] DeviceCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeConnectors&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;exchangeConnectors&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.")]
        public System.Object[] ExchangeConnectors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentConfigurations&quot; property, of type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of device enrollment configurations</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceEnrollmentConfigurations&quot; property, of type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.")]
        public System.Object[] DeviceEnrollmentConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditionalAccessSettings&quot; property, of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
        /// </summary>
        [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;conditionalAccessSettings&quot; property, of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;.")]
        public System.Object ConditionalAccessSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileThreatDefenseConnectors&quot; property, of type &quot;microsoft.graph.mobileThreatDefenseConnector&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Mobile threat Defense connectors configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileThreatDefenseConnector")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;mobileThreatDefenseConnectors&quot; property, of type &quot;microsoft.graph.mobileThreatDefenseConnector&quot;.")]
        public System.Object[] MobileThreatDefenseConnectors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementPartners&quot; property, of type &quot;microsoft.graph.deviceManagementPartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of Device Management Partners configured by the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementPartner")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;deviceManagementPartners&quot; property, of type &quot;microsoft.graph.deviceManagementPartner&quot;.")]
        public System.Object[] DeviceManagementPartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationMessageTemplates&quot; property, of type &quot;microsoft.graph.notificationMessageTemplate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Notification Message Templates.</para>
        /// </summary>
        [ODataType("microsoft.graph.notificationMessageTemplate")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;notificationMessageTemplates&quot; property, of type &quot;microsoft.graph.notificationMessageTemplate&quot;.")]
        public System.Object[] NotificationMessageTemplates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleDefinitions&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Role Definitions.</para>
        /// </summary>
        [ODataType("microsoft.graph.roleDefinition")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;roleDefinitions&quot; property, of type &quot;microsoft.graph.roleDefinition&quot;.")]
        public System.Object[] RoleDefinitions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Role Assignments.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementRoleAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;roleAssignments&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementRoleAssignment&quot;.")]
        public System.Object[] RoleAssignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceOperations&quot; property, of type &quot;microsoft.graph.resourceOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The Resource Operations.</para>
        /// </summary>
        [ODataType("microsoft.graph.resourceOperation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;resourceOperations&quot; property, of type &quot;microsoft.graph.resourceOperation&quot;.")]
        public System.Object[] ResourceOperations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;telecomExpenseManagementPartners&quot; property, of type &quot;microsoft.graph.telecomExpenseManagementPartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The telecom expense management partners.</para>
        /// </summary>
        [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;telecomExpenseManagementPartners&quot; property, of type &quot;microsoft.graph.telecomExpenseManagementPartner&quot;.")]
        public System.Object[] TelecomExpenseManagementPartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistancePartners&quot; property, of type &quot;microsoft.graph.remoteAssistancePartner&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The remote assist partners.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistancePartner")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;remoteAssistancePartners&quot; property, of type &quot;microsoft.graph.remoteAssistancePartner&quot;.")]
        public System.Object[] RemoteAssistancePartners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionAppLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The windows information protection app learning summaries.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;windowsInformationProtectionAppLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot;.")]
        public System.Object[] WindowsInformationProtectionAppLearningSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionNetworkLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The windows information protection network learning summaries.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;windowsInformationProtectionNetworkLearningSummaries&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.")]
        public System.Object[] WindowsInformationProtectionNetworkLearningSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;troubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagement&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for the tenant.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagement", HelpMessage = @"The &quot;troubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.")]
        public System.Object[] TroubleshootingEvents { get; set; }
    }
}