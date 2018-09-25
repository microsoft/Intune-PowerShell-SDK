// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileAppContent&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileAppContent&quot; objects in the &quot;contentVersions&quot; collection.</para>
    ///     <para type="description">The list of content versions for this app.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_MobileApps_ContentVersions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileAppContent")]
    [ResourceTypePropertyName("contentVersionODataType")]
    [ResourceReference]
    public class Get_DeviceAppManagement_MobileApps_ContentVersions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mobileApp&apos;, &apos;microsoft.graph.iosStoreApp&apos;, &apos;microsoft.graph.iosVppApp&apos;, &apos;microsoft.graph.androidStoreApp&apos;, &apos;microsoft.graph.webApp&apos;, &apos;microsoft.graph.microsoftStoreForBusinessApp&apos;, &apos;microsoft.graph.mobileLobApp&apos;, &apos;microsoft.graph.iosLobApp&apos;, &apos;microsoft.graph.androidLobApp&apos;, &apos;microsoft.graph.windowsUniversalAppX&apos;, &apos;microsoft.graph.windowsMobileMSI&apos;, &apos;microsoft.graph.managedApp&apos;, &apos;microsoft.graph.managedMobileLobApp&apos;, &apos;microsoft.graph.managedIOSLobApp&apos;, &apos;microsoft.graph.managedAndroidLobApp&apos;, &apos;microsoft.graph.managedIOSStoreApp&apos;, &apos;microsoft.graph.managedAndroidStoreApp&apos;, &apos;microsoft.graph.macOSOfficeSuiteApp&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContent&quot; type.</para>
        ///     <para type="description">The list of files for this app content version.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFile")]
        [Selectable]
        [Expandable]
        public System.Object[] files { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mobileAppContent&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mobileAppContent&quot; object to the &quot;contentVersions&quot; collection.</para>
    ///     <para type="description">The list of content versions for this app.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_MobileApps_ContentVersions", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.mobileAppContent")]
    [ODataType("microsoft.graph.mobileAppContent")]
    [ResourceTypePropertyName("contentVersionODataType")]
    [ResourceReference]
    public class New_DeviceAppManagement_MobileApps_ContentVersions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mobileApp&apos;, &apos;microsoft.graph.iosStoreApp&apos;, &apos;microsoft.graph.iosVppApp&apos;, &apos;microsoft.graph.androidStoreApp&apos;, &apos;microsoft.graph.webApp&apos;, &apos;microsoft.graph.microsoftStoreForBusinessApp&apos;, &apos;microsoft.graph.mobileLobApp&apos;, &apos;microsoft.graph.iosLobApp&apos;, &apos;microsoft.graph.androidLobApp&apos;, &apos;microsoft.graph.windowsUniversalAppX&apos;, &apos;microsoft.graph.windowsMobileMSI&apos;, &apos;microsoft.graph.managedApp&apos;, &apos;microsoft.graph.managedMobileLobApp&apos;, &apos;microsoft.graph.managedIOSLobApp&apos;, &apos;microsoft.graph.managedAndroidLobApp&apos;, &apos;microsoft.graph.managedIOSStoreApp&apos;, &apos;microsoft.graph.managedAndroidStoreApp&apos;, &apos;microsoft.graph.macOSOfficeSuiteApp&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContent&quot; type.</para>
        ///     <para type="description">The list of files for this app content version.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.")]
        public System.Object[] files { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mobileAppContent&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
    ///     <para type="description">The list of content versions for this app.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_MobileApps_ContentVersions", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.mobileAppContent")]
    [ODataType("microsoft.graph.mobileAppContent")]
    [ResourceTypePropertyName("contentVersionODataType")]
    public class Update_DeviceAppManagement_MobileApps_ContentVersions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mobileApp&apos;, &apos;microsoft.graph.iosStoreApp&apos;, &apos;microsoft.graph.iosVppApp&apos;, &apos;microsoft.graph.androidStoreApp&apos;, &apos;microsoft.graph.webApp&apos;, &apos;microsoft.graph.microsoftStoreForBusinessApp&apos;, &apos;microsoft.graph.mobileLobApp&apos;, &apos;microsoft.graph.iosLobApp&apos;, &apos;microsoft.graph.androidLobApp&apos;, &apos;microsoft.graph.windowsUniversalAppX&apos;, &apos;microsoft.graph.windowsMobileMSI&apos;, &apos;microsoft.graph.managedApp&apos;, &apos;microsoft.graph.managedMobileLobApp&apos;, &apos;microsoft.graph.managedIOSLobApp&apos;, &apos;microsoft.graph.managedAndroidLobApp&apos;, &apos;microsoft.graph.managedIOSStoreApp&apos;, &apos;microsoft.graph.managedAndroidStoreApp&apos;, &apos;microsoft.graph.macOSOfficeSuiteApp&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContent&quot; type.</para>
        ///     <para type="description">The list of files for this app content version.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFile")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContent", HelpMessage = @"The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.")]
        public System.Object[] files { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mobileAppContent&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/mobileAppContentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mobileAppContent&quot; object from the &quot;contentVersions&quot; collection.</para>
    ///     <para type="description">The list of content versions for this app.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_MobileApps_ContentVersions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppContent")]
    [ResourceTypePropertyName("contentVersionODataType")]
    public class Remove_DeviceAppManagement_MobileApps_ContentVersions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mobileApp&apos;, &apos;microsoft.graph.iosStoreApp&apos;, &apos;microsoft.graph.iosVppApp&apos;, &apos;microsoft.graph.androidStoreApp&apos;, &apos;microsoft.graph.webApp&apos;, &apos;microsoft.graph.microsoftStoreForBusinessApp&apos;, &apos;microsoft.graph.mobileLobApp&apos;, &apos;microsoft.graph.iosLobApp&apos;, &apos;microsoft.graph.androidLobApp&apos;, &apos;microsoft.graph.windowsUniversalAppX&apos;, &apos;microsoft.graph.windowsMobileMSI&apos;, &apos;microsoft.graph.managedApp&apos;, &apos;microsoft.graph.managedMobileLobApp&apos;, &apos;microsoft.graph.managedIOSLobApp&apos;, &apos;microsoft.graph.managedAndroidLobApp&apos;, &apos;microsoft.graph.managedIOSStoreApp&apos;, &apos;microsoft.graph.managedAndroidStoreApp&apos;, &apos;microsoft.graph.macOSOfficeSuiteApp&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}";
        }
    }
}