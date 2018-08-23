// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRange&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRange&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeObject", DefaultParameterSetName = @"microsoft.graph.workbookRange")]
    [ODataType("microsoft.graph.workbookRange")]
    public class New_WorkbookRangeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;address&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;addressLocal&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;addressLocal&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String addressLocal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cellCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;cellCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 cellCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 columnCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnHidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnHidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean columnHidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnIndex&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;columnIndex&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 columnIndex { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulas { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulasLocal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulasR1C1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object numberFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 rowCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowHidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowHidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean rowHidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowIndex&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;rowIndex&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 rowIndex { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object valueTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookRangeFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookRangeFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookRangeSort&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeSort")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;sort&quot; property, of type &quot;microsoft.graph.workbookRangeSort&quot;.")]
        public System.Object sort { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRange&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRange", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }
    }
}