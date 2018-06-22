// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedDevice&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedDevice&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Devices that are managed or pre-enrolled through Intune</para>
    /// </summary>
    [Cmdlet("New", "ManagedDeviceObject", DefaultParameterSetName = @"#microsoft.graph.managedDevice")]
    [ODataType("microsoft.graph.managedDevice")]
    public class New_ManagedDeviceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Unique Identifier for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Name of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;company&apos;, &apos;personal&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceOwnerType")]
        [Selectable]
        [ValidateSet(@"unknown", @"company", @"personal")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;managedDeviceOwnerType&quot; property, of type &quot;microsoft.graph.managedDeviceOwnerType&quot;.")]
        public System.String managedDeviceOwnerType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">List of ComplexType deviceActionResult objects.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceActionResult")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceActionResults&quot; property, of type &quot;microsoft.graph.deviceActionResult&quot;.")]
        public System.Object[] deviceActionResults { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;enrolledDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset enrolledDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The date and time that the device last completed a successful sync with Intune.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system of the device. Windows, iOS, etc.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Compliance state of the device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;compliant&apos;, &apos;noncompliant&apos;, &apos;conflict&apos;, &apos;error&apos;, &apos;inGracePeriod&apos;, &apos;configManager&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceState")]
        [Selectable]
        [ValidateSet(@"unknown", @"compliant", @"noncompliant", @"conflict", @"error", @"inGracePeriod", @"configManager")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;complianceState&quot; property, of type &quot;microsoft.graph.complianceState&quot;.")]
        public System.String complianceState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">whether the device is jail broken or rooted.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;jailBroken&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String jailBroken { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Management channel of the device. Intune, EAS, etc.</para>
        ///     <para type="description">
        ///          Valid values: &apos;eas&apos;, &apos;mdm&apos;, &apos;easMdm&apos;, &apos;intuneClient&apos;, &apos;easIntuneClient&apos;, &apos;configurationManagerClient&apos;, &apos;configurationManagerClientMdm&apos;, &apos;configurationManagerClientMdmEas&apos;, &apos;unknown&apos;, &apos;jamf&apos;, &apos;googleCloudDevicePolicyController&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managementAgentType")]
        [Selectable]
        [ValidateSet(@"eas", @"mdm", @"easMdm", @"intuneClient", @"easIntuneClient", @"configurationManagerClient", @"configurationManagerClientMdm", @"configurationManagerClientMdmEas", @"unknown", @"jamf", @"googleCloudDevicePolicyController")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;managementAgent&quot; property, of type &quot;microsoft.graph.managementAgentType&quot;.")]
        public System.String managementAgent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Operating system version of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Exchange ActiveSync activated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;easActivated&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean easActivated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActiveSync Id of the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;easDeviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String easDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Exchange ActivationSync activation time of the device.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;easActivationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset easActivationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Whether the device is Azure Active Directory registered.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;azureADRegistered&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean azureADRegistered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Enrollment type of the device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;userEnrollment&apos;, &apos;deviceEnrollmentManager&apos;, &apos;appleBulkWithUser&apos;, &apos;appleBulkWithoutUser&apos;, &apos;windowsAzureADJoin&apos;, &apos;windowsBulkUserless&apos;, &apos;windowsAutoEnrollment&apos;, &apos;windowsBulkAzureDomainJoin&apos;, &apos;windowsCoManagement&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [ValidateSet(@"unknown", @"userEnrollment", @"deviceEnrollmentManager", @"appleBulkWithUser", @"appleBulkWithoutUser", @"windowsAzureADJoin", @"windowsBulkUserless", @"windowsAutoEnrollment", @"windowsBulkAzureDomainJoin", @"windowsCoManagement")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceEnrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        public System.String deviceEnrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Code that allows the Activation Lock on a device to be bypassed.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;activationLockBypassCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activationLockBypassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Email(s) for the user associated with the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String emailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The unique identifier for the Azure Active Directory device. Read only.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;azureADDeviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureADDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device registration state.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notRegistered&apos;, &apos;registered&apos;, &apos;revoked&apos;, &apos;keyConflict&apos;, &apos;approvalPending&apos;, &apos;certificateReset&apos;, &apos;notRegisteredPendingEnrollment&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceRegistrationState")]
        [Selectable]
        [ValidateSet(@"notRegistered", @"registered", @"revoked", @"keyConflict", @"approvalPending", @"certificateReset", @"notRegisteredPendingEnrollment", @"unknown")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceRegistrationState&quot; property, of type &quot;microsoft.graph.deviceRegistrationState&quot;.")]
        public System.String deviceRegistrationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceCategoryDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceCategoryDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device supervised status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;isSupervised&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSupervised { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Last time the device contacted Exchange.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;exchangeLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset exchangeLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The Access State of the device in Exchange.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;unknown&apos;, &apos;allowed&apos;, &apos;blocked&apos;, &apos;quarantined&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessState")]
        [Selectable]
        [ValidateSet(@"none", @"unknown", @"allowed", @"blocked", @"quarantined")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;exchangeAccessState&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessState&quot;.")]
        public System.String exchangeAccessState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The reason for the device&apos;s access state in Exchange.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;unknown&apos;, &apos;exchangeGlobalRule&apos;, &apos;exchangeIndividualRule&apos;, &apos;exchangeDeviceRule&apos;, &apos;exchangeUpgrade&apos;, &apos;exchangeMailboxPolicy&apos;, &apos;other&apos;, &apos;compliant&apos;, &apos;notCompliant&apos;, &apos;notEnrolled&apos;, &apos;unknownLocation&apos;, &apos;mfaRequired&apos;, &apos;azureADBlockDueToAccessPolicy&apos;, &apos;compromisedPassword&apos;, &apos;deviceNotKnownWithManagedApp&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeAccessStateReason")]
        [Selectable]
        [ValidateSet(@"none", @"unknown", @"exchangeGlobalRule", @"exchangeIndividualRule", @"exchangeDeviceRule", @"exchangeUpgrade", @"exchangeMailboxPolicy", @"other", @"compliant", @"notCompliant", @"notEnrolled", @"unknownLocation", @"mfaRequired", @"azureADBlockDueToAccessPolicy", @"compromisedPassword", @"deviceNotKnownWithManagedApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;exchangeAccessStateReason&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeAccessStateReason&quot;.")]
        public System.String exchangeAccessStateReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Url that allows a Remote Assistance session to be established with the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;remoteAssistanceSessionUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String remoteAssistanceSessionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">An error string that identifies issues when creating Remote Assistance session objects.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;remoteAssistanceSessionErrorDetails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String remoteAssistanceSessionErrorDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device encryption status</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device user principal name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;model&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Model of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;model&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String model { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Manufacturer of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;manufacturer&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String manufacturer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imei&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">IMEI</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;imei&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String imei { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">SerialNumber</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;serialNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Phone number of the device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;phoneNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String phoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Android security patch level</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;androidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String androidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">User display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">ConfigrMgr client enabled features</para>
        /// </summary>
        [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;configurationManagerClientEnabledFeatures&quot; property, of type &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot;.")]
        public System.Object configurationManagerClientEnabledFeatures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Wi-Fi MAC</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;wiFiMacAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String wiFiMacAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">The device health attestation state.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceHealthAttestationState")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceHealthAttestationState&quot; property, of type &quot;microsoft.graph.deviceHealthAttestationState&quot;.")]
        public System.Object deviceHealthAttestationState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Subscriber Carrier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;subscriberCarrier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subscriberCarrier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meid&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">MEID</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;meid&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String meid { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Total Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;totalStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 totalStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Free Storage in Bytes</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;freeStorageSpaceInBytes&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 freeStorageSpaceInBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Automatically generated name to identify a device. Can be overwritten to a user friendly name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;managedDeviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedDeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;activated&apos;, &apos;deactivated&apos;, &apos;secured&apos;, &apos;lowSeverity&apos;, &apos;mediumSeverity&apos;, &apos;highSeverity&apos;, &apos;unresponsive&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevicePartnerReportedHealthState")]
        [Selectable]
        [ValidateSet(@"unknown", @"activated", @"deactivated", @"secured", @"lowSeverity", @"mediumSeverity", @"highSeverity", @"unresponsive")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;partnerReportedThreatState&quot; property, of type &quot;microsoft.graph.managedDevicePartnerReportedHealthState&quot;.")]
        public System.String partnerReportedThreatState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device configuration states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceConfigurationState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceConfigurationStates&quot; property, of type &quot;microsoft.graph.deviceConfigurationState&quot;.")]
        public System.Object[] deviceConfigurationStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device category</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCategory")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceCategory&quot; property, of type &quot;microsoft.graph.deviceCategory&quot;.")]
        public System.Object deviceCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDevice&quot; type.</para>
        ///     <para type="description">Device compliance policy states for this device.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedDevice", HelpMessage = @"The &quot;deviceCompliancePolicyStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyState&quot;.")]
        public System.Object[] deviceCompliancePolicyStates { get; set; }
    }
}