// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRangeView&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRangeView&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeViewObject", DefaultParameterSetName = @"microsoft.graph.workbookRangeView")]
    [ODataType("microsoft.graph.workbookRangeView")]
    public class New_WorkbookRangeViewObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;cellAddresses&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;cellAddresses&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object cellAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;columnCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 columnCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;formulas&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulas { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;formulasLocal&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulasLocal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;formulasR1C1&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object formulasR1C1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;numberFormat&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object numberFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;rowCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 rowCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;text&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;valueTypes&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object valueTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookRangeView&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeView&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookRangeView")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeView", HelpMessage = @"The &quot;rows&quot; property, of type &quot;microsoft.graph.workbookRangeView&quot;.")]
        public System.Object[] rows { get; set; }
    }
}