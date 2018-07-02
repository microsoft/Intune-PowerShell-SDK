// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.columnLink&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.columnLink&quot; objects in the &quot;columnLinks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List_ContentTypes_ColumnLinks", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.columnLink")]
    [ResourceIdPropertyName("columnLinkId")]
    [ResourceReference]
    public class Get_Me_Drives_List_ContentTypes_ColumnLinks : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.")]
        public System.String columnLinkId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks/{columnLinkId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.columnLink&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.columnLink&quot; object to the &quot;columnLinks&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List_ContentTypes_ColumnLinks", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.columnLink")]
    [ODataType("microsoft.graph.columnLink")]
    [ResourceReference]
    public class New_Me_Drives_List_ContentTypes_ColumnLinks : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.columnLink", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.columnLink&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List_ContentTypes_ColumnLinks", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.columnLink")]
    [ODataType("microsoft.graph.columnLink")]
    [ResourceIdPropertyName("columnLinkId")]
    public class Update_Me_Drives_List_ContentTypes_ColumnLinks : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.")]
        public System.String columnLinkId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.columnLink", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks/{columnLinkId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.columnLink&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks/columnLinkId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.columnLink&quot; object from the &quot;columnLinks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List_ContentTypes_ColumnLinks", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.columnLink")]
    [ResourceIdPropertyName("columnLinkId")]
    public class Remove_Me_Drives_List_ContentTypes_ColumnLinks : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.columnLink&quot; object in the &quot;columnLinks&quot; collection.")]
        public System.String columnLinkId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}/columnLinks/{columnLinkId}";
        }
    }
}