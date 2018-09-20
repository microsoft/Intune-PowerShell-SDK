// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects.</para>
    ///     <para type="description">GET ~/me/managedAppRegistrations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    [Cmdlet("Get", "Me_ManagedAppRegistrations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    [ResourceIdPropertyName("managedAppRegistrationId")]
    public class Get_Me_ManagedAppRegistrations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
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
            return $"me/managedAppRegistrations/{managedAppRegistrationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; object references.</para>
    ///     <para type="description">GET ~/me/managedAppRegistrations/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; object references in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    [Cmdlet("Get", "Me_ManagedAppRegistrationsReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    [ResourceIdPropertyName("managedAppRegistrationId")]
    public class Get_Me_ManagedAppRegistrationsReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
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
            return $"me/managedAppRegistrations/{managedAppRegistrationId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;me&quot; to a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">POST ~/me/managedAppRegistrations/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;me&quot; object to a &quot;managedAppRegistration&quot;.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    [Cmdlet("New", "Me_ManagedAppRegistrationsReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    [ResourceIdPropertyName("managedAppRegistrationReferenceUrl")]
    public class New_Me_ManagedAppRegistrationsReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
        /// </summary>
        [Selectable]
        [Alias("iosManagedAppRegistrationReferenceUrl", "androidManagedAppRegistrationReferenceUrl")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.managedAppRegistration&quot; object.")]
        public System.String managedAppRegistrationReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedAppRegistrations/{managedAppRegistrationId}/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(managedAppRegistrationReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;me&quot; to a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">DELETE ~/me/managedAppRegistrations/managedAppRegistrationId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;me&quot; object to a &quot;managedAppRegistration&quot;.</para>
    ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_ManagedAppRegistrationsReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppRegistration", "microsoft.graph.androidManagedAppRegistration", "microsoft.graph.iosManagedAppRegistration")]
    [ResourceTypePropertyName("managedAppRegistrationODataType")]
    [ResourceIdPropertyName("managedAppRegistrationId")]
    public class Remove_Me_ManagedAppRegistrationsReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedAppRegistrations/{managedAppRegistrationId}/$ref";
        }
    }
}