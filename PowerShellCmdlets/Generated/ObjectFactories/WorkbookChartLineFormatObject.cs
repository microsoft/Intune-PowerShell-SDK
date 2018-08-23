// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartLineFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartLineFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartLineFormatObject", DefaultParameterSetName = @"microsoft.graph.workbookChartLineFormat")]
    [ODataType("microsoft.graph.workbookChartLineFormat")]
    public class New_WorkbookChartLineFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartLineFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartLineFormat", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }
    }
}