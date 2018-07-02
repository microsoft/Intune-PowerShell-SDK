// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.contentType&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/contentTypes</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.contentType&quot; objects in the &quot;contentTypes&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List_ContentTypes", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.contentType")]
    [ResourceIdPropertyName("contentTypeId")]
    [ResourceReference]
    public class Get_Me_Drives_List_ContentTypes : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;group&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeOrder")]
        [Selectable]
        [Sortable]
        public System.Object order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String parentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean readOnly { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean @sealed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnLink")]
        [Selectable]
        [Expandable]
        public System.Object[] columnLinks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.contentType&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/contentTypes</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.contentType&quot; object to the &quot;contentTypes&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List_ContentTypes", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.contentType")]
    [ODataType("microsoft.graph.contentType")]
    [ResourceReference]
    public class New_Me_Drives_List_ContentTypes : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;group&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;group&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;group&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeOrder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.")]
        public System.Object order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean readOnly { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean @sealed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnLink")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.")]
        public System.Object[] columnLinks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.contentType&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list/contentTypes</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List_ContentTypes", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.contentType")]
    [ODataType("microsoft.graph.contentType")]
    [ResourceIdPropertyName("contentTypeId")]
    public class Update_Me_Drives_List_ContentTypes : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
        public System.String contentTypeId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;group&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;group&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;group&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeOrder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;order&quot; property, of type &quot;microsoft.graph.contentTypeOrder&quot;.")]
        public System.Object order { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean readOnly { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sealed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean @sealed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentType&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnLink")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contentType", HelpMessage = @"The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columnLinks&quot; property, of type &quot;microsoft.graph.columnLink&quot;.")]
        public System.Object[] columnLinks { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.contentType&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list/contentTypes/contentTypeId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.contentType&quot; object from the &quot;contentTypes&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List_ContentTypes", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.contentType")]
    [ResourceIdPropertyName("contentTypeId")]
    public class Remove_Me_Drives_List_ContentTypes : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contentType&quot; object in the &quot;contentTypes&quot; collection.")]
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
            return $"me/drives/{driveId}/list/contentTypes/{contentTypeId}";
        }
    }
}