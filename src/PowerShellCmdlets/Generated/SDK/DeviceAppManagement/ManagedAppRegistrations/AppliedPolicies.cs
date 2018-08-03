// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppPolicy&quot; objects in the &quot;appliedPolicies&quot; collection.</para>
    ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppPolicy")]
    [ResourceIdPropertyName("AppliedPolicyId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.")]
        public System.String AppliedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.windowsInformationProtection")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnMdmHandoffDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">New property in RS2, pending documentation</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Boolean RevokeOnMdmHandoffDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmEnrollmentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Enrollment url for the MDM</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.String MdmEnrollmentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsHelloForBusinessBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Boolean value that sets Windows Hello for Business as a method for signing into Windows.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Boolean WindowsHelloForBusinessBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 PinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of uppercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.String PinUppercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseLetters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of lowercase letters in the Windows Hello for Business PIN. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.String PinLowercaseLetters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharacters&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPinCharacterRequirements&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that configures the use of special characters in the Windows Hello for Business PIN. Valid special characters for Windows Hello for Business PIN gestures include: ! &quot; # $ % &amp; &apos; ( ) * + , - . / : ; &lt; = &gt; ? @ [ \ ] ^ _ ` { | } ~. Default is NotAllow.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPinCharacterRequirements")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.String PinSpecialCharacters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 PinExpirationDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberOfPastPinsRemembered&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 NumberOfPastPinsRemembered { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordMaximumAttemptCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 PasswordMaximumAttemptCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minutesOfInactivityBeforeDeviceLock&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 MinutesOfInactivityBeforeDeviceLock { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daysWithoutContactBeforeUnenroll&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        ///     <para type="description">Offline interval before app data is wiped (days) </para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.windowsInformationProtectionPolicy")]
        public System.Int32 DaysWithoutContactBeforeUnenroll { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        [DerivedType("microsoft.graph.managedAppConfiguration")]
        public System.Object[] CustomSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.targetedManagedAppConfiguration")]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.targetedManagedAppConfiguration")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.targetedManagedAppConfiguration")]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppProtection")]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app. (iOS Only)</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.String AppDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether screen capture is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether managed-app data should be encrypted. (Android only)</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.String MinimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.defaultManagedAppProtection")]
        public System.Boolean FaceIdBlocked { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/{AppliedPolicyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedAppPolicy&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedAppPolicy&quot; object to the &quot;appliedPolicies&quot; collection.</para>
    ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedAppPolicy")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        ///     <para type="description">
        ///          Valid values: &apos;noProtection&apos;, &apos;encryptAndAuditOnly&apos;, &apos;encryptAuditAndPrompt&apos;, &apos;encryptAuditAndBlock&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [ValidateSet(@"noProtection", @"encryptAndAuditOnly", @"encryptAuditAndPrompt", @"encryptAuditAndBlock")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsInformationProtectionPolicy")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter WindowsInformationProtectionPolicy { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter MdmWindowsInformationProtectionPolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        public System.Object[] CustomSettings { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.targetedManagedAppConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter TargetedManagedAppConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.defaultManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter DefaultManagedAppProtection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app. (iOS Only)</para>
        ///     <para type="description">
        ///          Valid values: &apos;useDeviceSettings&apos;, &apos;afterDeviceRestart&apos;, &apos;whenDeviceLockedExceptOpenFiles&apos;, &apos;whenDeviceLocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [ValidateSet(@"useDeviceSettings", @"afterDeviceRestart", @"whenDeviceLockedExceptOpenFiles", @"whenDeviceLocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        public System.String AppDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether screen capture is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether managed-app data should be encrypted. (Android only)</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FaceIdBlocked { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter AndroidManagedAppProtection { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter IosManagedAppProtection { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedAppPolicy&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.</para>
    ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.managedAppPolicy")]
    [ResourceIdPropertyName("AppliedPolicyId")]
    public class Update_DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.")]
        public System.String AppliedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicy&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">WIP enforcement level.See the Enum definition for supported values</para>
        ///     <para type="description">
        ///          Valid values: &apos;noProtection&apos;, &apos;encryptAndAuditOnly&apos;, &apos;encryptAuditAndPrompt&apos;, &apos;encryptAuditAndBlock&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionEnforcementLevel")]
        [Selectable]
        [ValidateSet(@"noProtection", @"encryptAndAuditOnly", @"encryptAuditAndPrompt", @"encryptAuditAndBlock")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enforcementLevel&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionEnforcementLevel&quot;.")]
        public System.String EnforcementLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Primary enterprise domain</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseDomain&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String EnterpriseDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of enterprise domains to be protected</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProtectedDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProtectedDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectionUnderLockConfigRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ProtectionUnderLockConfigRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataRecoveryCertificate&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot;.")]
        public System.Object DataRecoveryCertificate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;revokeOnUnenrollDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RevokeOnUnenrollDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;rightsManagementServicesTemplateId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid RightsManagementServicesTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies whether to allow Azure RMS encryption for WIP</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureRightsManagementServicesAllowed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AzureRightsManagementServicesAllowed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iconsVisible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IconsVisible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Protected applications can access enterprise data and the data handled by those applications are protected with encryption</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ProtectedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptApps&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionApp&quot;.")]
        public System.Object[] ExemptApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseNetworkDomainNames&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseNetworkDomainNames { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxiedDomains&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot;.")]
        public System.Object[] EnterpriseProxiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRanges&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot;.")]
        public System.Object[] EnterpriseIPRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseIPRangesAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseIPRangesAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is a list of proxy servers. Any server not on this list is considered non-enterprise</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This is the comma-separated list of internal proxy servers. For example, &quot;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&quot;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseInternalProxyServers&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] EnterpriseInternalProxyServers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enterpriseProxyServersAreAuthoritative&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EnterpriseProxyServersAreAuthoritative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">List of domain names that can used for work or personal resource</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;neutralDomainResources&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] NeutralDomainResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">This switch is for the Windows Search Indexer, to allow or disallow indexing of items</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;indexingEncryptedStoresOrItemsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IndexingEncryptedStoresOrItemsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;smbAutoEncryptedFileExtensions&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot;.")]
        public System.Object[] SmbAutoEncryptedFileExtensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input protected apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protectedAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ProtectedAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Another way to input exempt apps through xml files</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exemptAppLockerFiles&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.")]
        public System.Object[] ExemptAppLockerFiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtection&quot; type.</para>
        ///     <para type="description">Navigation property to list of security groups targeted for policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsInformationProtectionPolicy")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionPolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter WindowsInformationProtectionPolicy { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mdmWindowsInformationProtectionPolicy", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; type.")]
        public System.Management.Automation.SwitchParameter MdmWindowsInformationProtectionPolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        public System.Object[] CustomSettings { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.targetedManagedAppConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter TargetedManagedAppConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object DeploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is not connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The period after which access is checked when the device is connected to the internet.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOnlineBeforeAccessCheck&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOnlineBeforeAccessCheck { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Sources from which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedInboundDataTransferSources&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedInboundDataTransferSources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Destinations to which data is allowed to be transferred.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedApps&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataTransferLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedApps", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundDataTransferDestinations&quot; property, of type &quot;microsoft.graph.managedAppDataTransferLevel&quot;.")]
        public System.String AllowedOutboundDataTransferDestinations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether organizational credentials are required for app use.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationalCredentialsRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean OrganizationalCredentialsRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The level to which the clipboard may be shared between apps on the managed device.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allApps&apos;, &apos;managedAppsWithPasteIn&apos;, &apos;managedApps&apos;, &apos;blocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppClipboardSharingLevel")]
        [Selectable]
        [ValidateSet(@"allApps", @"managedAppsWithPasteIn", @"managedApps", @"blocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedOutboundClipboardSharingLevel&quot; property, of type &quot;microsoft.graph.managedAppClipboardSharingLevel&quot;.")]
        public System.String AllowedOutboundClipboardSharingLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether the backup of a managed app&apos;s data is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataBackupBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DataBackupBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether device compliance is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DeviceComplianceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether internet links should be opened in the managed browser app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedBrowserToOpenLinksRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ManagedBrowserToOpenLinksRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether users may use the &quot;Save As&quot; menu item to save a copy of protected files.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;saveAsBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SaveAsBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodOfflineBeforeWipeIsEnforced&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodOfflineBeforeWipeIsEnforced { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether an app-level pin is required.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PinRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;maximumPinRetries&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MaximumPinRetries { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether simplePin is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;simplePinBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SimplePinBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Minimum pin length required for an app-level pin if PinRequired is set to True</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumPinLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MinimumPinLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Character set which may be used for an app-level pin if PinRequired is set to True.</para>
        ///     <para type="description">
        ///          Valid values: &apos;numeric&apos;, &apos;alphanumericAndSymbol&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPinCharacterSet")]
        [Selectable]
        [ValidateSet(@"numeric", @"alphanumericAndSymbol")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinCharacterSet&quot; property, of type &quot;microsoft.graph.managedAppPinCharacterSet&quot;.")]
        public System.String PinCharacterSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">TimePeriod before the all-level pin must be reset if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Duration")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;periodBeforePinReset&quot; property, of type &quot;Edm.Duration&quot;.")]
        public System.TimeSpan PeriodBeforePinReset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Data storage locations where a user may store managed data.</para>
        ///     <para type="description">
        ///          Valid values: &apos;oneDriveForBusiness&apos;, &apos;sharePoint&apos;, &apos;localStorage&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataStorageLocation")]
        [Selectable]
        [ValidateSet(@"oneDriveForBusiness", @"sharePoint", @"localStorage")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowedDataStorageLocations&quot; property, of type &quot;microsoft.graph.managedAppDataStorageLocation&quot;.")]
        public System.String[] AllowedDataStorageLocations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether contacts can be synced to the user&apos;s device.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contactSyncBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ContactSyncBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether printing is allowed from managed apps.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;printBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PrintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fingerprintBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FingerprintBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the app pin is required if the device pin is set.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppPinIfDevicePinIsSet&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppPinIfDevicePinIsSet { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningOsVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningOsVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will result in warning message on the managed app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.targetedManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningAppVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningAppVersion { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.defaultManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter DefaultManagedAppProtection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Type of encryption which should be used for data in a managed app. (iOS Only)</para>
        ///     <para type="description">
        ///          Valid values: &apos;useDeviceSettings&apos;, &apos;afterDeviceRestart&apos;, &apos;whenDeviceLockedExceptOpenFiles&apos;, &apos;whenDeviceLocked&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppDataEncryptionType")]
        [Selectable]
        [ValidateSet(@"useDeviceSettings", @"afterDeviceRestart", @"whenDeviceLockedExceptOpenFiles", @"whenDeviceLocked")]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appDataEncryptionType&quot; property, of type &quot;microsoft.graph.managedAppDataEncryptionType&quot;.")]
        public System.String AppDataEncryptionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether screen capture is blocked.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;screenCaptureBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ScreenCaptureBlocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether managed-app data should be encrypted. (Android only)</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;encryptAppData&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean EncryptAppData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">When this setting is enabled, app level encryption is disabled if device level encryption is enabled</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;disableAppEncryptionIfDeviceEncryptionIsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Versions less than the specified version will block the managed app from accessing company data.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest required Android security patch level a user can have to gain secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumRequiredPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumRequiredPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Define the oldest recommended Android security patch level a user can have for secure access to the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;minimumWarningPatchVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MinimumWarningPatchVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultManagedAppProtection&quot; type.</para>
        ///     <para type="description">Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.defaultManagedAppProtection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;faceIdBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean FaceIdBlocked { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter AndroidManagedAppProtection { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppProtection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosManagedAppProtection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppProtection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppProtection&quot; type.")]
        public System.Management.Automation.SwitchParameter IosManagedAppProtection { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/{AppliedPolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedAppPolicy&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/AppliedPolicyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedAppPolicy&quot; object from the &quot;appliedPolicies&quot; collection.</para>
    ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppPolicy")]
    [ResourceIdPropertyName("AppliedPolicyId")]
    public class Remove_DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.")]
        public System.String AppliedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/{AppliedPolicyId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/targetApps</para>
    ///     <para type="description">The action &quot;microsoft.graph.targetApps&quot;, which exists on the type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies_TargetApps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppPolicy")]
    [ResourceIdPropertyName("AppliedPolicyId")]
    public class Invoke_DeviceAppManagement_ManagedAppRegistrations_AppliedPolicies_TargetApps : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;apps&quot; parameter, which is accepted by the &quot;microsoft.graph.targetApps&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;apps&quot; parameter, which is accepted by the &quot;microsoft.graph.targetApps&quot; action.")]
        public System.Object[] Apps { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;appliedPolicies&quot; collection.")]
        public System.String AppliedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/appliedPolicies/{AppliedPolicyId}/targetApps";
        }
    }
}