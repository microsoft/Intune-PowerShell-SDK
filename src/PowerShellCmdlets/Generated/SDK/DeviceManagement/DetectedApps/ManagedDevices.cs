// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDevice&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/detectedApps/{DetectedAppId}/managedDevices</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDevice&quot; objects in the &quot;managedDevices&quot; collection.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DetectedApps_ManagedDevices", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("ManagedDeviceId")]
    public class Get_DeviceManagement_DetectedApps_ManagedDevices : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String DetectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String ManagedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Unique Identifier for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Name of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOwnerType")]
        [Selectable]
        [Sortable]
        public System.String ManagedDeviceOwnerType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">List of ComplexType deviceActionResult objects.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceActionResult")]
        [Selectable]
        public System.Object[] DeviceActionResults { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset EnrolledDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The date and time that the device last completed a successful sync with Intune.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system of the device. Windows, iOS, etc.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OperatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Compliance state of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceState")]
        [Selectable]
        [Sortable]
        public System.String ComplianceState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">whether the device is jail broken or rooted.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String JailBroken { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Management channel of the device. Intune, EAS, etc.</para>
        /// </summary>
        [ODataType("microsoft.graph.managementAgentType")]
        [Selectable]
        [Sortable]
        public System.String ManagementAgent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system version of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Exchange ActiveSync activated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean EasActivated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActiveSync Id of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String EasDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActivationSync activation time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset EasActivationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Azure Active Directory registered.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean AzureADRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment type of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        public System.String DeviceEnrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Code that allows the Activation Lock on a device to be bypassed.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ActivationLockBypassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Email(s) for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String EmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The unique identifier for the Azure Active Directory device. Read only.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String AzureADDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device registration state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceRegistrationState")]
        [Selectable]
        [Sortable]
        public System.String DeviceRegistrationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceCategoryDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device supervised status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsSupervised { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Last time the device contacted Exchange.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ExchangeLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The Access State of the device in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessState")]
        [Selectable]
        [Sortable]
        public System.String ExchangeAccessState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The reason for the device&apos;s access state in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessStateReason")]
        [Selectable]
        [Sortable]
        public System.String ExchangeAccessStateReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Url that allows a Remote Assistance session to be established with the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String RemoteAssistanceSessionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">An error string that identifies issues when creating Remote Assistance session objects.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String RemoteAssistanceSessionErrorDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device encryption status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device user principal name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;model&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Model of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Model { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Manufacturer of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Manufacturer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imei&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">IMEI</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Imei { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">SerialNumber</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String SerialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Phone number of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String PhoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Android security patch level</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String AndroidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">User display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">ConfigrMgr client enabled features</para>
        /// </summary>
        [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
        [Selectable]
        [Sortable]
        public System.Object ConfigurationManagerClientEnabledFeatures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Wi-Fi MAC</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String WiFiMacAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The device health attestation state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceHealthAttestationState")]
        [Selectable]
        [Sortable]
        public System.Object DeviceHealthAttestationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Subscriber Carrier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String SubscriberCarrier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meid&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">MEID</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Meid { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Total Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 TotalStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Free Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 FreeStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Automatically generated name to identify a device. Can be overwritten to a user friendly name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ManagedDeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevicePartnerReportedHealthState")]
        [Selectable]
        [Sortable]
        public System.String PartnerReportedThreatState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device configuration states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationState")]
        [Selectable]
        [Expandable]
        public System.Object[] DeviceConfigurationStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object DeviceCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device compliance policy states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyState")]
        [Selectable]
        [Expandable]
        public System.Object[] DeviceCompliancePolicyStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{DetectedAppId}/managedDevices/{ManagedDeviceId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDevice&quot; object references.</para>
    ///     <para type="description">GET ~/deviceManagement/detectedApps/{DetectedAppId}/managedDevices/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDevice&quot; object references in the &quot;managedDevices&quot; collection.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DetectedApps_ManagedDevicesReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("ManagedDeviceId")]
    public class Get_DeviceManagement_DetectedApps_ManagedDevicesReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String DetectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String ManagedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Unique Identifier for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Name of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOwnerType")]
        [Selectable]
        [Sortable]
        public System.String ManagedDeviceOwnerType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">List of ComplexType deviceActionResult objects.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceActionResult")]
        [Selectable]
        public System.Object[] DeviceActionResults { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset EnrolledDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The date and time that the device last completed a successful sync with Intune.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system of the device. Windows, iOS, etc.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OperatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Compliance state of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceState")]
        [Selectable]
        [Sortable]
        public System.String ComplianceState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">whether the device is jail broken or rooted.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String JailBroken { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Management channel of the device. Intune, EAS, etc.</para>
        /// </summary>
        [ODataType("microsoft.graph.managementAgentType")]
        [Selectable]
        [Sortable]
        public System.String ManagementAgent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system version of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Exchange ActiveSync activated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean EasActivated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActiveSync Id of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String EasDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActivationSync activation time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset EasActivationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Azure Active Directory registered.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean AzureADRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment type of the device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        public System.String DeviceEnrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Code that allows the Activation Lock on a device to be bypassed.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ActivationLockBypassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Email(s) for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String EmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The unique identifier for the Azure Active Directory device. Read only.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String AzureADDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device registration state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceRegistrationState")]
        [Selectable]
        [Sortable]
        public System.String DeviceRegistrationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceCategoryDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device supervised status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsSupervised { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Last time the device contacted Exchange.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ExchangeLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The Access State of the device in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessState")]
        [Selectable]
        [Sortable]
        public System.String ExchangeAccessState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The reason for the device&apos;s access state in Exchange.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessStateReason")]
        [Selectable]
        [Sortable]
        public System.String ExchangeAccessStateReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Url that allows a Remote Assistance session to be established with the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String RemoteAssistanceSessionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">An error string that identifies issues when creating Remote Assistance session objects.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String RemoteAssistanceSessionErrorDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device encryption status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device user principal name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;model&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Model of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Model { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Manufacturer of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Manufacturer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imei&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">IMEI</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Imei { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">SerialNumber</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String SerialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Phone number of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String PhoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Android security patch level</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String AndroidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">User display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">ConfigrMgr client enabled features</para>
        /// </summary>
        [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
        [Selectable]
        [Sortable]
        public System.Object ConfigurationManagerClientEnabledFeatures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Wi-Fi MAC</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String WiFiMacAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The device health attestation state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceHealthAttestationState")]
        [Selectable]
        [Sortable]
        public System.Object DeviceHealthAttestationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Subscriber Carrier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String SubscriberCarrier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meid&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">MEID</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Meid { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Total Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 TotalStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Free Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 FreeStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Automatically generated name to identify a device. Can be overwritten to a user friendly name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ManagedDeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevicePartnerReportedHealthState")]
        [Selectable]
        [Sortable]
        public System.String PartnerReportedThreatState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device configuration states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationState")]
        [Selectable]
        [Expandable]
        public System.Object[] DeviceConfigurationStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object DeviceCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device compliance policy states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyState")]
        [Selectable]
        [Expandable]
        public System.Object[] DeviceCompliancePolicyStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{DetectedAppId}/managedDevices/{ManagedDeviceId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;detectedApp&quot; to a &quot;microsoft.graph.managedDevice&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/detectedApps/{DetectedAppId}/managedDevices/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;detectedApp&quot; object to a &quot;managedDevice&quot;.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DetectedApps_ManagedDevicesReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("ManagedDeviceReferenceUrl")]
    public class New_DeviceManagement_DetectedApps_ManagedDevicesReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String DetectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.managedDevice&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.managedDevice&quot; object.")]
        public System.String ManagedDeviceReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{DetectedAppId}/managedDevices/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(ManagedDeviceReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;detectedApp&quot; to a &quot;microsoft.graph.managedDevice&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/detectedApps/{DetectedAppId}/managedDevices/ManagedDeviceId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;detectedApp&quot; object to a &quot;managedDevice&quot;.</para>
    ///     <para type="description">The devices that have the discovered application installed</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DetectedApps_ManagedDevicesReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedDevice")]
    [ResourceIdPropertyName("ManagedDeviceId")]
    public class Remove_DeviceManagement_DetectedApps_ManagedDevicesReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String ManagedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String DetectedAppId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{DetectedAppId}/managedDevices/{ManagedDeviceId}/$ref";
        }
    }
}