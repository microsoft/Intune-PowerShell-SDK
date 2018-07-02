// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;list&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list</para>
    ///     <para type="description">Retrieves the &quot;list&quot; object (which is of type &quot;microsoft.graph.list&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.list")]
    [ResourceReference]
    public class Get_Me_Drives_List : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listInfo")]
        [Selectable]
        [Sortable]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Sortable]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Sortable]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnDefinition")]
        [Selectable]
        [Expandable]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentType")]
        [Selectable]
        [Expandable]
        public System.Object[] contentTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [Expandable]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.list&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list</para>
    ///     <para type="description">Creates the &quot;list&quot; object (which is of type &quot;microsoft.graph.list&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.list")]
    [ODataType("microsoft.graph.list")]
    [ResourceReference]
    public class New_Me_Drives_List : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.")]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnDefinition")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentType")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        public System.Object[] contentTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.list&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list</para>
    ///     <para type="description">Updates the &quot;list&quot; object (which is of type &quot;microsoft.graph.list&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.list")]
    [ODataType("microsoft.graph.list")]
    public class Update_Me_Drives_List : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.listInfo&quot;.")]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnDefinition")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentType")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        public System.Object[] contentTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.listItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.list&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list</para>
    ///     <para type="description">Removes the &quot;list&quot; object (which is of type &quot;microsoft.graph.list&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.list")]
    public class Remove_Me_Drives_List : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list";
        }
    }
}