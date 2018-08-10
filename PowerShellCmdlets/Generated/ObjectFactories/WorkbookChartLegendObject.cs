// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartLegend&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartLegend&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartLegendObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartLegend")]
    [ODataType("microsoft.graph.workbookChartLegend")]
    public class New_WorkbookChartLegendObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;overlay&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartLegend&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartLegend", HelpMessage = @"The &quot;overlay&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean overlay { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartLegend&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartLegend", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartLegend&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartLegend", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartLegendFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartLegend&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLegendFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartLegend", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartLegendFormat&quot;.")]
        public System.Object format { get; set; }
    }
}