// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;sort&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort</para>
    ///     <para type="description">Retrieves the &quot;sort&quot; object (which is of type &quot;microsoft.graph.workbookTableSort&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Items_Workbook_Tables_Sort", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookTableSort")]
    [ResourceReference]
    public class Get_Me_Drives_Items_Workbook_Tables_Sort : GetCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookSortField")]
        [Selectable]
        public System.Object[] fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean matchCase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String method { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookTableSort&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort</para>
    ///     <para type="description">Creates the &quot;sort&quot; object (which is of type &quot;microsoft.graph.workbookTableSort&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Items_Workbook_Tables_Sort", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookTableSort")]
    [ODataType("microsoft.graph.workbookTableSort")]
    [ResourceReference]
    public class New_Me_Drives_Items_Workbook_Tables_Sort : PostCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookSortField")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.")]
        public System.Object[] fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean matchCase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;method&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;method&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String method { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookTableSort&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort</para>
    ///     <para type="description">Updates the &quot;sort&quot; object (which is of type &quot;microsoft.graph.workbookTableSort&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Items_Workbook_Tables_Sort", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookTableSort")]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class Update_Me_Drives_Items_Workbook_Tables_Sort : PatchCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookSortField")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.workbookSortField&quot;.")]
        public System.Object[] fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;matchCase&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean matchCase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookTableSort&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookTableSort", HelpMessage = @"The &quot;method&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;method&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String method { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookTableSort&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort</para>
    ///     <para type="description">Removes the &quot;sort&quot; object (which is of type &quot;microsoft.graph.workbookTableSort&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Items_Workbook_Tables_Sort", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class Remove_Me_Drives_Items_Workbook_Tables_Sort : DeleteCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/apply</para>
    ///     <para type="description">The action &quot;microsoft.graph.apply&quot;, which exists on the type &quot;microsoft.graph.workbookTableSort&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Tables_Sort_Apply", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class Invoke_Me_Drives_Items_Workbook_Tables_Sort_Apply : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;fields&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookSortField")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fields&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.")]
        public System.Object[] fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchCase&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;matchCase&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.")]
        public System.Boolean matchCase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;method&quot; parameter, which is accepted by the &quot;microsoft.graph.apply&quot; action.")]
        public System.String method { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/apply";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/clear</para>
    ///     <para type="description">The action &quot;microsoft.graph.clear&quot;, which exists on the type &quot;microsoft.graph.workbookTableSort&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Tables_Sort_Clear", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class Invoke_Me_Drives_Items_Workbook_Tables_Sort_Clear : ActionCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/clear";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/reapply</para>
    ///     <para type="description">The action &quot;microsoft.graph.reapply&quot;, which exists on the type &quot;microsoft.graph.workbookTableSort&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Tables_Sort_Reapply", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookTableSort")]
    public class Invoke_Me_Drives_Items_Workbook_Tables_Sort_Reapply : ActionCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/tables/{tableId}/sort/reapply";
        }
    }
}