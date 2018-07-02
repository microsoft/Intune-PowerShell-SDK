// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.drive&quot; objects.</para>
    ///     <para type="description">GET ~/me/drives</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.drive&quot; objects in the &quot;drives&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    [ResourceReference]
    public class Get_Me_Drives : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String driveType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.quota")]
        [Selectable]
        [Sortable]
        public System.Object quota { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Sortable]
        public System.Object sharePointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Sortable]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.list")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        public System.Object[] special { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.drive&quot; object.</para>
    ///     <para type="description">POST ~/me/drives</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.drive&quot; object to the &quot;drives&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.drive")]
    [ODataType("microsoft.graph.drive")]
    [ResourceReference]
    public class New_Me_Drives : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String driveType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.quota")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.")]
        public System.Object quota { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharePointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.list")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] special { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.drive&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.drive")]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    public class Update_Me_Drives : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String driveType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.quota")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.")]
        public System.Object quota { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sharePointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharePointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.list")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] special { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.drive&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/driveId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.drive&quot; object from the &quot;drives&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    public class Remove_Me_Drives : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/recent</para>
    ///     <para type="description">The function &quot;microsoft.graph.recent&quot;, which exists on the type &quot;microsoft.graph.drive&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.driveItem&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Recent", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    public class Invoke_Me_Drives_Recent : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/recent({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/search</para>
    ///     <para type="description">The function &quot;microsoft.graph.search&quot;, which exists on the type &quot;microsoft.graph.drive&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.driveItem&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_Search", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    public class Invoke_Me_Drives_Search : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;q&quot; parameter, which is accepted by the &quot;microsoft.graph.search&quot; function.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;q&quot; parameter, which is accepted by the &quot;microsoft.graph.search&quot; function.")]
        public System.String q { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/search({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/drives/sharedWithMe</para>
    ///     <para type="description">The function &quot;microsoft.graph.sharedWithMe&quot;, which exists on the type &quot;microsoft.graph.drive&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.driveItem&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_SharedWithMe", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.drive")]
    [ResourceIdPropertyName("driveId")]
    public class Invoke_Me_Drives_SharedWithMe : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/sharedWithMe({this.GetFunctionUrlSegment()})";
        }
    }
}