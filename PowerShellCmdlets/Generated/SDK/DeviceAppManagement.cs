// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceAppManagement&quot; object.</para>
    ///     <para type="description">GET ~/deviceAppManagement</para>
    ///     <para type="description">Retrieves the &quot;deviceAppManagement&quot; object (which is of type &quot;microsoft.graph.deviceAppManagement&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceAppManagement")]
    public class Get_DeviceAppManagement : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time the apps from the Microsoft Store for Business were synced successfully for the account.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset microsoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Whether the account is enabled for syncing applications from the Microsoft Store for Business.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isEnabledForMicrosoftStoreForBusiness { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is &lt;languagecode2&gt;-&lt;country/regioncode2&gt;, where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String microsoftStoreForBusinessLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time an application sync from the Microsoft Store for Business was completed.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset microsoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile apps.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileApp")]
        [Selectable]
        [Expandable]
        public System.Object[] mobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile app categories.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppCategory")]
        [Selectable]
        [Expandable]
        public System.Object[] mobileAppCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration")]
        [Selectable]
        [Expandable]
        public System.Object[] mobileAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">List of Vpp tokens for this organization.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppToken")]
        [Selectable]
        [Expandable]
        public System.Object[] vppTokens { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] managedAppPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">iOS managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] iosManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Android managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.androidManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] androidManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Default managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.defaultManagedAppProtection")]
        [Selectable]
        [Expandable]
        public System.Object[] defaultManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Targeted managed app configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
        [Selectable]
        [Expandable]
        public System.Object[] targetedManagedAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] mdmWindowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] windowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app registrations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [Expandable]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app statuses.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] managedAppStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedEBook")]
        [Selectable]
        [Expandable]
        public System.Object[] managedEBooks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceAppManagement&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement</para>
    ///     <para type="description">Creates the &quot;deviceAppManagement&quot; object (which is of type &quot;microsoft.graph.deviceAppManagement&quot;).</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceAppManagement")]
    [ODataType("microsoft.graph.deviceAppManagement")]
    public class New_DeviceAppManagement : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time the apps from the Microsoft Store for Business were synced successfully for the account.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset microsoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Whether the account is enabled for syncing applications from the Microsoft Store for Business.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEnabledForMicrosoftStoreForBusiness { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is &lt;languagecode2&gt;-&lt;country/regioncode2&gt;, where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String microsoftStoreForBusinessLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time an application sync from the Microsoft Store for Business was completed.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset microsoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile apps.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.")]
        public System.Object[] mobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile app categories.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        public System.Object[] mobileAppCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.")]
        public System.Object[] mobileAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">List of Vpp tokens for this organization.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppToken")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.")]
        public System.Object[] vppTokens { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] managedAppPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">iOS managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.")]
        public System.Object[] iosManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Android managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.androidManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.")]
        public System.Object[] androidManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Default managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.defaultManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.")]
        public System.Object[] defaultManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Targeted managed app configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.")]
        public System.Object[] targetedManagedAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.")]
        public System.Object[] mdmWindowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.")]
        public System.Object[] windowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app registrations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app statuses.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.")]
        public System.Object[] managedAppStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedEBook")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.")]
        public System.Object[] managedEBooks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceAppManagement&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement</para>
    ///     <para type="description">Updates the &quot;deviceAppManagement&quot; object (which is of type &quot;microsoft.graph.deviceAppManagement&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceAppManagement")]
    [ODataType("microsoft.graph.deviceAppManagement")]
    public class Update_DeviceAppManagement : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time the apps from the Microsoft Store for Business were synced successfully for the account.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLastSuccessfulSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset microsoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Whether the account is enabled for syncing applications from the Microsoft Store for Business.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isEnabledForMicrosoftStoreForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEnabledForMicrosoftStoreForBusiness { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is &lt;languagecode2&gt;-&lt;country/regioncode2&gt;, where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String microsoftStoreForBusinessLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The last time an application sync from the Microsoft Store for Business was completed.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;microsoftStoreForBusinessLastCompletedApplicationSyncTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset microsoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile apps.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileApps&quot; property, of type &quot;microsoft.graph.mobileApp&quot;.")]
        public System.Object[] mobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The mobile app categories.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppCategories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        public System.Object[] mobileAppCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppConfigurations&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.")]
        public System.Object[] mobileAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">List of Vpp tokens for this organization.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppToken")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;vppTokens&quot; property, of type &quot;microsoft.graph.vppToken&quot;.")]
        public System.Object[] vppTokens { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppPolicies&quot; property, of type &quot;microsoft.graph.managedAppPolicy&quot;.")]
        public System.Object[] managedAppPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">iOS managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosManagedAppProtections&quot; property, of type &quot;microsoft.graph.iosManagedAppProtection&quot;.")]
        public System.Object[] iosManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Android managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.androidManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidManagedAppProtections&quot; property, of type &quot;microsoft.graph.androidManagedAppProtection&quot;.")]
        public System.Object[] androidManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Default managed app policies.</para>
        /// </summary>
        [ODataType("microsoft.graph.defaultManagedAppProtection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;defaultManagedAppProtections&quot; property, of type &quot;microsoft.graph.defaultManagedAppProtection&quot;.")]
        public System.Object[] defaultManagedAppProtections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Targeted managed app configurations.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;targetedManagedAppConfigurations&quot; property, of type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.")]
        public System.Object[] targetedManagedAppConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mdmWindowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot;.")]
        public System.Object[] mdmWindowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">Windows information protection for apps running on devices which are not MDM enrolled.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsInformationProtectionPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsInformationProtectionPolicies&quot; property, of type &quot;microsoft.graph.windowsInformationProtectionPolicy&quot;.")]
        public System.Object[] windowsInformationProtectionPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app registrations.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The managed app statuses.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedAppStatuses&quot; property, of type &quot;microsoft.graph.managedAppStatus&quot;.")]
        public System.Object[] managedAppStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceAppManagement&quot; type.</para>
        ///     <para type="description">The Managed eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedEBook")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceAppManagement", HelpMessage = @"The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedEBooks&quot; property, of type &quot;microsoft.graph.managedEBook&quot;.")]
        public System.Object[] managedEBooks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceAppManagement&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement</para>
    ///     <para type="description">Removes the &quot;deviceAppManagement&quot; object (which is of type &quot;microsoft.graph.deviceAppManagement&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceAppManagement")]
    public class Remove_DeviceAppManagement : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/syncMicrosoftStoreForBusinessApps</para>
    ///     <para type="description">The action &quot;microsoft.graph.syncMicrosoftStoreForBusinessApps&quot;, which exists on the type &quot;microsoft.graph.deviceAppManagement&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_SyncMicrosoftStoreForBusinessApps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceAppManagement")]
    public class Invoke_DeviceAppManagement_SyncMicrosoftStoreForBusinessApps : ActionCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/syncMicrosoftStoreForBusinessApps";
        }
    }
}