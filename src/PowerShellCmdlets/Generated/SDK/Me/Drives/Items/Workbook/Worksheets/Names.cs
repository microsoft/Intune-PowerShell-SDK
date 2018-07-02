// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookNamedItem&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookNamedItem&quot; objects in the &quot;names&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Items_Workbook_Worksheets_Names", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookNamedItem")]
    [ResourceIdPropertyName("nameId")]
    [ResourceReference]
    public class Get_Me_Drives_Items_Workbook_Worksheets_Names : GetOrSearchCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.")]
        public System.String nameId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String scope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/{nameId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookNamedItem&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookNamedItem&quot; object to the &quot;names&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Items_Workbook_Worksheets_Names", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookNamedItem")]
    [ODataType("microsoft.graph.workbookNamedItem")]
    [ResourceReference]
    public class New_Me_Drives_Items_Workbook_Worksheets_Names : PostCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;comment&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;comment&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String scope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookNamedItem&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Items_Workbook_Worksheets_Names", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookNamedItem")]
    [ODataType("microsoft.graph.workbookNamedItem")]
    [ResourceIdPropertyName("nameId")]
    public class Update_Me_Drives_Items_Workbook_Worksheets_Names : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.")]
        public System.String nameId { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;comment&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;comment&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String scope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visible&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean visible { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookNamedItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookNamedItem", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/{nameId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookNamedItem&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/nameId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookNamedItem&quot; object from the &quot;names&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Items_Workbook_Worksheets_Names", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookNamedItem")]
    [ResourceIdPropertyName("nameId")]
    public class Remove_Me_Drives_Items_Workbook_Worksheets_Names : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.")]
        public System.String nameId { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/{nameId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookNamedItem&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Worksheets_Names_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookNamedItem")]
    public class Invoke_Me_Drives_Items_Workbook_Worksheets_Names_Add : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.Object reference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;comment&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String comment { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/add";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/addFormulaLocal</para>
    ///     <para type="description">The action &quot;microsoft.graph.addFormulaLocal&quot;, which exists on the type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookNamedItem&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Worksheets_Names_AddFormulaLocal", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookNamedItem")]
    public class Invoke_Me_Drives_Items_Workbook_Worksheets_Names_AddFormulaLocal : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formula&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;formula&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.")]
        public System.String formula { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;comment&quot; parameter, which is accepted by the &quot;microsoft.graph.addFormulaLocal&quot; action.")]
        public System.String comment { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/addFormulaLocal";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/range</para>
    ///     <para type="description">The function &quot;microsoft.graph.range&quot;, which exists on the type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookRange&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Worksheets_Names_Range", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookNamedItem")]
    [ResourceIdPropertyName("nameId")]
    public class Invoke_Me_Drives_Items_Workbook_Worksheets_Names_Range : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookNamedItem&quot; object in the &quot;names&quot; collection.")]
        public System.String nameId { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/names/{nameId}/range({this.GetFunctionUrlSegment()})";
        }
    }
}