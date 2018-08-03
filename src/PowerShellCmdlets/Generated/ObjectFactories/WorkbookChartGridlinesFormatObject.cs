// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartGridlinesFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartGridlinesFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartGridlinesFormatObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartGridlinesFormat")]
    [ODataType("microsoft.graph.workbookChartGridlinesFormat")]
    public class New_WorkbookChartGridlinesFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartGridlinesFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLineFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartGridlinesFormat", HelpMessage = @"The &quot;line&quot; property, of type &quot;microsoft.graph.workbookChartLineFormat&quot;.")]
        public System.Object Line { get; set; }
    }
}