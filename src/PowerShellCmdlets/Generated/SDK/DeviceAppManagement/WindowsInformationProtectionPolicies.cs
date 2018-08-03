// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/windowsInformationProtectionPolicies</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
    ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_WindowsInformationProtectionPolicies", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
    [ResourceIdPropertyName("WindowsInformationProtectionPolicyId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_WindowsInformationProtectionPolicies : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String WindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">New property in RS2, pending documentation</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean RevokeOnMdmHandoffDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Enrollment url for the MDM</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String MdmEnrollmentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that sets Windows Hello for Business as a method for signing into Windows.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean WindowsHelloForBusinessBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of uppercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        public System.String PinUppercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of lowercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        public System.String PinLowercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of special characters in the Windows Hello for Business PIN. Valid special characters for Windows Hello for Business PIN gestures include: ! &quot; # $ % &amp; &apos; ( ) * + , - . / : ; &lt; = &gt; ? @ [ \ ] ^ _ ` { | } ~. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        public System.String PinSpecialCharacters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PinExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NumberOfPastPinsRemembered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PasswordMaximumAttemptCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 MinutesOfInactivityBeforeDeviceLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Offline interval before app data is wiped (days) </para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 DaysWithoutContactBeforeUnenroll { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [Sortable]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Sortable]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [Expandable]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [Expandable]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{WindowsInformationProtectionPolicyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/windowsInformationProtectionPolicies</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object to the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
    ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_WindowsInformationProtectionPolicies", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy")]
    [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
    [ResourceReference]
    public class New_DeviceAppManagement_WindowsInformationProtectionPolicies : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">New property in RS2, pending documentation</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnMdmHandoffDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Enrollment url for the MDM</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MdmEnrollmentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that sets Windows Hello for Business as a method for signing into Windows.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean WindowsHelloForBusinessBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of uppercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinUppercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of lowercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinLowercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of special characters in the Windows Hello for Business PIN. Valid special characters for Windows Hello for Business PIN gestures include: ! &quot; # $ % &amp; &apos; ( ) * + , - . / : ; &lt; = &gt; ? @ [ \ ] ^ _ ` { | } ~. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinSpecialCharacters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NumberOfPastPinsRemembered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PasswordMaximumAttemptCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinutesOfInactivityBeforeDeviceLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Offline interval before app data is wiped (days) </para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DaysWithoutContactBeforeUnenroll { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        ///     <para type="description">
        ///          Valid values: &apos;noProtection&apos;, &apos;encryptAndAuditOnly&apos;, &apos;encryptAuditAndPrompt&apos;, &apos;encryptAuditAndBlock&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [ValidateSet(@"noProtection", @"encryptAndAuditOnly", @"encryptAuditAndPrompt", @"encryptAuditAndBlock")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/windowsInformationProtectionPolicies</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
    ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_WindowsInformationProtectionPolicies", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy")]
    [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
    [ResourceIdPropertyName("WindowsInformationProtectionPolicyId")]
    public class Update_DeviceAppManagement_WindowsInformationProtectionPolicies : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String WindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">New property in RS2, pending documentation</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnMdmHandoffDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Enrollment url for the MDM</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MdmEnrollmentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that sets Windows Hello for Business as a method for signing into Windows.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean WindowsHelloForBusinessBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of uppercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinUppercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of lowercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinLowercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of special characters in the Windows Hello for Business PIN. Valid special characters for Windows Hello for Business PIN gestures include: ! &quot; # $ % &amp; &apos; ( ) * + , - . / : ; &lt; = &gt; ? @ [ \ ] ^ _ ` { | } ~. Default is NotAllow.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notAllow&apos;, &apos;requireAtLeastOne&apos;, &apos;allow&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [ValidateSet(@"notAllow", @"requireAtLeastOne", @"allow")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.")]
        public System.String PinSpecialCharacters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NumberOfPastPinsRemembered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PasswordMaximumAttemptCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinutesOfInactivityBeforeDeviceLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Offline interval before app data is wiped (days) </para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DaysWithoutContactBeforeUnenroll { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        ///     <para type="description">
        ///          Valid values: &apos;noProtection&apos;, &apos;encryptAndAuditOnly&apos;, &apos;encryptAuditAndPrompt&apos;, &apos;encryptAuditAndBlock&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [ValidateSet(@"noProtection", @"encryptAndAuditOnly", @"encryptAuditAndPrompt", @"encryptAuditAndBlock")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{WindowsInformationProtectionPolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/windowsInformationProtectionPolicies/WindowsInformationProtectionPolicyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object from the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
    ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_WindowsInformationProtectionPolicies", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
    [ResourceIdPropertyName("WindowsInformationProtectionPolicyId")]
    public class Remove_DeviceAppManagement_WindowsInformationProtectionPolicies : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String WindowsInformationProtectionPolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{WindowsInformationProtectionPolicyId}";
        }
    }
}