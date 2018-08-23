// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartGridlines&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartGridlines&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartGridlinesObject", DefaultParameterSetName = @"microsoft.graph.workbookChartGridlines")]
    [ODataType("microsoft.graph.workbookChartGridlines")]
    public class New_WorkbookChartGridlinesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartGridlines&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartGridlines", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartGridlinesFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartGridlines&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartGridlinesFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartGridlines", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartGridlinesFormat&quot;.")]
        public System.Object format { get; set; }
    }
}