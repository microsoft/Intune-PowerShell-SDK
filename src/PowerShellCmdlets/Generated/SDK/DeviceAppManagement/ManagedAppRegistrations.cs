// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppRegistration&quot; objects in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">The managed app registrations.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppRegistrations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration")]
    [ResourceIdPropertyName("ManagedAppRegistrationId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppRegistrations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of creation</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of last the app synced with management service.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ApplicationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String ManagementSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Operating System version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String PlatformVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device type</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more reasons an app registration is flagged. E.g. app running on rooted device</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppFlaggedReason")]
        [Selectable]
        public System.String[] FlaggedReasons { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The user Id to who this app registration belongs.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The app package Identifier</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object AppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] AppliedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policies admin intended for the app as of now.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] IntendedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppOperation")]
        [Selectable]
        [Expandable]
        public System.Object[] Operations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedAppRegistration&quot; object to the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">The managed app registrations.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppRegistrations", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedAppRegistration")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppRegistrations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of creation</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of last the app synced with management service.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ApplicationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ManagementSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Operating System version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PlatformVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device type</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more reasons an app registration is flagged. E.g. app running on rooted device</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;rootedDevice&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppFlaggedReason")]
        [Selectable]
        [ValidateSet(@"none", @"rootedDevice")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        public System.String[] FlaggedReasons { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The user Id to who this app registration belongs.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The app package Identifier</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object AppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] AppliedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policies admin intended for the app as of now.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] IntendedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppOperation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        public System.Object[] Operations { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppRegistration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidManagedAppRegistration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppRegistration&quot; type.")]
        public System.Management.Automation.SwitchParameter AndroidManagedAppRegistration { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppRegistration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosManagedAppRegistration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppRegistration&quot; type.")]
        public System.Management.Automation.SwitchParameter IosManagedAppRegistration { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedAppRegistration&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppRegistrations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">The managed app registrations.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppRegistrations", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.managedAppRegistration")]
    [ResourceIdPropertyName("ManagedAppRegistrationId")]
    public class Update_DeviceAppManagement_ManagedAppRegistrations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of creation</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Date and time of last the app synced with management service.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;applicationVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ApplicationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managementSdkVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ManagementSdkVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Operating System version</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;platformVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PlatformVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device type</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Host device name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more reasons an app registration is flagged. E.g. app running on rooted device</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;rootedDevice&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppFlaggedReason")]
        [Selectable]
        [ValidateSet(@"none", @"rootedDevice")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;flaggedReasons&quot; property, of type &quot;microsoft.graph.managedAppFlaggedReason&quot;.")]
        public System.String[] FlaggedReasons { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The user Id to who this app registration belongs.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">The app package Identifier</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object AppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policys already applied on the registered app when it last synchronized with managment service.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appliedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] AppliedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more policies admin intended for the app as of now.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;intendedPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] IntendedPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppRegistration&quot; type.</para>
        ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppOperation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.managedAppOperation&quot;.")]
        public System.Object[] Operations { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppRegistration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidManagedAppRegistration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidManagedAppRegistration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidManagedAppRegistration&quot; type.")]
        public System.Management.Automation.SwitchParameter AndroidManagedAppRegistration { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppRegistration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosManagedAppRegistration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosManagedAppRegistration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosManagedAppRegistration&quot; type.")]
        public System.Management.Automation.SwitchParameter IosManagedAppRegistration { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedAppRegistration&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppRegistrations/ManagedAppRegistrationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedAppRegistration&quot; object from the &quot;managedAppRegistrations&quot; collection.</para>
    ///     <para type="description">The managed app registrations.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppRegistrations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppRegistration")]
    [ResourceIdPropertyName("ManagedAppRegistrationId")]
    public class Remove_DeviceAppManagement_ManagedAppRegistrations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations/getUserIdsWithFlaggedAppRegistration</para>
    ///     <para type="description">The function &quot;microsoft.graph.getUserIdsWithFlaggedAppRegistration&quot;, which exists on the type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;Edm.String&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_ManagedAppRegistrations_GetUserIdsWithFlaggedAppRegistration", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppRegistration")]
    public class Invoke_DeviceAppManagement_ManagedAppRegistrations_GetUserIdsWithFlaggedAppRegistration : FunctionReturningCollectionCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/getUserIdsWithFlaggedAppRegistration({this.GetFunctionUrlSegment()})";
        }
    }
}