// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;listItem&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/special/{specialId}/children/{childId}/listItem</para>
    ///     <para type="description">Retrieves the &quot;listItem&quot; object (which is of type &quot;microsoft.graph.listItem&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Special_Children_ListItem", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.listItem")]
    [ResourceReference]
    public class Get_Me_Drives_Special_Children_ListItem : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

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
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeInfo")]
        [Selectable]
        [Sortable]
        public System.Object contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Sortable]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object driveItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItemVersion")]
        [Selectable]
        [Expandable]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/children/{childId}/listItem";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.listItem&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/special/{specialId}/children/{childId}/listItem</para>
    ///     <para type="description">Creates the &quot;listItem&quot; object (which is of type &quot;microsoft.graph.listItem&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Special_Children_ListItem", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.listItem")]
    [ODataType("microsoft.graph.listItem")]
    [ResourceReference]
    public class New_Me_Drives_Special_Children_ListItem : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

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
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.")]
        public System.Object contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object driveItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItemVersion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/children/{childId}/listItem";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.listItem&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/special/{specialId}/children/{childId}/listItem</para>
    ///     <para type="description">Updates the &quot;listItem&quot; object (which is of type &quot;microsoft.graph.listItem&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Special_Children_ListItem", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.listItem")]
    [ODataType("microsoft.graph.listItem")]
    public class Update_Me_Drives_Special_Children_ListItem : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

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
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.")]
        public System.Object contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object driveItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItemVersion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/special/{specialId}/children/{childId}/listItem";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.listItem&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/special/{specialId}/children/{childId}/listItem</para>
    ///     <para type="description">Removes the &quot;listItem&quot; object (which is of type &quot;microsoft.graph.listItem&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Special_Children_ListItem", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.listItem")]
    public class Remove_Me_Drives_Special_Children_ListItem : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

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
            return $"me/drives/{driveId}/special/{specialId}/children/{childId}/listItem";
        }
    }
}