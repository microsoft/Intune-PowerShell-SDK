// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookWorksheetProtectionOptionsObject", DefaultParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions")]
    [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
    public class New_WorkbookWorksheetProtectionOptionsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowAutoFilter&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowAutoFilter&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowAutoFilter { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowDeleteColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowDeleteColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowDeleteColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowDeleteRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowDeleteRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowDeleteRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowFormatCells&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowFormatCells&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowFormatCells { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowFormatColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowFormatColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowFormatColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowFormatRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowFormatRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowFormatRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowInsertColumns&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowInsertColumns&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowInsertColumns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowInsertHyperlinks&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowInsertHyperlinks&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowInsertHyperlinks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowInsertRows&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowInsertRows&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowInsertRows { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowPivotTables&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowPivotTables&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowPivotTables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowSort&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookWorksheetProtectionOptions", HelpMessage = @"The &quot;allowSort&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowSort { get; set; }
    }
}