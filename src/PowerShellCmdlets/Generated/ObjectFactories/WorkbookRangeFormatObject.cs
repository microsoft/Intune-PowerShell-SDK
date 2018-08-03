// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeFormatObject", DefaultParameterSetName = @"#microsoft.graph.workbookRangeFormat")]
    [ODataType("microsoft.graph.workbookRangeFormat")]
    public class New_WorkbookRangeFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;columnWidth&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;columnWidth&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double ColumnWidth { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;horizontalAlignment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;horizontalAlignment&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String HorizontalAlignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowHeight&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;rowHeight&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double RowHeight { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verticalAlignment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;verticalAlignment&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String VerticalAlignment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wrapText&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;wrapText&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean WrapText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;borders&quot; property, of type &quot;microsoft.graph.workbookRangeBorder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeBorder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;borders&quot; property, of type &quot;microsoft.graph.workbookRangeBorder&quot;.")]
        public System.Object[] Borders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookRangeFill&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeFill")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookRangeFill&quot;.")]
        public System.Object Fill { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;font&quot; property, of type &quot;microsoft.graph.workbookRangeFont&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeFont")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;font&quot; property, of type &quot;microsoft.graph.workbookRangeFont&quot;.")]
        public System.Object Font { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookFormatProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFormatProtection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFormat", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookFormatProtection&quot;.")]
        public System.Object Protection { get; set; }
    }
}