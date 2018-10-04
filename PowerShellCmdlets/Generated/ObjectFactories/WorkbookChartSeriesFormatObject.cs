// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartSeriesFormat&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartSeriesFormat&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartSeriesFormatObject", DefaultParameterSetName = @"microsoft.graph.workbookChartSeriesFormat")]
    [ODataType("microsoft.graph.workbookChartSeriesFormat")]
    public class New_WorkbookChartSeriesFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartSeriesFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFill")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartSeriesFormat", HelpMessage = @"The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.")]
        public System.Object fill { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartSeriesFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLineFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartSeriesFormat", HelpMessage = @"The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.")]
        public System.Object line { get; set; }
    }
}