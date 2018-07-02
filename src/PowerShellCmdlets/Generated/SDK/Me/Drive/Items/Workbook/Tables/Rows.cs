// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookTableRow&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookTableRow&quot; objects in the &quot;rows&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Items_Workbook_Tables_Rows", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookTableRow")]
    [ResourceIdPropertyName("rowId")]
    [ResourceReference]
    public class Get_Me_Drive_Items_Workbook_Tables_Rows : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.")]
        public System.String rowId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/{rowId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookTableRow&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookTableRow&quot; object to the &quot;rows&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Items_Workbook_Tables_Rows", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookTableRow")]
    [ODataType("microsoft.graph.workbookTableRow")]
    [ResourceReference]
    public class New_Me_Drive_Items_Workbook_Tables_Rows : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookTableRow&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Items_Workbook_Tables_Rows", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookTableRow")]
    [ODataType("microsoft.graph.workbookTableRow")]
    [ResourceIdPropertyName("rowId")]
    public class Update_Me_Drive_Items_Workbook_Tables_Rows : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.")]
        public System.String rowId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableRow&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableRow", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/{rowId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookTableRow&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows/rowId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookTableRow&quot; object from the &quot;rows&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Items_Workbook_Tables_Rows", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableRow")]
    [ResourceIdPropertyName("rowId")]
    public class Remove_Me_Drive_Items_Workbook_Tables_Rows : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.")]
        public System.String rowId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/{rowId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookTableRow&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookTableRow&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Tables_Rows_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableRow")]
    public class Invoke_Me_Drive_Items_Workbook_Tables_Rows_Add : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/add";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows/range</para>
    ///     <para type="description">The function &quot;microsoft.graph.range&quot;, which exists on the type &quot;microsoft.graph.workbookTableRow&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Tables_Rows_Range", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableRow")]
    [ResourceIdPropertyName("rowId")]
    public class Invoke_Me_Drive_Items_Workbook_Tables_Rows_Range : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableRow&quot; object in the &quot;rows&quot; collection.")]
        public System.String rowId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/{rowId}/range({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows/itemAt</para>
    ///     <para type="description">The function &quot;microsoft.graph.itemAt&quot;, which exists on the type &quot;microsoft.graph.workbookTableRow&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookTableRow&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Tables_Rows_ItemAt", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableRow")]
    public class Invoke_Me_Drive_Items_Workbook_Tables_Rows_ItemAt : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.itemAt&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;index&quot; parameter, which is accepted by the &quot;microsoft.graph.itemAt&quot; function.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/itemAt({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/tables/{tableId}/rows/count</para>
    ///     <para type="description">The function &quot;microsoft.graph.count&quot;, which exists on the type &quot;microsoft.graph.workbookTableRow&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.Int32&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Tables_Rows_Count", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableRow")]
    public class Invoke_Me_Drive_Items_Workbook_Tables_Rows_Count : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/tables/{tableId}/rows/count({this.GetFunctionUrlSegment()})";
        }
    }
}