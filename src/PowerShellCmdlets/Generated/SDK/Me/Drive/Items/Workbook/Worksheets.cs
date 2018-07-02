// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookWorksheet&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/worksheets</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookWorksheet&quot; objects in the &quot;worksheets&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Items_Workbook_Worksheets", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    [ResourceReference]
    public class Get_Me_Drive_Items_Workbook_Worksheets : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChart")]
        [Selectable]
        [Expandable]
        public System.Object[] charts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [Expandable]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookPivotTable")]
        [Selectable]
        [Expandable]
        public System.Object[] pivotTables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtection")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object protection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [Expandable]
        public System.Object[] tables { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookWorksheet&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/worksheets</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookWorksheet&quot; object to the &quot;worksheets&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Items_Workbook_Worksheets", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookWorksheet")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceReference]
    public class New_Me_Drive_Items_Workbook_Worksheets : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChart")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.")]
        public System.Object[] charts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookPivotTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.")]
        public System.Object[] pivotTables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.")]
        public System.Object protection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookWorksheet&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/items/{itemId}/workbook/worksheets</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Items_Workbook_Worksheets", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookWorksheet")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    public class Update_Me_Drive_Items_Workbook_Worksheets : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
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
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 position { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChart")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;charts&quot; property, of type &quot;microsoft.graph.workbookChart&quot;.")]
        public System.Object[] charts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookPivotTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pivotTables&quot; property, of type &quot;microsoft.graph.workbookPivotTable&quot;.")]
        public System.Object[] pivotTables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protection&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtection&quot;.")]
        public System.Object protection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheet", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookWorksheet&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/items/{itemId}/workbook/worksheets/worksheetId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookWorksheet&quot; object from the &quot;worksheets&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Items_Workbook_Worksheets", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    public class Remove_Me_Drive_Items_Workbook_Worksheets : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
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
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/workbook/worksheets/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookWorksheet&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookWorksheet")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_Add : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/add";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/worksheets/cell</para>
    ///     <para type="description">The function &quot;microsoft.graph.cell&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_Cell", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_Cell : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;row&quot; parameter, which is accepted by the &quot;microsoft.graph.cell&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;row&quot; parameter, which is accepted by the &quot;microsoft.graph.cell&quot; function.")]
        public System.Int32 row { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;column&quot; parameter, which is accepted by the &quot;microsoft.graph.cell&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;column&quot; parameter, which is accepted by the &quot;microsoft.graph.cell&quot; function.")]
        public System.Int32 column { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
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
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/cell({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/worksheets/range</para>
    ///     <para type="description">The function &quot;microsoft.graph.range&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_Range", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_Range : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;address&quot; parameter, which is accepted by the &quot;microsoft.graph.range&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;address&quot; parameter, which is accepted by the &quot;microsoft.graph.range&quot; function.")]
        public System.String address { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/range({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/workbook/worksheets/usedRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.usedRange&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Workbook_Worksheets_UsedRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookWorksheet")]
    [ResourceIdPropertyName("worksheetId")]
    public class Invoke_Me_Drive_Items_Workbook_Worksheets_UsedRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valuesOnly&quot; parameter, which is accepted by the &quot;microsoft.graph.usedRange&quot; function.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;valuesOnly&quot; parameter, which is accepted by the &quot;microsoft.graph.usedRange&quot; function.")]
        public System.Boolean valuesOnly { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/workbook/worksheets/{worksheetId}/usedRange({this.GetFunctionUrlSegment()})";
        }
    }
}