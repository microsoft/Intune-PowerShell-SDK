// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookPivotTable&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookPivotTable&quot; objects in the &quot;pivotTables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Items_Workbook_Worksheets_PivotTables", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookPivotTable")]
    [ResourceIdPropertyName("pivotTableId")]
    [ResourceReference]
    public class Get_Me_Drive_Items_Workbook_Worksheets_PivotTables : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.")]
        public System.String pivotTableId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/{pivotTableId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookPivotTable&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookPivotTable&quot; object to the &quot;pivotTables&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Items_Workbook_Worksheets_PivotTables", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookPivotTable")]
    [ODataType("microsoft.graph.workbookPivotTable")]
    [ResourceReference]
    public class New_Me_Drive_Items_Workbook_Worksheets_PivotTables : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookPivotTable", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookPivotTable", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookPivotTable&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Items_Workbook_Worksheets_PivotTables", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookPivotTable")]
    [ODataType("microsoft.graph.workbookPivotTable")]
    [ResourceIdPropertyName("pivotTableId")]
    public class Update_Me_Drive_Items_Workbook_Worksheets_PivotTables : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.")]
        public System.String pivotTableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookPivotTable", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookPivotTable&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookPivotTable", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/{pivotTableId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookPivotTable&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/pivotTableId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookPivotTable&quot; object from the &quot;pivotTables&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Items_Workbook_Worksheets_PivotTables", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookPivotTable")]
    [ResourceIdPropertyName("pivotTableId")]
    public class Remove_Me_Drive_Items_Workbook_Worksheets_PivotTables : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.")]
        public System.String pivotTableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/{pivotTableId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/refresh</para>
    ///     <para type="description">The action &quot;microsoft.graph.refresh&quot;, which exists on the type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_PivotTables_Refresh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookPivotTable")]
    [ResourceIdPropertyName("pivotTableId")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_PivotTables_Refresh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookPivotTable&quot; object in the &quot;pivotTables&quot; collection.")]
        public System.String pivotTableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/{pivotTableId}/refresh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/refreshAll</para>
    ///     <para type="description">The action &quot;microsoft.graph.refreshAll&quot;, which exists on the type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_PivotTables_RefreshAll", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookPivotTable")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_PivotTables_RefreshAll : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/pivotTables/refreshAll";
        }
    }
}