// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheet&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheet&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookWorksheetObject", DefaultParameterSetName = @"#microsoft.graph.workbookWorksheet")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    public class New_WorkbookWorksheetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChart")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.")]
        public System.Object[] charts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookPivotTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.")]
        public System.Object[] pivotTables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.")]
        public System.Object protection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }
    }
}