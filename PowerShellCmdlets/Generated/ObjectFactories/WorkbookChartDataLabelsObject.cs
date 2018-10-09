// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartDataLabels&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartDataLabels&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartDataLabelsObject", DefaultParameterSetName = @"microsoft.graph.workbookChartDataLabels")]
    [ODataType("microsoft.graph.workbookChartDataLabels")]
    public class New_WorkbookChartDataLabelsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;separator&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;separator&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String separator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showBubbleSize&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showBubbleSize&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showBubbleSize { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showCategoryName&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showCategoryName&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showCategoryName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showLegendKey&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showLegendKey&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showLegendKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showPercentage&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showPercentage&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showPercentage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showSeriesName&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showSeriesName&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showSeriesName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showValue&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;showValue&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartDataLabelFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabels&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartDataLabelFormat")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabels", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartDataLabelFormat&quot;.")]
        public System.Object format { get; set; }
    }
}