// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookTableColumn&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookTableColumn&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookTableColumnObject", DefaultParameterSetName = @"microsoft.graph.workbookTableColumn")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    public class New_WorkbookTableColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFilter")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.")]
        public System.Object filter { get; set; }
    }
}