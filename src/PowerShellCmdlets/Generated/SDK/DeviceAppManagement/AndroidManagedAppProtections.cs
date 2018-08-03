// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.androidManagedAppProtection&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/androidManagedAppProtections</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.androidManagedAppProtection&quot; objects in the &quot;androidManagedAppProtections&quot; collection.</para>
    ///     <para type="description">Android managed app policies.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_AndroidManagedAppProtections", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.androidManagedAppProtection")]
    [ResourceIdPropertyName("AndroidManagedAppProtectionId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_AndroidManagedAppProtections : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String AndroidManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether a managed user can take screen captures of managed apps</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether application data for managed apps should be encrypted</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [Sortable]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [Sortable]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{AndroidManagedAppProtectionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.androidManagedAppProtection&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/androidManagedAppProtections</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.androidManagedAppProtection&quot; object to the &quot;androidManagedAppProtections&quot; collection.</para>
    ///     <para type="description">Android managed app policies.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_AndroidManagedAppProtections", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.androidManagedAppProtection")]
    [ODataType("microsoft.graph.androidManagedAppProtection")]
    [ResourceReference]
    public class New_DeviceAppManagement_AndroidManagedAppProtections : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether a managed user can take screen captures of managed apps</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether application data for managed apps should be encrypted</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.androidManagedAppProtection&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/androidManagedAppProtections</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
    ///     <para type="description">Android managed app policies.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_AndroidManagedAppProtections", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.androidManagedAppProtection")]
    [ODataType("microsoft.graph.androidManagedAppProtection")]
    [ResourceIdPropertyName("AndroidManagedAppProtectionId")]
    public class Update_DeviceAppManagement_AndroidManagedAppProtections : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String AndroidManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether a managed user can take screen captures of managed apps</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether application data for managed apps should be encrypted</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{AndroidManagedAppProtectionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.androidManagedAppProtection&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/androidManagedAppProtections/AndroidManagedAppProtectionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.androidManagedAppProtection&quot; object from the &quot;androidManagedAppProtections&quot; collection.</para>
    ///     <para type="description">Android managed app policies.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_AndroidManagedAppProtections", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.androidManagedAppProtection")]
    [ResourceIdPropertyName("AndroidManagedAppProtectionId")]
    public class Remove_DeviceAppManagement_AndroidManagedAppProtections : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String AndroidManagedAppProtectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{AndroidManagedAppProtectionId}";
        }
    }
}