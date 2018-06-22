// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxisFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxisFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartAxisFormatObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartAxisFormat")]
    [ODataType("microsoft.graph.workbookChartAxisFormat")]
    public class New_WorkbookChartAxisFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxisFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFont")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartAxisFormat", HelpMessage = @"The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.")]
        public System.Object font { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxisFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLineFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartAxisFormat", HelpMessage = @"The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.")]
        public System.Object line { get; set; }
    }
}