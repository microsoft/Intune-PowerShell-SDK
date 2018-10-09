// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DirectoryObjects_ManagedAppRegistrations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    public class Get_DirectoryObjects_ManagedAppRegistrations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of creation</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of last the app synced with management service.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String applicationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String managementSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Operating System version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String platformVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device type</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more reasons an app registration is flagged. E.g. app running on rooted device</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppFlaggedReason")]
        [Selectable]
        public System.String[] flaggedReasons { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The user Id to who this app registration belongs.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The app package Identifier</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object appIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy", "microsoft.graph.windowsInformationProtection", "microsoft.graph.windowsInformationProtectionPolicy", "microsoft.graph.mdmWindowsInformationProtectionPolicy", "microsoft.graph.managedAppConfiguration", "microsoft.graph.targetedManagedAppConfiguration", "microsoft.graph.managedAppProtection", "microsoft.graph.defaultManagedAppProtection", "microsoft.graph.targetedManagedAppProtection", "microsoft.graph.androidManagedAppProtection", "microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] appliedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policies admin intended for the app as of now.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy", "microsoft.graph.windowsInformationProtection", "microsoft.graph.windowsInformationProtectionPolicy", "microsoft.graph.mdmWindowsInformationProtectionPolicy", "microsoft.graph.managedAppConfiguration", "microsoft.graph.targetedManagedAppConfiguration", "microsoft.graph.managedAppProtection", "microsoft.graph.defaultManagedAppProtection", "microsoft.graph.targetedManagedAppProtection", "microsoft.graph.androidManagedAppProtection", "microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] intendedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppOperation")]
        [Selectable]
        [Expandable]
        public System.Object[] operations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/{managedAppRegistrationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; object references.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; object references in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DirectoryObjects_ManagedAppRegistrationsReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    public class Get_DirectoryObjects_ManagedAppRegistrationsReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of creation</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of last the app synced with management service.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String applicationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String managementSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Operating System version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String platformVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device type</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more reasons an app registration is flagged. E.g. app running on rooted device</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppFlaggedReason")]
        [Selectable]
        public System.String[] flaggedReasons { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The user Id to who this app registration belongs.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The app package Identifier</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object appIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy", "microsoft.graph.windowsInformationProtection", "microsoft.graph.windowsInformationProtectionPolicy", "microsoft.graph.mdmWindowsInformationProtectionPolicy", "microsoft.graph.managedAppConfiguration", "microsoft.graph.targetedManagedAppConfiguration", "microsoft.graph.managedAppProtection", "microsoft.graph.defaultManagedAppProtection", "microsoft.graph.targetedManagedAppProtection", "microsoft.graph.androidManagedAppProtection", "microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] appliedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policies admin intended for the app as of now.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy", "microsoft.graph.windowsInformationProtection", "microsoft.graph.windowsInformationProtectionPolicy", "microsoft.graph.mdmWindowsInformationProtectionPolicy", "microsoft.graph.managedAppConfiguration", "microsoft.graph.targetedManagedAppConfiguration", "microsoft.graph.managedAppProtection", "microsoft.graph.defaultManagedAppProtection", "microsoft.graph.targetedManagedAppProtection", "microsoft.graph.androidManagedAppProtection", "microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] intendedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppOperation")]
        [Selectable]
        [Expandable]
        public System.Object[] operations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/{managedAppRegistrationId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;directoryObject&quot; to a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;directoryObject&quot; object to a &quot;managedAppRegistration&quot;.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DirectoryObjects_ManagedAppRegistrationsReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    public class New_DirectoryObjects_ManagedAppRegistrationsReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [Alias("iosManagedAppRegistrationReferenceUrl", "androidManagedAppRegistrationReferenceUrl")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.managedAppRegistration&quot; object.")]
        public System.String managedAppRegistrationReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/{managedAppRegistrationId}/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(managedAppRegistrationReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;directoryObject&quot; to a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">DELETE ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/managedAppRegistrationId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;directoryObject&quot; object to a &quot;managedAppRegistration&quot;.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DirectoryObjects_ManagedAppRegistrationsReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    public class Remove_DirectoryObjects_ManagedAppRegistrationsReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/managedAppRegistrations/{managedAppRegistrationId}/$ref";
        }
    }
}