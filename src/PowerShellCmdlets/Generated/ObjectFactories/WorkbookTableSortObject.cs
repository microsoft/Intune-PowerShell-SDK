// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookTableSort&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookTableSort&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookTableSortObject", DefaultParameterSetName = @"#microsoft.graph.workbookTableSort")]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class New_WorkbookTableSortObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookSortField")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.")]
        public System.Object[] fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean matchCase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;method&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String method { get; set; }
    }
}