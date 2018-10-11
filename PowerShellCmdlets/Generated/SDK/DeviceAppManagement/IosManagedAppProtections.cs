// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.iosManagedAppProtection&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/iosManagedAppProtections</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.iosManagedAppProtection&quot; objects in the &quot;iosManagedAppProtections&quot; collection.</para>
    ///     <para type="description">iOS managed app policies.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceAppManagement_IosManagedAppProtections", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    [ResourceReference]
    public class Get_DeviceAppManagement_IosManagedAppProtections : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [Sortable]
        public System.String appDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String minimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean faceIdBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan periodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan periodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        public System.String allowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        public System.String allowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean organizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [Sortable]
        public System.String allowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean dataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean deviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean managedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean saveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan periodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean pinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 maximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean simplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 minimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [Sortable]
        public System.String pinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        public System.TimeSpan periodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        public System.String[] allowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean contactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean printBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean fingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean disableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String minimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String minimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String minimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String minimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.iosManagedAppProtection&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/iosManagedAppProtections</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.iosManagedAppProtection&quot; object to the &quot;iosManagedAppProtections&quot; collection.</para>
    ///     <para type="description">iOS managed app policies.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceAppManagement_IosManagedAppProtections", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.iosManagedAppProtection")]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    [ResourceReference]
    public class New_DeviceAppManagement_IosManagedAppProtections : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app.</para>
        ///     <para type="description">
        ///          Valid values: &apos;useDeviceSettings&apos;, &apos;afterDeviceRestart&apos;, &apos;whenDeviceLockedExceptOpenFiles&apos;, &apos;whenDeviceLocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [ValidateSet(@"useDeviceSettings", @"afterDeviceRestart", @"whenDeviceLockedExceptOpenFiles", @"whenDeviceLocked")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        public System.String appDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean faceIdBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String allowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String allowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean organizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String allowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean dataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean managedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean saveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean pinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 maximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean simplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 minimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String pinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] allowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean contactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean printBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean fingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean disableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/iosManagedAppProtections</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
    ///     <para type="description">iOS managed app policies.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceAppManagement_IosManagedAppProtections", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.iosManagedAppProtection")]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    public class Update_DeviceAppManagement_IosManagedAppProtections : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app.</para>
        ///     <para type="description">
        ///          Valid values: &apos;useDeviceSettings&apos;, &apos;afterDeviceRestart&apos;, &apos;whenDeviceLockedExceptOpenFiles&apos;, &apos;whenDeviceLocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [ValidateSet(@"useDeviceSettings", @"afterDeviceRestart", @"whenDeviceLockedExceptOpenFiles", @"whenDeviceLocked")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        public System.String appDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean faceIdBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String allowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String allowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean organizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String allowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean dataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean managedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean saveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean pinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 maximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean simplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 minimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String pinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan periodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] allowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean contactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean printBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean fingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean disableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String minimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.iosManagedAppProtection&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/iosManagedAppProtections/iosManagedAppProtectionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.iosManagedAppProtection&quot; object from the &quot;iosManagedAppProtections&quot; collection.</para>
    ///     <para type="description">iOS managed app policies.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceAppManagement_IosManagedAppProtections", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    public class Remove_DeviceAppManagement_IosManagedAppProtections : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/iosManagedAppProtections/assign</para>
    ///     <para type="description">The action &quot;microsoft.graph.assign&quot;, which exists on the type &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceAppManagement_IosManagedAppProtections_Assign", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    public class Invoke_DeviceAppManagement_IosManagedAppProtections_Assign : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; action parameter of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; action parameter of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/assign";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/iosManagedAppProtections/targetApps</para>
    ///     <para type="description">The action &quot;microsoft.graph.targetApps&quot;, which exists on the type &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceAppManagement_IosManagedAppProtections_TargetApps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.iosManagedAppProtection")]
    [ResourceTypePropertyName("iosManagedAppProtectionODataType")]
    public class Invoke_DeviceAppManagement_IosManagedAppProtections_TargetApps : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;apps&quot; action parameter of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;apps&quot; action parameter of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.iosManagedAppProtection&quot; object in the &quot;iosManagedAppProtections&quot; collection.")]
        public System.String iosManagedAppProtectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtectionId}/targetApps";
        }
    }
}