// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartPoint&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartPoint&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartPointObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartPoint")]
    [ODataType("microsoft.graph.workbookChartPoint")]
    public class New_WorkbookChartPointObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartPoint&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartPoint", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartPointFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartPoint&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartPointFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartPoint", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartPointFormat&quot;.")]
        public System.Object format { get; set; }
    }
}