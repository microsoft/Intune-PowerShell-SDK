// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.contentType&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.contentType&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ContentTypeObject", DefaultParameterSetName = @"#microsoft.graph.contentType")]
    [ODataType("microsoft.graph.contentType")]
    public class New_ContentTypeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;group&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;group&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object InheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeOrder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.")]
        public System.Object Order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ParentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ReadOnly { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Sealed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnLink")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.")]
        public System.Object[] ColumnLinks { get; set; }
    }
}