// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.driveItem&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/drive/root/children</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.driveItem&quot; objects in the &quot;children&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List_Drive_Root_Children", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    [ResourceReference]
    public class Get_Me_Drives_List_Drive_Root_Children : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.audio")]
        [Selectable]
        [Sortable]
        public System.Object audio { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Sortable]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String cTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deleted")]
        [Selectable]
        [Sortable]
        public System.Object deleted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.file")]
        [Selectable]
        [Sortable]
        public System.Object file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Sortable]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folder")]
        [Selectable]
        [Sortable]
        public System.Object folder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.image")]
        [Selectable]
        [Sortable]
        public System.Object image { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.geoCoordinates")]
        [Selectable]
        [Sortable]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.package")]
        [Selectable]
        [Sortable]
        public System.Object package { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.photo")]
        [Selectable]
        [Sortable]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Sortable]
        public System.Object publication { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteItem")]
        [Selectable]
        [Sortable]
        public System.Object remoteItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.root")]
        [Selectable]
        [Sortable]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.searchResult")]
        [Selectable]
        [Sortable]
        public System.Object searchResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.shared")]
        [Selectable]
        [Sortable]
        public System.Object shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Sortable]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.specialFolder")]
        [Selectable]
        [Sortable]
        public System.Object specialFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.video")]
        [Selectable]
        [Sortable]
        public System.Object video { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webDavUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        public System.Object[] children { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object listItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.permission")]
        [Selectable]
        [Expandable]
        public System.Object[] permissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnailSet")]
        [Selectable]
        [Expandable]
        public System.Object[] thumbnails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItemVersion")]
        [Selectable]
        [Expandable]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbook")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object workbook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.driveItem&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/children</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.driveItem&quot; object to the &quot;children&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List_Drive_Root_Children", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.driveItem")]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceReference]
    public class New_Me_Drives_List_Drive_Root_Children : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.audio")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.")]
        public System.Object audio { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String cTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deleted")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.")]
        public System.Object deleted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.file")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        public System.Object file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        public System.Object folder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.image")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.")]
        public System.Object image { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.geoCoordinates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.package")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        public System.Object package { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.photo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.")]
        public System.Object remoteItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.root")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.")]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.searchResult")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.")]
        public System.Object searchResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.shared")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        public System.Object shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.specialFolder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        public System.Object specialFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.video")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.")]
        public System.Object video { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webDavUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] children { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        public System.Object listItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.permission")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.")]
        public System.Object[] permissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnailSet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.")]
        public System.Object[] thumbnails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItemVersion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.")]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.")]
        public System.Object workbook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list/drive/root/children</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List_Drive_Root_Children", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.driveItem")]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Update_Me_Drives_List_Drive_Root_Children : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.audio")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.")]
        public System.Object audio { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String cTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deleted")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.")]
        public System.Object deleted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.file")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        public System.Object file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        public System.Object folder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.image")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.")]
        public System.Object image { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.geoCoordinates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.package")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        public System.Object package { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.photo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.")]
        public System.Object remoteItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.root")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.")]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.searchResult")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.")]
        public System.Object searchResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.shared")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        public System.Object shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.specialFolder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        public System.Object specialFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.video")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.")]
        public System.Object video { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webDavUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] children { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        public System.Object listItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.permission")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.")]
        public System.Object[] permissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnailSet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.")]
        public System.Object[] thumbnails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItemVersion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.driveItemVersion&quot;.")]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.")]
        public System.Object workbook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.driveItem&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list/drive/root/children/childId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.driveItem&quot; object from the &quot;children&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List_Drive_Root_Children", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Remove_Me_Drives_List_Drive_Root_Children : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/children/copy</para>
    ///     <para type="description">The action &quot;microsoft.graph.copy&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.driveItem&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_Copy", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_Copy : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;parentReference&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/copy";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/children/createLink</para>
    ///     <para type="description">The action &quot;microsoft.graph.createLink&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.permission&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_CreateLink", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_CreateLink : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.createLink&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.createLink&quot; action.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; parameter, which is accepted by the &quot;microsoft.graph.createLink&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;scope&quot; parameter, which is accepted by the &quot;microsoft.graph.createLink&quot; action.")]
        public System.String scope { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/createLink";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/children/createUploadSession</para>
    ///     <para type="description">The action &quot;microsoft.graph.createUploadSession&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.uploadSession&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_CreateUploadSession", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_CreateUploadSession : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;item&quot; parameter, which is accepted by the &quot;microsoft.graph.createUploadSession&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItemUploadableProperties")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;item&quot; parameter, which is accepted by the &quot;microsoft.graph.createUploadSession&quot; action.")]
        public System.Object item { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/createUploadSession";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/children/invite</para>
    ///     <para type="description">The action &quot;microsoft.graph.invite&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;microsoft.graph.permission&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_Invite", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_Invite : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;requireSignIn&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;requireSignIn&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.")]
        public System.Boolean requireSignIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roles&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;roles&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.")]
        public System.String[] roles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sendInvitation&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sendInvitation&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.")]
        public System.Boolean sendInvitation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;message&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;message&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.")]
        public System.String message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recipients&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveRecipient")]
        [Selectable]
        [ValidateNotNull]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;recipients&quot; parameter, which is accepted by the &quot;microsoft.graph.invite&quot; action.")]
        public System.Object[] recipients { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/invite";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/drive/root/children/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.driveItem&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_Delta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;token&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;token&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; function.")]
        public System.String token { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/delta({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/drive/root/children/search</para>
    ///     <para type="description">The function &quot;microsoft.graph.search&quot;, which exists on the type &quot;microsoft.graph.driveItem&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.driveItem&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Children_Search", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.driveItem")]
    [ResourceIdPropertyName("childId")]
    public class Invoke_Me_Drives_List_Drive_Root_Children_Search : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;q&quot; parameter, which is accepted by the &quot;microsoft.graph.search&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;q&quot; parameter, which is accepted by the &quot;microsoft.graph.search&quot; function.")]
        public System.String q { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/children/{childId}/search({this.GetFunctionUrlSegment()})";
        }
    }
}