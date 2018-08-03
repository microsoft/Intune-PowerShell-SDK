// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRange&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRange&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeObject", DefaultParameterSetName = @"#microsoft.graph.workbookRange")]
    [ODataType("microsoft.graph.workbookRange")]
    public class New_WorkbookRangeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;address&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;addressLocal&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;addressLocal&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AddressLocal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cellCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;cellCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CellCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ColumnCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnHidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnHidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ColumnHidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnIndex&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnIndex&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ColumnIndex { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object Formulas { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object FormulasLocal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object FormulasR1C1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object NumberFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RowCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowHidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowHidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RowHidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowIndex&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowIndex&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RowIndex { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object Text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object ValueTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object Values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookRangeFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookRangeFormat&quot;.")]
        public System.Object Format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookRangeSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeSort")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookRangeSort&quot;.")]
        public System.Object Sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRange", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object Worksheet { get; set; }
    }
}