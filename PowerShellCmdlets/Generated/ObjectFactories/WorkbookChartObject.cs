// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChart&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChart&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartObject", DefaultParameterSetName = @"#microsoft.graph.workbookChart")]
    [ODataType("microsoft.graph.workbookChart")]
    public class New_WorkbookChartObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;left&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;left&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double left { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;top&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;top&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double top { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double width { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxes")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.")]
        public System.Object axes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartDataLabels")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.")]
        public System.Object dataLabels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAreaFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLegend")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.")]
        public System.Object legend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartSeries")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.")]
        public System.Object[] series { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartTitle")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.")]
        public System.Object title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }
    }
}