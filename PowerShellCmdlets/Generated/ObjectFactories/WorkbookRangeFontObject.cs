// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFont&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFont&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeFontObject", DefaultParameterSetName = @"microsoft.graph.workbookRangeFont")]
    [ODataType("microsoft.graph.workbookRangeFont")]
    public class New_WorkbookRangeFontObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;bold&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;bold&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean bold { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;italic&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;italic&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean italic { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;underline&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFont&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookRangeFont", HelpMessage = @"The &quot;underline&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String underline { get; set; }
    }
}