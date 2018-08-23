// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileAppContentFile&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileAppContentFile&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Contains properties for a single installer file that is associated with a given mobileAppContent version.</para>
    /// </summary>
    [Cmdlet("New", "MobileAppContentFileObject", DefaultParameterSetName = @"microsoft.graph.mobileAppContentFile")]
    [ODataType("microsoft.graph.mobileAppContentFile")]
    public class New_MobileAppContentFileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The Azure Storage URI.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;azureStorageUri&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureStorageUri { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">A value indicating whether the file is committed.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;isCommitted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isCommitted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the file was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">the file name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file prior to encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The size of the file after encryption.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;sizeEncrypted&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 sizeEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContentFile&quot; type.</para>
        ///     <para type="description">The time the Azure storage Uri expires.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContentFile", HelpMessage = @"The &quot;azureStorageUriExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
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
        public System.String uploadState { get; set; }
    }
}