// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookTableColumn&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookTableColumn&quot; objects in the &quot;columns&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Special_Workbook_Tables_Columns", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    [ResourceReference]
    public class Get_Me_Drive_Special_Workbook_Tables_Columns : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFilter")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object filter { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookTableColumn&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookTableColumn&quot; object to the &quot;columns&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Special_Workbook_Tables_Columns", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookTableColumn")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceReference]
    public class New_Me_Drive_Special_Workbook_Tables_Columns : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFilter")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.")]
        public System.Object filter { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Special_Workbook_Tables_Columns", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookTableColumn")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Update_Me_Drive_Special_Workbook_Tables_Columns : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableColumn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFilter")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableColumn", HelpMessage = @"The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;filter&quot; property, of type &quot;microsoft.graph.workbookFilter&quot;.")]
        public System.Object filter { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookTableColumn&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/columnId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookTableColumn&quot; object from the &quot;columns&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Special_Workbook_Tables_Columns", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Remove_Me_Drive_Special_Workbook_Tables_Columns : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookTableColumn&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableColumn")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_Add : ActionCmdlet
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
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/add";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/dataBodyRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.dataBodyRange&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_DataBodyRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_DataBodyRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}/dataBodyRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/headerRowRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.headerRowRange&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_HeaderRowRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_HeaderRowRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}/headerRowRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/range</para>
    ///     <para type="description">The function &quot;microsoft.graph.range&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_Range", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_Range : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}/range({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/totalRowRange</para>
    ///     <para type="description">The function &quot;microsoft.graph.totalRowRange&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_TotalRowRange", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    [ResourceIdPropertyName("columnId")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_TotalRowRange : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookTableColumn&quot; object in the &quot;columns&quot; collection.")]
        public System.String columnId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/{columnId}/totalRowRange({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/itemAt</para>
    ///     <para type="description">The function &quot;microsoft.graph.itemAt&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookTableColumn&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_ItemAt", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_ItemAt : FunctionReturningEntityCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/itemAt({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/tables/{tableId}/columns/count</para>
    ///     <para type="description">The function &quot;microsoft.graph.count&quot;, which exists on the type &quot;microsoft.graph.workbookTableColumn&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.Int32&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Tables_Columns_Count", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableColumn")]
    public class Invoke_Me_Drive_Special_Workbook_Tables_Columns_Count : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookTable&quot; object in the &quot;tables&quot; collection.")]
        public System.String tableId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/tables/{tableId}/columns/count({this.GetFunctionUrlSegment()})";
        }
    }
}