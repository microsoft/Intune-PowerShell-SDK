// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookTableRow&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookTableRow&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookTableRowObject", DefaultParameterSetName = @"microsoft.graph.workbookTableRow")]
    [ODataType("microsoft.graph.workbookTableRow")]
    public class New_WorkbookTableRowObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }
    }
}