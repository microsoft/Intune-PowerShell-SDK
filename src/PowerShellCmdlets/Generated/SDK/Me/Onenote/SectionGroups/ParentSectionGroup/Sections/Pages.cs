// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.onenotePage&quot; objects.</para>
    ///     <para type="description">GET ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.onenotePage&quot; objects in the &quot;pages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    [ResourceReference]
    public class Get_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String createdByAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.pageLinks")]
        [Selectable]
        [Sortable]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Sortable]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] userTags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onenotePage&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.onenotePage&quot; object to the &quot;pages&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.onenotePage")]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceReference]
    public class New_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String createdByAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.pageLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] userTags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object parentSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onenotePage&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.onenotePage")]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Update_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String createdByAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.pageLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] userTags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object parentSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onenotePage&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/pageId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.onenotePage&quot; object from the &quot;pages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Remove_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/onenotePatchContent</para>
    ///     <para type="description">The action &quot;microsoft.graph.onenotePatchContent&quot;, which exists on the type &quot;microsoft.graph.onenotePage&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_OnenotePatchContent", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Invoke_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_OnenotePatchContent : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;commands&quot; parameter, which is accepted by the &quot;microsoft.graph.onenotePatchContent&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePatchContentCommand")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;commands&quot; parameter, which is accepted by the &quot;microsoft.graph.onenotePatchContent&quot; action.")]
        public System.Object[] commands { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/onenotePatchContent";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/copyToSection</para>
    ///     <para type="description">The action &quot;microsoft.graph.copyToSection&quot;, which exists on the type &quot;microsoft.graph.onenotePage&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_CopyToSection", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Invoke_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_CopyToSection : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.")]
        public System.String id { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.")]
        public System.String siteCollectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSection&quot; action.")]
        public System.String siteId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/copyToSection";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/preview</para>
    ///     <para type="description">The function &quot;microsoft.graph.preview&quot;, which exists on the type &quot;microsoft.graph.onenotePage&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.onenotePagePreview&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_Preview", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Invoke_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_Pages_Preview : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/preview({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;pages&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/$value</para>
    ///     <para type="description">Retrieves the data streams from the &quot;pages&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData")]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Get_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String createdByAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.pageLinks")]
        [Selectable]
        [Sortable]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Sortable]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] userTags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;page&quot; property.</para>
    ///     <para type="description">PUT ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/$value</para>
    ///     <para type="description">Sets the data for the &quot;page&quot; property.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class New_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;page&quot; property.</para>
    ///     <para type="description">PUT ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/$value</para>
    ///     <para type="description">Sets the data for the &quot;page&quot; property.</para>
    /// </summary>
    [Cmdlet("Set", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Set_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;page&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/pageId/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;page&quot; resource (which is of type &quot;microsoft.graph.onenotePage&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenotePage")]
    [ResourceIdPropertyName("pageId")]
    public class Remove_Me_Onenote_SectionGroups_ParentSectionGroup_Sections_PagesData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.sectionGroup&quot; object in the &quot;sectionGroups&quot; collection.")]
        public System.String sectionGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sectionGroups/{sectionGroupId}/parentSectionGroup/sections/{sectionId}/pages/{pageId}/$value";
        }
    }
}