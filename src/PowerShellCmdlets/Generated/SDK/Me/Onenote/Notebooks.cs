// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.notebook&quot; objects.</para>
    ///     <para type="description">GET ~/me/onenote/notebooks</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.notebook&quot; objects in the &quot;notebooks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_Notebooks", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.notebook")]
    [ResourceIdPropertyName("notebookId")]
    [ResourceReference]
    public class Get_Me_Onenote_Notebooks : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteUserRole")]
        [Selectable]
        [Sortable]
        public System.String userRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isShared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebookLinks")]
        [Selectable]
        [Sortable]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.notebook&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/notebooks</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.notebook&quot; object to the &quot;notebooks&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_Notebooks", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.notebook")]
    [ODataType("microsoft.graph.notebook")]
    [ResourceReference]
    public class New_Me_Onenote_Notebooks : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;Owner&apos;, &apos;Contributor&apos;, &apos;Reader&apos;, &apos;None&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteUserRole")]
        [Selectable]
        [ValidateSet(@"Owner", @"Contributor", @"Reader", @"None")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.")]
        public System.String userRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isShared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebookLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.notebook&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/notebooks</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_Notebooks", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.notebook")]
    [ODataType("microsoft.graph.notebook")]
    [ResourceIdPropertyName("notebookId")]
    public class Update_Me_Onenote_Notebooks : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;Owner&apos;, &apos;Contributor&apos;, &apos;Reader&apos;, &apos;None&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteUserRole")]
        [Selectable]
        [ValidateSet(@"Owner", @"Contributor", @"Reader", @"None")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.")]
        public System.String userRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isShared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebookLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.notebook&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/notebooks/notebookId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.notebook&quot; object from the &quot;notebooks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_Notebooks", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.notebook")]
    [ResourceIdPropertyName("notebookId")]
    public class Remove_Me_Onenote_Notebooks : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/onenote/notebooks/copyNotebook</para>
    ///     <para type="description">The action &quot;microsoft.graph.copyNotebook&quot;, which exists on the type &quot;microsoft.graph.notebook&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_Notebooks_CopyNotebook", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.notebook")]
    [ResourceIdPropertyName("notebookId")]
    public class Invoke_Me_Onenote_Notebooks_CopyNotebook : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.")]
        public System.String renameAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notebookFolder&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notebookFolder&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.")]
        public System.String notebookFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.")]
        public System.String siteCollectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyNotebook&quot; action.")]
        public System.String siteId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/copyNotebook";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/onenote/notebooks/getRecentNotebooks</para>
    ///     <para type="description">The function &quot;microsoft.graph.getRecentNotebooks&quot;, which exists on the type &quot;microsoft.graph.notebook&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.recentNotebook&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_Notebooks_GetRecentNotebooks", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.notebook")]
    public class Invoke_Me_Onenote_Notebooks_GetRecentNotebooks : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;includePersonalNotebooks&quot; parameter, which is accepted by the &quot;microsoft.graph.getRecentNotebooks&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;includePersonalNotebooks&quot; parameter, which is accepted by the &quot;microsoft.graph.getRecentNotebooks&quot; function.")]
        public System.Boolean includePersonalNotebooks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/getRecentNotebooks({this.GetFunctionUrlSegment()})";
        }
    }
}