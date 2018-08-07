// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenoteEntityBaseModel&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenoteEntityBaseModel&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenoteEntityBaseModelObject", DefaultParameterSetName = @"#microsoft.graph.onenoteEntityBaseModel")]
    [ODataType("microsoft.graph.onenoteEntityBaseModel")]
    public class New_OnenoteEntityBaseModelObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteEntityBaseModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityBaseModel", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntitySchemaObjectModel", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.onenoteResource")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteResource&quot; type.")]
        public System.Management.Automation.SwitchParameter onenoteResource { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteEntitySchemaObjectModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntitySchemaObjectModel", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.onenotePage")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenotePage&quot; type.")]
        public System.Management.Automation.SwitchParameter onenotePage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;createdByAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String createdByAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebookLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.pageLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;level&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 level { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;order&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;userTags&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] userTags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentSection&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object parentSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePage&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePage", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteEntityHierarchyModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteEntityHierarchyModel&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteEntityHierarchyModel&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteEntityHierarchyModel", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.sectionGroup")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.sectionGroup&quot; type.")]
        public System.Management.Automation.SwitchParameter sectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sectionGroup", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.onenoteSection")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteSection&quot; type.")]
        public System.Management.Automation.SwitchParameter onenoteSection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String pagesUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.notebook")]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.notebook&quot; type.")]
        public System.Management.Automation.SwitchParameter notebook { get; set; }

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
        public System.String userRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.notebook", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isShared { get; set; }
    }
}