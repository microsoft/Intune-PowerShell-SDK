// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;parentSectionGroup&quot; object.</para>
    ///     <para type="description">GET ~/me/onenote/sections/{sectionId}/parentSectionGroup</para>
    ///     <para type="description">Retrieves the &quot;parentSectionGroup&quot; object (which is of type &quot;microsoft.graph.sectionGroup&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_Sections_ParentSectionGroup", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.sectionGroup")]
    [ResourceReference]
    public class Get_Me_Onenote_Sections_ParentSectionGroup : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sections/{sectionId}/parentSectionGroup";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.sectionGroup&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/sections/{sectionId}/parentSectionGroup</para>
    ///     <para type="description">Creates the &quot;parentSectionGroup&quot; object (which is of type &quot;microsoft.graph.sectionGroup&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_Sections_ParentSectionGroup", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.sectionGroup")]
    [ODataType("microsoft.graph.sectionGroup")]
    [ResourceReference]
    public class New_Me_Onenote_Sections_ParentSectionGroup : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sections/{sectionId}/parentSectionGroup";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.sectionGroup&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/sections/{sectionId}/parentSectionGroup</para>
    ///     <para type="description">Updates the &quot;parentSectionGroup&quot; object (which is of type &quot;microsoft.graph.sectionGroup&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_Sections_ParentSectionGroup", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.sectionGroup")]
    [ODataType("microsoft.graph.sectionGroup")]
    public class Update_Me_Onenote_Sections_ParentSectionGroup : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sections/{sectionId}/parentSectionGroup";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.sectionGroup&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/sections/{sectionId}/parentSectionGroup</para>
    ///     <para type="description">Removes the &quot;parentSectionGroup&quot; object (which is of type &quot;microsoft.graph.sectionGroup&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_Sections_ParentSectionGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.sectionGroup")]
    public class Remove_Me_Onenote_Sections_ParentSectionGroup : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/sections/{sectionId}/parentSectionGroup";
        }
    }
}