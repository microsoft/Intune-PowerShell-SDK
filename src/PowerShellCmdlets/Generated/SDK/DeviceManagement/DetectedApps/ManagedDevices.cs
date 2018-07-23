// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDevice&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/detectedApps/{detectedAppId}/managedDevices</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDevice&quot; objects in the &quot;managedDevices&quot; collection.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DetectedApps_ManagedDevices", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("managedDeviceId")]
    public class Get_DeviceManagement_DetectedApps_ManagedDevices : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Unique Identifier for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Name of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOwnerType")]
        [Selectable]
        [Sortable]
        public System.String managedDeviceOwnerType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">List of ComplexType deviceActionResult objects.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceActionResult")]
        [Selectable]
        public System.Object[] deviceActionResults { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset enrolledDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The date and time that the device last completed a successful sync with Intune.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system of the device. Windows, iOS, etc.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Compliance state of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceState")]
        [Selectable]
        [Sortable]
        public System.String complianceState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">whether the device is jail broken or rooted.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String jailBroken { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Management channel of the device. Intune, EAS, etc.</para>
        /// </summary>
        [ODataType("microsoft.graph.managementAgentType")]
        [Selectable]
        [Sortable]
        public System.String managementAgent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system version of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Exchange ActiveSync activated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean easActivated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActiveSync Id of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String easDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActivationSync activation time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset easActivationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Azure Active Directory registered.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean azureADRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment type of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        public System.String deviceEnrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Code that allows the Activation Lock on a device to be bypassed.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activationLockBypassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Email(s) for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String emailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The unique identifier for the Azure Active Directory device. Read only.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String azureADDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device registration state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceRegistrationState")]
        [Selectable]
        [Sortable]
        public System.String deviceRegistrationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceCategoryDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device supervised status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isSupervised { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Last time the device contacted Exchange.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset exchangeLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The Access State of the device in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessState")]
        [Selectable]
        [Sortable]
        public System.String exchangeAccessState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The reason for the device&apos;s access state in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessStateReason")]
        [Selectable]
        [Sortable]
        public System.String exchangeAccessStateReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Url that allows a Remote Assistance session to be established with the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String remoteAssistanceSessionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">An error string that identifies issues when creating Remote Assistance session objects.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String remoteAssistanceSessionErrorDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device encryption status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device user principal name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;model&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Model of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String model { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Manufacturer of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String manufacturer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imei&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">IMEI</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String imei { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">SerialNumber</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Phone number of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String phoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Android security patch level</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String androidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">User display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">ConfigrMgr client enabled features</para>
        /// </summary>
        [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
        [Selectable]
        [Sortable]
        public System.Object configurationManagerClientEnabledFeatures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Wi-Fi MAC</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String wiFiMacAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The device health attestation state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceHealthAttestationState")]
        [Selectable]
        [Sortable]
        public System.Object deviceHealthAttestationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Subscriber Carrier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String subscriberCarrier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meid&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">MEID</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String meid { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Total Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 totalStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Free Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 freeStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Automatically generated name to identify a device. Can be overwritten to a user friendly name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String managedDeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevicePartnerReportedHealthState")]
        [Selectable]
        [Sortable]
        public System.String partnerReportedThreatState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device configuration states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceConfigurationStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deviceCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device compliance policy states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceCompliancePolicyStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}/managedDevices/{managedDeviceId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDevice&quot; object references.</para>
    ///     <para type="description">GET ~/deviceManagement/detectedApps/{detectedAppId}/managedDevices/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDevice&quot; object references in the &quot;managedDevices&quot; collection.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DetectedApps_ManagedDevicesReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("managedDeviceId")]
    public class Get_DeviceManagement_DetectedApps_ManagedDevicesReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Unique Identifier for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Name of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOwnerType")]
        [Selectable]
        [Sortable]
        public System.String managedDeviceOwnerType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">List of ComplexType deviceActionResult objects.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceActionResult")]
        [Selectable]
        public System.Object[] deviceActionResults { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset enrolledDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The date and time that the device last completed a successful sync with Intune.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system of the device. Windows, iOS, etc.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Compliance state of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceState")]
        [Selectable]
        [Sortable]
        public System.String complianceState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">whether the device is jail broken or rooted.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String jailBroken { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Management channel of the device. Intune, EAS, etc.</para>
        /// </summary>
        [ODataType("microsoft.graph.managementAgentType")]
        [Selectable]
        [Sortable]
        public System.String managementAgent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system version of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Exchange ActiveSync activated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean easActivated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActiveSync Id of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String easDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActivationSync activation time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset easActivationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Azure Active Directory registered.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean azureADRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment type of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        public System.String deviceEnrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Code that allows the Activation Lock on a device to be bypassed.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activationLockBypassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Email(s) for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String emailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The unique identifier for the Azure Active Directory device. Read only.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String azureADDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device registration state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceRegistrationState")]
        [Selectable]
        [Sortable]
        public System.String deviceRegistrationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceCategoryDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device supervised status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isSupervised { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Last time the device contacted Exchange.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset exchangeLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The Access State of the device in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessState")]
        [Selectable]
        [Sortable]
        public System.String exchangeAccessState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The reason for the device&apos;s access state in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessStateReason")]
        [Selectable]
        [Sortable]
        public System.String exchangeAccessStateReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Url that allows a Remote Assistance session to be established with the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String remoteAssistanceSessionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">An error string that identifies issues when creating Remote Assistance session objects.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String remoteAssistanceSessionErrorDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device encryption status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device user principal name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;model&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Model of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String model { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Manufacturer of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String manufacturer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imei&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">IMEI</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String imei { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">SerialNumber</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Phone number of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String phoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Android security patch level</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String androidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">User display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">ConfigrMgr client enabled features</para>
        /// </summary>
        [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
        [Selectable]
        [Sortable]
        public System.Object configurationManagerClientEnabledFeatures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Wi-Fi MAC</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String wiFiMacAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The device health attestation state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceHealthAttestationState")]
        [Selectable]
        [Sortable]
        public System.Object deviceHealthAttestationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Subscriber Carrier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String subscriberCarrier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meid&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">MEID</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String meid { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Total Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 totalStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Free Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 freeStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Automatically generated name to identify a device. Can be overwritten to a user friendly name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String managedDeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevicePartnerReportedHealthState")]
        [Selectable]
        [Sortable]
        public System.String partnerReportedThreatState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device configuration states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceConfigurationStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deviceCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device compliance policy states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceCompliancePolicyStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}/managedDevices/{managedDeviceId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;detectedApp&quot; to a &quot;microsoft.graph.managedDevice&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/detectedApps/{detectedAppId}/managedDevices/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;detectedApp&quot; object to a &quot;managedDevice&quot;.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DetectedApps_ManagedDevicesReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("managedDeviceReferenceUrl")]
    public class New_DeviceManagement_DetectedApps_ManagedDevicesReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.managedDevice&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.managedDevice&quot; object.")]
        public System.String managedDeviceReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}/managedDevices/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(managedDeviceReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;detectedApp&quot; to a &quot;microsoft.graph.managedDevice&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/detectedApps/{detectedAppId}/managedDevices/managedDeviceId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;detectedApp&quot; object to a &quot;managedDevice&quot;.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DetectedApps_ManagedDevicesReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("managedDeviceId")]
    public class Remove_DeviceManagement_DetectedApps_ManagedDevicesReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}/managedDevices/{managedDeviceId}/$ref";
        }
    }
}