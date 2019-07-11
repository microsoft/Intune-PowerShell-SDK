// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.CopyNotebookModel&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.CopyNotebookModel&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "CopyNotebookModelObject", DefaultParameterSetName = @"microsoft.graph.CopyNotebookModel")]
    [ODataType("microsoft.graph.CopyNotebookModel")]
    public class New_CopyNotebookModelObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;Owner&apos;, &apos;Contributor&apos;, &apos;Reader&apos;, &apos;None&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteUserRole")]
        [Selectable]
        [ValidateSet(@"Owner", @"Contributor", @"Reader", @"None")]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;userRole&quot; property, of type &quot;microsoft.graph.onenoteUserRole&quot;.")]
        public System.String userRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;isShared&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isShared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;sectionsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;sectionGroupsUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sectionGroupsUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebookLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.notebookLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByIdentity&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;createdByIdentity&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdByIdentity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByIdentity&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;lastModifiedByIdentity&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedByIdentity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;lastModifiedTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.CopyNotebookModel&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.CopyNotebookModel", HelpMessage = @"The &quot;createdTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdTime { get; set; }
    }
}