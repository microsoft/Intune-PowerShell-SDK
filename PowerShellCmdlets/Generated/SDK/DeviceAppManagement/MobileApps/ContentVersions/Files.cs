// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileAppContentFile&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileAppContentFile&quot; objects in the &quot;files&quot; collection.</para>
    ///     <para type="description">The list of files for this app content version.</para>
    ///     <para type="description">Graph call: GET ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceAppManagement_MobileApps_ContentVersions_Files", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [ResourceReference]
    [Alias("Get-IntuneMobileAppContentVersionFile")]
    public class Get_DeviceAppManagement_MobileApps_ContentVersions_Files : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.")]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The Azure Storage URI.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String azureStorageUri { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">A value indicating whether the file is committed.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isCommitted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the file was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">the file name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file prior to encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file after encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 sizeEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the Azure storage Uri expires.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset azureStorageUriExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The manifest information.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        public System.Byte[] manifest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The state of the current upload request.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFileUploadState")]
        [Selectable]
        [Sortable]
        public System.String uploadState { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mobileAppContentFile&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mobileAppContentFile&quot; object to the &quot;files&quot; collection.</para>
    ///     <para type="description">The list of files for this app content version.</para>
    ///     <para type="description">Graph call: POST ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceAppManagement_MobileApps_ContentVersions_Files", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.mobileAppContentFile")]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [ResourceReference]
    [Alias("New-IntuneMobileAppContentVersionFile")]
    public class New_DeviceAppManagement_MobileApps_ContentVersions_Files : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The Azure Storage URI.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureStorageUri { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">A value indicating whether the file is committed.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isCommitted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the file was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">the file name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file prior to encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file after encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 sizeEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the Azure storage Uri expires.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset azureStorageUriExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The manifest information.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] manifest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The state of the current upload request.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;transientError&apos;, &apos;error&apos;, &apos;unknown&apos;, &apos;azureStorageUriRequestSuccess&apos;, &apos;azureStorageUriRequestPending&apos;, &apos;azureStorageUriRequestFailed&apos;, &apos;azureStorageUriRequestTimedOut&apos;, &apos;azureStorageUriRenewalSuccess&apos;, &apos;azureStorageUriRenewalPending&apos;, &apos;azureStorageUriRenewalFailed&apos;, &apos;azureStorageUriRenewalTimedOut&apos;, &apos;commitFileSuccess&apos;, &apos;commitFilePending&apos;, &apos;commitFileFailed&apos;, &apos;commitFileTimedOut&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFileUploadState")]
        [Selectable]
        [ValidateSet(@"success", @"transientError", @"error", @"unknown", @"azureStorageUriRequestSuccess", @"azureStorageUriRequestPending", @"azureStorageUriRequestFailed", @"azureStorageUriRequestTimedOut", @"azureStorageUriRenewalSuccess", @"azureStorageUriRenewalPending", @"azureStorageUriRenewalFailed", @"azureStorageUriRenewalTimedOut", @"commitFileSuccess", @"commitFilePending", @"commitFileFailed", @"commitFileTimedOut")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.")]
        public System.String uploadState { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
    ///     <para type="description">The list of files for this app content version.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceAppManagement_MobileApps_ContentVersions_Files", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.mobileAppContentFile")]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [Alias("Update-IntuneMobileAppContentVersionFile")]
    public class Update_DeviceAppManagement_MobileApps_ContentVersions_Files : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.")]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The Azure Storage URI.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureStorageUri { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">A value indicating whether the file is committed.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isCommitted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the file was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">the file name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file prior to encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file after encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 sizeEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the Azure storage Uri expires.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset azureStorageUriExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The manifest information.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;manifest&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] manifest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The state of the current upload request.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;transientError&apos;, &apos;error&apos;, &apos;unknown&apos;, &apos;azureStorageUriRequestSuccess&apos;, &apos;azureStorageUriRequestPending&apos;, &apos;azureStorageUriRequestFailed&apos;, &apos;azureStorageUriRequestTimedOut&apos;, &apos;azureStorageUriRenewalSuccess&apos;, &apos;azureStorageUriRenewalPending&apos;, &apos;azureStorageUriRenewalFailed&apos;, &apos;azureStorageUriRenewalTimedOut&apos;, &apos;commitFileSuccess&apos;, &apos;commitFilePending&apos;, &apos;commitFileFailed&apos;, &apos;commitFileTimedOut&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFileUploadState")]
        [Selectable]
        [ValidateSet(@"success", @"transientError", @"error", @"unknown", @"azureStorageUriRequestSuccess", @"azureStorageUriRequestPending", @"azureStorageUriRequestFailed", @"azureStorageUriRequestTimedOut", @"azureStorageUriRenewalSuccess", @"azureStorageUriRenewalPending", @"azureStorageUriRenewalFailed", @"azureStorageUriRenewalTimedOut", @"commitFileSuccess", @"commitFilePending", @"commitFileFailed", @"commitFileTimedOut")]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;uploadState&quot; property, of type &quot;microsoft.graph.mobileAppContentFileUploadState&quot;.")]
        public System.String uploadState { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mobileAppContentFile&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mobileAppContentFile&quot; object from the &quot;files&quot; collection.</para>
    ///     <para type="description">The list of files for this app content version.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/mobileAppContentFileId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceAppManagement_MobileApps_ContentVersions_Files", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [Alias("Remove-IntuneMobileAppContentVersionFile")]
    public class Remove_DeviceAppManagement_MobileApps_ContentVersions_Files : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.")]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId}";
        }
    }

    /// <summary>
    ///     <para type="description">The action &quot;microsoft.graph.commit&quot;, which exists on the type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    ///     <para type="description">Graph Call: POST ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/commit</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceAppManagement_MobileApps_ContentVersions_Files_Commit", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [Alias("Invoke-IntuneMobileAppContentVersionFileCommit")]
    public class Invoke_DeviceAppManagement_MobileApps_ContentVersions_Files_Commit : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;fileEncryptionInfo&quot; action parameter of type &quot;microsoft.graph.fileEncryptionInfo&quot;.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileEncryptionInfo")]
        [Selectable]
        [Expandable]
        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fileEncryptionInfo&quot; action parameter of type &quot;microsoft.graph.fileEncryptionInfo&quot;.")]
        public System.Object fileEncryptionInfo { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.")]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId}/commit";
        }
    }

    /// <summary>
    ///     <para type="description">The action &quot;microsoft.graph.renewUpload&quot;, which exists on the type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    ///     <para type="description">Graph Call: POST ~/deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/renewUpload</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "DeviceAppManagement_MobileApps_ContentVersions_Files_RenewUpload", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    [ResourceTypePropertyName("fileODataType")]
    [Alias("Invoke-IntuneMobileAppContentVersionRenewUpload")]
    public class Invoke_DeviceAppManagement_MobileApps_ContentVersions_Files_RenewUpload : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppContentFile&quot; object in the &quot;files&quot; collection.")]
        public System.String mobileAppContentFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
        [Expandable]
        [ValidateSet(@"microsoft.graph.mobileApp", @"microsoft.graph.iosStoreApp", @"microsoft.graph.iosVppApp", @"microsoft.graph.androidStoreApp", @"microsoft.graph.webApp", @"microsoft.graph.microsoftStoreForBusinessApp", @"microsoft.graph.mobileLobApp", @"microsoft.graph.iosLobApp", @"microsoft.graph.androidLobApp", @"microsoft.graph.windowsUniversalAppX", @"microsoft.graph.windowsMobileMSI", @"microsoft.graph.managedApp", @"microsoft.graph.managedMobileLobApp", @"microsoft.graph.managedIOSLobApp", @"microsoft.graph.managedAndroidLobApp", @"microsoft.graph.managedIOSStoreApp", @"microsoft.graph.managedAndroidStoreApp", @"microsoft.graph.macOSOfficeSuiteApp")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mobileApp&quot; objects.")]
        public System.String mobileAppODataType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileAppContent&quot; object in the &quot;contentVersions&quot; collection.")]
        public System.String mobileAppContentId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/{mobileAppODataType}/contentVersions/{mobileAppContentId}/files/{mobileAppContentFileId}/renewUpload";
        }
    }
}