// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookTable&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookTable&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookTableObject", DefaultParameterSetName = @"microsoft.graph.workbookTable")]
    [ODataType("microsoft.graph.workbookTable")]
    public class New_WorkbookTableObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightFirstColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightFirstColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;highlightLastColumn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean highlightLastColumn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legacyId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;legacyId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String legacyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;showBandedRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBandedRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;showFilterButton&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showFilterButton { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;showHeaders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;showTotals&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showTotals { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;style&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String style { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableColumn")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.workbookTableColumn&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableRow")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookTableRow&quot;.")]
        public System.Object[] rows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTableSort")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookTableSort&quot;.")]
        public System.Object sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTable", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }
    }
}