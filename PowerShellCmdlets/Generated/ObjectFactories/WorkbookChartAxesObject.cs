// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxes&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxes&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartAxesObject", DefaultParameterSetName = @"microsoft.graph.workbookChartAxes")]
    [ODataType("microsoft.graph.workbookChartAxes")]
    public class New_WorkbookChartAxesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;categoryAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxes&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxis")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxes", HelpMessage = @"The &quot;categoryAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.")]
        public System.Object categoryAxis { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seriesAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxes&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxis")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxes", HelpMessage = @"The &quot;seriesAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.")]
        public System.Object seriesAxis { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxes&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxis")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxes", HelpMessage = @"The &quot;valueAxis&quot; property, of type &quot;microsoft.graph.workbookChartAxis&quot;.")]
        public System.Object valueAxis { get; set; }
    }
}