// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceCompliancePolicy&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicies</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceCompliancePolicy&quot; objects in the &quot;deviceCompliancePolicies&quot; collection.</para>
    ///     <para type="description">The device compliance policies.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicies", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicies : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The list of scheduled action for this rule</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
        [Selectable]
        [Expandable]
        public System.Object[] scheduledActionsForRule { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance devices status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deviceStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance users status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserOverview")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object userStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Compliance Setting State Device Summary</para>
        /// </summary>
        [ODataType("microsoft.graph.settingStateDeviceSummary")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceSettingStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The collection of assignments for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to block syncing the calendar.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Boolean passwordBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the password expires.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Int32 passwordExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passwords.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Int32 passwordMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a password is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Int32 passwordMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Int32 passwordMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The required password type.</para>
        /// </summary>
        [ODataType("microsoft.graph.androidRequiredPasswordType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.String passwordRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passwords to block. Valid values 0 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Int32 passwordPreviousPasswordBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to require a password.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Boolean passwordRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.String osMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.String osMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require encryption on windows phone devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsPhone81CompliancePolicy")]
        public System.Boolean storageRequireEncryption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10MobileCompliancePolicy")]
        public System.Boolean passwordRequireToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10MobileCompliancePolicy")]
        public System.Boolean earlyLaunchAntiMalwareDriverEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10MobileCompliancePolicy")]
        public System.Boolean bitLockerEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10MobileCompliancePolicy")]
        public System.Boolean secureBootEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10MobileCompliancePolicy")]
        public System.Boolean codeIntegrityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10CompliancePolicy")]
        public System.Boolean passwordRequiredToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10CompliancePolicy")]
        public System.Boolean requireHealthyDeviceReport { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10CompliancePolicy")]
        public System.String mobileOsMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windows10CompliancePolicy")]
        public System.String mobileOsMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled system integrity protection.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.Boolean systemIntegrityProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled device threat protection .</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.Boolean deviceThreatProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Mobile Threat Protection minimum risk level to report noncompliance.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceThreatProtectionLevel")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.String deviceThreatProtectionRequiredSecurityLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether the firewall should be enabled or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.Boolean firewallEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to the “Block all incoming connections” option.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.Boolean firewallBlockAllIncoming { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to “Enable stealth mode.”</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.macOSCompliancePolicy")]
        public System.Boolean firewallEnableStealthMode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to block simple passcodes.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Boolean passcodeBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the passcode expires. Valid values 1 to 65535</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Int32 passcodeExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passcode. Valid values 4 to 14</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Int32 passcodeMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a passcode is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Int32 passcodeMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passcodes to block. Valid values 1 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Int32 passcodePreviousPasscodeBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Int32 passcodeMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The required passcode type.</para>
        /// </summary>
        [ODataType("microsoft.graph.requiredPasswordType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.String passcodeRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a passcode.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Boolean passcodeRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Devices must not be jailbroken or rooted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Boolean securityBlockJailbrokenDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a managed email profile.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosCompliancePolicy")]
        public System.Boolean managedEmailProfileRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices disallow installation of apps from unknown sources.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityPreventInstallAppsFromUnknownSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Disable USB debugging on Android devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityDisableUsbDebugging { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the Android Verify apps feature is turned on.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireVerifyApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Android security patch level.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.String minAndroidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet basic integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireSafetyNetAttestationBasicIntegrity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet certified device check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireSafetyNetAttestationCertifiedDevice { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Google Play Services to be installed and enabled on the device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireGooglePlayServices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireUpToDateSecurityProviders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the Company Portal client app runtime integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.androidCompliancePolicy")]
        public System.Boolean securityRequireCompanyPortalAppIntegrity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCompliancePolicy&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceCompliancePolicy&quot; object to the &quot;deviceCompliancePolicies&quot; collection.</para>
    ///     <para type="description">The device compliance policies.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicies", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicies : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The list of scheduled action for this rule</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        public System.Object[] scheduledActionsForRule { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance devices status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        public System.Object deviceStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance users status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserOverview")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        public System.Object userStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Compliance Setting State Device Summary</para>
        /// </summary>
        [ODataType("microsoft.graph.settingStateDeviceSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        public System.Object[] deviceSettingStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The collection of assignments for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsPhone81CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsPhone81CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to block syncing the calendar.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the password expires.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passwords.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a password is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The required password type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;deviceDefault&apos;, &apos;alphanumeric&apos;, &apos;numeric&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.androidRequiredPasswordType")]
        [Selectable]
        [ValidateSet(@"deviceDefault", @"alphanumeric", @"numeric")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        public System.String passwordRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passwords to block. Valid values 0 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordPreviousPasswordBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to require a password.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require encryption on windows phone devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean storageRequireEncryption { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows81CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows81CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows81CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows81CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows10MobileCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows10MobileCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequireToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean earlyLaunchAntiMalwareDriverEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean bitLockerEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean secureBootEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean codeIntegrityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows10CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows10CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequiredToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean requireHealthyDeviceReport { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobileOsMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobileOsMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.macOSCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter macOSCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled system integrity protection.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean systemIntegrityProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled device threat protection .</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deviceThreatProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Mobile Threat Protection minimum risk level to report noncompliance.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unavailable&apos;, &apos;secured&apos;, &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;notSet&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceThreatProtectionLevel")]
        [Selectable]
        [ValidateSet(@"unavailable", @"secured", @"low", @"medium", @"high", @"notSet")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        public System.String deviceThreatProtectionRequiredSecurityLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether the firewall should be enabled or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to the “Block all incoming connections” option.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallBlockAllIncoming { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to “Enable stealth mode.”</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallEnableStealthMode { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter iosCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to block simple passcodes.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passcodeBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the passcode expires. Valid values 1 to 65535</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passcode. Valid values 4 to 14</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a passcode is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passcodes to block. Valid values 1 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodePreviousPasscodeBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The required passcode type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;deviceDefault&apos;, &apos;alphanumeric&apos;, &apos;numeric&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.requiredPasswordType")]
        [Selectable]
        [ValidateSet(@"deviceDefault", @"alphanumeric", @"numeric")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        public System.String passcodeRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a passcode.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passcodeRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Devices must not be jailbroken or rooted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityBlockJailbrokenDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a managed email profile.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean managedEmailProfileRequired { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.androidCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter androidCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices disallow installation of apps from unknown sources.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityPreventInstallAppsFromUnknownSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Disable USB debugging on Android devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityDisableUsbDebugging { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the Android Verify apps feature is turned on.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireVerifyApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Android security patch level.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minAndroidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet basic integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireSafetyNetAttestationBasicIntegrity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet certified device check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireSafetyNetAttestationCertifiedDevice { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Google Play Services to be installed and enabled on the device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireGooglePlayServices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireUpToDateSecurityProviders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the Company Portal client app runtime integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireCompanyPortalAppIntegrity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCompliancePolicy&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicies</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
    ///     <para type="description">The device compliance policies.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicies", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    public class Update_DeviceManagement_DeviceCompliancePolicies : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The list of scheduled action for this rule</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scheduledActionsForRule&quot; property, of type &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.")]
        public System.Object[] scheduledActionsForRule { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceStatus&quot;.")]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">List of DeviceComplianceUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.deviceComplianceUserStatus&quot;.")]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance devices status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceDeviceOverview")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceDeviceOverview&quot;.")]
        public System.Object deviceStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Device compliance users status overview</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceUserOverview")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatusOverview&quot; property, of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;.")]
        public System.Object userStatusOverview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">Compliance Setting State Device Summary</para>
        /// </summary>
        [ODataType("microsoft.graph.settingStateDeviceSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceSettingStateSummaries&quot; property, of type &quot;microsoft.graph.settingStateDeviceSummary&quot;.")]
        public System.Object[] deviceSettingStateSummaries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicy&quot; type.</para>
        ///     <para type="description">The collection of assignments for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsPhone81CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsPhone81CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to block syncing the calendar.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the password expires.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passwords.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a password is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">The required password type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;deviceDefault&apos;, &apos;alphanumeric&apos;, &apos;numeric&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.androidRequiredPasswordType")]
        [Selectable]
        [ValidateSet(@"deviceDefault", @"alphanumeric", @"numeric")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        public System.String passwordRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passwords to block. Valid values 0 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordPreviousPasswordBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passwordPreviousPasswordBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether or not to require a password.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsPhone81CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require encryption on windows phone devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsPhone81CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;storageRequireEncryption&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean storageRequireEncryption { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows81CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows81CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows81CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows81CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows81CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows10MobileCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows10MobileCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequireToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequireToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;earlyLaunchAntiMalwareDriverEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean earlyLaunchAntiMalwareDriverEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bitLockerEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean bitLockerEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;secureBootEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean secureBootEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10MobileCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10MobileCompliancePolicy", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;codeIntegrityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean codeIntegrityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windows10CompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter windows10CompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require a password to unlock an idle device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordRequiredToUnlockFromIdle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passwordRequiredToUnlockFromIdle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Require devices to be reported as healthy by Windows Device Health Attestation.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;requireHealthyDeviceReport&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean requireHealthyDeviceReport { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileOsMinimumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobileOsMinimumVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10CompliancePolicy&quot; type.</para>
        ///     <para type="description">Maximum Windows Phone version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windows10CompliancePolicy", HelpMessage = @"The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileOsMaximumVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobileOsMaximumVersion { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.macOSCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter macOSCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled system integrity protection.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;systemIntegrityProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean systemIntegrityProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices have enabled device threat protection .</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceThreatProtectionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deviceThreatProtectionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Mobile Threat Protection minimum risk level to report noncompliance.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unavailable&apos;, &apos;secured&apos;, &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;notSet&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceThreatProtectionLevel")]
        [Selectable]
        [ValidateSet(@"unavailable", @"secured", @"low", @"medium", @"high", @"notSet")]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceThreatProtectionRequiredSecurityLevel&quot; property, of type &quot;microsoft.graph.deviceThreatProtectionLevel&quot;.")]
        public System.String deviceThreatProtectionRequiredSecurityLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Whether the firewall should be enabled or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to the “Block all incoming connections” option.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallBlockAllIncoming&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallBlockAllIncoming { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.macOSCompliancePolicy&quot; type.</para>
        ///     <para type="description">Corresponds to “Enable stealth mode.”</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.macOSCompliancePolicy", HelpMessage = @"The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;firewallEnableStealthMode&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean firewallEnableStealthMode { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter iosCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to block simple passcodes.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeBlockSimple&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passcodeBlockSimple { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of days before the passcode expires. Valid values 1 to 65535</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum length of passcode. Valid values 4 to 14</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minutes of inactivity before a passcode is required.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinutesOfInactivityBeforeLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinutesOfInactivityBeforeLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Number of previous passcodes to block. Valid values 1 to 24</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodePreviousPasscodeBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodePreviousPasscodeBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The number of character sets required in the password.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeMinimumCharacterSetCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 passcodeMinimumCharacterSetCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">The required passcode type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;deviceDefault&apos;, &apos;alphanumeric&apos;, &apos;numeric&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.requiredPasswordType")]
        [Selectable]
        [ValidateSet(@"deviceDefault", @"alphanumeric", @"numeric")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeRequiredType&quot; property, of type &quot;microsoft.graph.requiredPasswordType&quot;.")]
        public System.String passcodeRequiredType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a passcode.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passcodeRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean passcodeRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Devices must not be jailbroken or rooted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityBlockJailbrokenDevices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityBlockJailbrokenDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosCompliancePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether or not to require a managed email profile.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosCompliancePolicy", HelpMessage = @"The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedEmailProfileRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean managedEmailProfileRequired { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.androidCompliancePolicy")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidCompliancePolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter androidCompliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require that devices disallow installation of apps from unknown sources.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityPreventInstallAppsFromUnknownSources&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityPreventInstallAppsFromUnknownSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Disable USB debugging on Android devices.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityDisableUsbDebugging&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityDisableUsbDebugging { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the Android Verify apps feature is turned on.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireVerifyApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireVerifyApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Minimum Android security patch level.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minAndroidSecurityPatchLevel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minAndroidSecurityPatchLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet basic integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationBasicIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireSafetyNetAttestationBasicIntegrity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the SafetyNet certified device check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireSafetyNetAttestationCertifiedDevice&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireSafetyNetAttestationCertifiedDevice { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require Google Play Services to be installed and enabled on the device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireGooglePlayServices&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireGooglePlayServices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireUpToDateSecurityProviders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireUpToDateSecurityProviders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidCompliancePolicy&quot; type.</para>
        ///     <para type="description">Require the device to pass the Company Portal client app runtime integrity check.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidCompliancePolicy", HelpMessage = @"The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityRequireCompanyPortalAppIntegrity&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityRequireCompanyPortalAppIntegrity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCompliancePolicy&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicies/deviceCompliancePolicyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceCompliancePolicy&quot; object from the &quot;deviceCompliancePolicies&quot; collection.</para>
    ///     <para type="description">The device compliance policies.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicies", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    public class Remove_DeviceManagement_DeviceCompliancePolicies : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/assign</para>
    ///     <para type="description">The action &quot;microsoft.graph.assign&quot;, which exists on the type &quot;microsoft.graph.deviceCompliancePolicy&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;microsoft.graph.deviceCompliancePolicyAssignment&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceManagement_DeviceCompliancePolicies_Assign", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    public class Invoke_DeviceManagement_DeviceCompliancePolicies_Assign : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/assign";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/scheduleActionsForRules</para>
    ///     <para type="description">The action &quot;microsoft.graph.scheduleActionsForRules&quot;, which exists on the type &quot;microsoft.graph.deviceCompliancePolicy&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceManagement_DeviceCompliancePolicies_ScheduleActionsForRules", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicy", "microsoft.graph.windowsPhone81CompliancePolicy", "microsoft.graph.windows81CompliancePolicy", "microsoft.graph.windows10MobileCompliancePolicy", "microsoft.graph.windows10CompliancePolicy", "microsoft.graph.macOSCompliancePolicy", "microsoft.graph.iosCompliancePolicy", "microsoft.graph.androidCompliancePolicy")]
    [ResourceTypePropertyName("deviceCompliancePolicyODataType")]
    [ResourceIdPropertyName("deviceCompliancePolicyId")]
    public class Invoke_DeviceManagement_DeviceCompliancePolicies_ScheduleActionsForRules : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceScheduledActionForRules&quot; parameter, which is accepted by the &quot;microsoft.graph.scheduleActionsForRules&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceComplianceScheduledActionForRules&quot; parameter, which is accepted by the &quot;microsoft.graph.scheduleActionsForRules&quot; action.")]
        public System.Object[] deviceComplianceScheduledActionForRules { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduleActionsForRules";
        }
    }
}