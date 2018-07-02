// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;protection&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection</para>
    ///     <para type="description">Retrieves the &quot;protection&quot; object (which is of type &quot;microsoft.graph.workbookWorksheetProtection&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Items_Workbook_Worksheets_Protection", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    [ResourceReference]
    public class Get_Me_Drives_Items_Workbook_Worksheets_Protection : GetCmdlet
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
        ///     <para type="description">The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
        [Selectable]
        [Sortable]
        public System.Object options { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean @protected { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookWorksheetProtection&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection</para>
    ///     <para type="description">Creates the &quot;protection&quot; object (which is of type &quot;microsoft.graph.workbookWorksheetProtection&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Items_Workbook_Worksheets_Protection", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookWorksheetProtection")]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    [ResourceReference]
    public class New_Me_Drives_Items_Workbook_Worksheets_Protection : PostCmdlet
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
        ///     <para type="description">The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.")]
        public System.Object options { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean @protected { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection</para>
    ///     <para type="description">Updates the &quot;protection&quot; object (which is of type &quot;microsoft.graph.workbookWorksheetProtection&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Items_Workbook_Worksheets_Protection", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookWorksheetProtection")]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    public class Update_Me_Drives_Items_Workbook_Worksheets_Protection : PatchCmdlet
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
        ///     <para type="description">The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.")]
        public System.Object options { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean @protected { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookWorksheetProtection&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection</para>
    ///     <para type="description">Removes the &quot;protection&quot; object (which is of type &quot;microsoft.graph.workbookWorksheetProtection&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Items_Workbook_Worksheets_Protection", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    public class Remove_Me_Drives_Items_Workbook_Worksheets_Protection : DeleteCmdlet
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

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection/protect</para>
    ///     <para type="description">The action &quot;microsoft.graph.protect&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Worksheets_Protection_Protect", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    public class Invoke_Me_Drives_Items_Workbook_Worksheets_Protection_Protect : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;options&quot; parameter, which is accepted by the &quot;microsoft.graph.protect&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;options&quot; parameter, which is accepted by the &quot;microsoft.graph.protect&quot; action.")]
        public System.Object options { get; set; }

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
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection/protect";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection/unprotect</para>
    ///     <para type="description">The action &quot;microsoft.graph.unprotect&quot;, which exists on the type &quot;microsoft.graph.workbookWorksheetProtection&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Items_Workbook_Worksheets_Protection_Unprotect", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    public class Invoke_Me_Drives_Items_Workbook_Worksheets_Protection_Unprotect : ActionCmdlet
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

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/workbook/worksheets/{worksheetId}/protection/unprotect";
        }
    }
}