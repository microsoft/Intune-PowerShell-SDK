// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartSeries&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartSeries&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartSeriesObject", DefaultParameterSetName = @"microsoft.graph.workbookChartSeries")]
    [ODataType("microsoft.graph.workbookChartSeries")]
    public class New_WorkbookChartSeriesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartSeries&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartSeries", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartSeriesFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartSeries&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartSeriesFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartSeries", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartSeriesFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;points&quot; property, of type &quot;microsoft.graph.workbookChartPoint&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartSeries&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartPoint")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartSeries", HelpMessage = @"The &quot;points&quot; property, of type &quot;microsoft.graph.workbookChartPoint&quot;.")]
        public System.Object[] points { get; set; }
    }
}