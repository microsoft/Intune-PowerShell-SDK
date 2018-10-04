// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbook&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbook&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookObject", DefaultParameterSetName = @"microsoft.graph.workbook")]
    [ODataType("microsoft.graph.workbook")]
    public class New_WorkbookObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookApplication")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbook", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.")]
        public System.Object application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbook", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbook", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workbook", HelpMessage = @"The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object[] worksheets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFunctions")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbook", HelpMessage = @"The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.")]
        public System.Object functions { get; set; }
    }
}