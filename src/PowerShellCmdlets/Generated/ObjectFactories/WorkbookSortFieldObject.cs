// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookSortField&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookSortField&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookSortFieldObject", DefaultParameterSetName = @"#microsoft.graph.workbookSortField")]
    [ODataType("microsoft.graph.workbookSortField")]
    public class New_WorkbookSortFieldObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;ascending&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;ascending&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ascending { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataOption&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;dataOption&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String dataOption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;icon&quot; property, of type &quot;microsoft.graph.workbookIcon&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookIcon")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;icon&quot; property, of type &quot;microsoft.graph.workbookIcon&quot;.")]
        public System.Object icon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;key&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;key&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 key { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sortOn&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSortField&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookSortField", HelpMessage = @"The &quot;sortOn&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sortOn { get; set; }
    }
}