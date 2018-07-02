// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.workbookChart&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.workbookChart&quot; objects in the &quot;charts&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Special_Workbook_Worksheets_Charts", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    [ResourceReference]
    public class Get_Me_Drives_Special_Workbook_Worksheets_Charts : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Sortable]
        public System.Double height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;left&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Sortable]
        public System.Double left { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;top&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Sortable]
        public System.Double top { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Sortable]
        public System.Double width { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxes")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object axes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartDataLabels")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object dataLabels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAreaFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLegend")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object legend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartSeries")]
        [Selectable]
        [Expandable]
        public System.Object[] series { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartTitle")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookChart&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.workbookChart&quot; object to the &quot;charts&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Special_Workbook_Worksheets_Charts", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookChart")]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceReference]
    public class New_Me_Drives_Special_Workbook_Worksheets_Charts : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;left&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;left&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;left&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double left { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;top&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;top&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;top&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double top { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double width { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxes")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.")]
        public System.Object axes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartDataLabels")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.")]
        public System.Object dataLabels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAreaFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLegend")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.")]
        public System.Object legend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartSeries")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.")]
        public System.Object[] series { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartTitle")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.")]
        public System.Object title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Special_Workbook_Worksheets_Charts", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookChart")]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    public class Update_Me_Drives_Special_Workbook_Worksheets_Charts : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;left&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;left&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;left&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double left { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;top&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;top&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;top&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double top { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Double&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double width { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAxes")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;axes&quot; property, of type &quot;microsoft.graph.workbookChartAxes&quot;.")]
        public System.Object axes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartDataLabels")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;dataLabels&quot; property, of type &quot;microsoft.graph.workbookChartDataLabels&quot;.")]
        public System.Object dataLabels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartAreaFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;format&quot; property, of type &quot;microsoft.graph.workbookChartAreaFormat&quot;.")]
        public System.Object format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartLegend")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;legend&quot; property, of type &quot;microsoft.graph.workbookChartLegend&quot;.")]
        public System.Object legend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartSeries")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;series&quot; property, of type &quot;microsoft.graph.workbookChartSeries&quot;.")]
        public System.Object[] series { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartTitle")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;microsoft.graph.workbookChartTitle&quot;.")]
        public System.Object title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChart&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChart", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheet&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object worksheet { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookChart&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/chartId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.workbookChart&quot; object from the &quot;charts&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Special_Workbook_Worksheets_Charts", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    public class Remove_Me_Drives_Special_Workbook_Worksheets_Charts : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/setData</para>
    ///     <para type="description">The action &quot;microsoft.graph.setData&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_SetData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_SetData : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;sourceData&quot; parameter, which is accepted by the &quot;microsoft.graph.setData&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sourceData&quot; parameter, which is accepted by the &quot;microsoft.graph.setData&quot; action.")]
        public System.Object sourceData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seriesBy&quot; parameter, which is accepted by the &quot;microsoft.graph.setData&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;seriesBy&quot; parameter, which is accepted by the &quot;microsoft.graph.setData&quot; action.")]
        public System.String seriesBy { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId}/setData";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/setPosition</para>
    ///     <para type="description">The action &quot;microsoft.graph.setPosition&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_SetPosition", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_SetPosition : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startCell&quot; parameter, which is accepted by the &quot;microsoft.graph.setPosition&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startCell&quot; parameter, which is accepted by the &quot;microsoft.graph.setPosition&quot; action.")]
        public System.Object startCell { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endCell&quot; parameter, which is accepted by the &quot;microsoft.graph.setPosition&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endCell&quot; parameter, which is accepted by the &quot;microsoft.graph.setPosition&quot; action.")]
        public System.Object endCell { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId}/setPosition";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/add</para>
    ///     <para type="description">The action &quot;microsoft.graph.add&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookChart&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_Add", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookChart")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_Add : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceData&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sourceData&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.Object sourceData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seriesBy&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;seriesBy&quot; parameter, which is accepted by the &quot;microsoft.graph.add&quot; action.")]
        public System.String seriesBy { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/add";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/image</para>
    ///     <para type="description">The function &quot;microsoft.graph.image&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.String&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_Image", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookChart")]
    [ResourceIdPropertyName("chartId")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_Image : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.workbookChart&quot; object in the &quot;charts&quot; collection.")]
        public System.String chartId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;width&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;width&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        [Parameter(ParameterSetName = @"Overload_3", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;width&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        public System.Int32 width { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;height&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        [Parameter(ParameterSetName = @"Overload_3", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;height&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fittingMode&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_3", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fittingMode&quot; parameter, which is accepted by the &quot;microsoft.graph.image&quot; function.")]
        public System.String fittingMode { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/{chartId}/image({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/item</para>
    ///     <para type="description">The function &quot;microsoft.graph.item&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookChart&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_Item", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookChart")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_Item : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.item&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;name&quot; parameter, which is accepted by the &quot;microsoft.graph.item&quot; function.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/item({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/itemAt</para>
    ///     <para type="description">The function &quot;microsoft.graph.itemAt&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.workbookChart&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_ItemAt", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookChart")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_ItemAt : FunctionReturningEntityCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/itemAt({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/count</para>
    ///     <para type="description">The function &quot;microsoft.graph.count&quot;, which exists on the type &quot;microsoft.graph.workbookChart&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.Int32&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Special_Workbook_Worksheets_Charts_Count", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookChart")]
    public class Invoke_Me_Drives_Special_Workbook_Worksheets_Charts_Count : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.workbookWorksheet&quot; object in the &quot;worksheets&quot; collection.")]
        public System.String worksheetId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/workbook/worksheets/{worksheetId}/charts/count({this.GetFunctionUrlSegment()})";
        }
    }
}