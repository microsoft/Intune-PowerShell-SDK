// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.thumbnailSet&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/drive/root/thumbnails</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.thumbnailSet&quot; objects in the &quot;thumbnails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List_Drive_Root_Thumbnails", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.thumbnailSet")]
    [ResourceIdPropertyName("thumbnailId")]
    [ResourceReference]
    public class Get_Me_Drives_List_Drive_Root_Thumbnails : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.")]
        public System.String thumbnailId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Sortable]
        public System.Object large { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Sortable]
        public System.Object medium { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Sortable]
        public System.Object small { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Sortable]
        public System.Object source { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/thumbnails/{thumbnailId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.thumbnailSet&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/thumbnails</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.thumbnailSet&quot; object to the &quot;thumbnails&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List_Drive_Root_Thumbnails", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.thumbnailSet")]
    [ODataType("microsoft.graph.thumbnailSet")]
    [ResourceReference]
    public class New_Me_Drives_List_Drive_Root_Thumbnails : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object large { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object medium { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object small { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object source { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/thumbnails";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.thumbnailSet&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list/drive/root/thumbnails</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List_Drive_Root_Thumbnails", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.thumbnailSet")]
    [ODataType("microsoft.graph.thumbnailSet")]
    [ResourceIdPropertyName("thumbnailId")]
    public class Update_Me_Drives_List_Drive_Root_Thumbnails : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.")]
        public System.String thumbnailId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object large { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object medium { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object small { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object source { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/thumbnails/{thumbnailId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.thumbnailSet&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list/drive/root/thumbnails/thumbnailId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.thumbnailSet&quot; object from the &quot;thumbnails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List_Drive_Root_Thumbnails", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.thumbnailSet")]
    [ResourceIdPropertyName("thumbnailId")]
    public class Remove_Me_Drives_List_Drive_Root_Thumbnails : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.thumbnailSet&quot; object in the &quot;thumbnails&quot; collection.")]
        public System.String thumbnailId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/thumbnails/{thumbnailId}";
        }
    }
}