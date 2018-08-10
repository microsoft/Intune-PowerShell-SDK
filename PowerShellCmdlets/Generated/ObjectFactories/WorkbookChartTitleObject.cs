// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartTitle&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartTitle&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartTitleObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartTitle")]
    [ODataType("microsoft.graph.workbookChartTitle")]
    public class New_WorkbookChartTitleObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;overlay&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartTitle&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartTitle", HelpMessage = @"The &quot;overlay&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean overlay { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartTitle&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartTitle", HelpMessage = @"The &quot;text&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartTitle&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartTitle", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartTitleFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartTitle&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartTitleFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartTitle", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartTitleFormat&quot;.")]
        public System.Object format { get; set; }
    }
}