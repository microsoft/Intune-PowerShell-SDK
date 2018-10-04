// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxis&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartAxis&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartAxisObject", DefaultParameterSetName = @"microsoft.graph.workbookChartAxis")]
    [ODataType("microsoft.graph.workbookChartAxis")]
    public class New_WorkbookChartAxisObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;majorUnit&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;majorUnit&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object majorUnit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximum&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;maximum&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object maximum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimum&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;minimum&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object minimum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minorUnit&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;minorUnit&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object minorUnit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAxisFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxisFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAxisFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;majorGridlines&quot; property, of type &quot;microsoft.graph.workbookChartGridlines&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartGridlines")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;majorGridlines&quot; property, of type &quot;microsoft.graph.workbookChartGridlines&quot;.")]
        public System.Object majorGridlines { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minorGridlines&quot; property, of type &quot;microsoft.graph.workbookChartGridlines&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartGridlines")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;minorGridlines&quot; property, of type &quot;microsoft.graph.workbookChartGridlines&quot;.")]
        public System.Object minorGridlines { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartAxisTitle&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAxis&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxisTitle")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAxis", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartAxisTitle&quot;.")]
        public System.Object title { get; set; }
    }
}