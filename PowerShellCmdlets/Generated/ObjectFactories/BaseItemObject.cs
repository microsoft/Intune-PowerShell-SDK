// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.baseItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.baseItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "BaseItemObject", DefaultParameterSetName = @"#microsoft.graph.baseItem")]
    [ODataType("microsoft.graph.baseItem")]
    public class New_BaseItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;eTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;createdByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object createdByUser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;lastModifiedByUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object lastModifiedByUser { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.sharedDriveItem")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.sharedDriveItem&quot; type.")]
        public System.Management.Automation.SwitchParameter sharedDriveItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.driveItem")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object driveItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;items&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] items { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.list")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;list&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        public System.Object list { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.listItem")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;listItem&quot; property, of type &quot;microsoft.graph.listItem&quot;.")]
        public System.Object listItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object root { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;site&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedDriveItem&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.site")]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharedDriveItem", HelpMessage = @"The &quot;site&quot; property, of type &quot;microsoft.graph.site&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;site&quot; property, of type &quot;microsoft.graph.site&quot;.")]
        public System.Object site { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentTypeInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.contentTypeInfo&quot;.")]
        public System.Object contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItemVersion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;versions&quot; property, of type &quot;microsoft.graph.listItemVersion&quot;.")]
        public System.Object[] versions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.systemFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;system&quot; property, of type &quot;microsoft.graph.systemFacet&quot;.")]
        public System.Object system { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.columnDefinition")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;columns&quot; property, of type &quot;microsoft.graph.columnDefinition&quot;.")]
        public System.Object[] columns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contentType")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;contentTypes&quot; property, of type &quot;microsoft.graph.contentType&quot;.")]
        public System.Object[] contentTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.list&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.drive")]
        [Parameter(ParameterSetName = @"#microsoft.graph.list", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.audio")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;audio&quot; property, of type &quot;microsoft.graph.audio&quot;.")]
        public System.Object audio { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;cTag&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String cTag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deleted")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;microsoft.graph.deleted&quot;.")]
        public System.Object deleted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.file")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        public System.Object file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        public System.Object folder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.image")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;image&quot; property, of type &quot;microsoft.graph.image&quot;.")]
        public System.Object image { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.geoCoordinates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.package")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        public System.Object package { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.photo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.photo&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.remoteItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;remoteItem&quot; property, of type &quot;microsoft.graph.remoteItem&quot;.")]
        public System.Object remoteItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.searchResult")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;searchResult&quot; property, of type &quot;microsoft.graph.searchResult&quot;.")]
        public System.Object searchResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.shared")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        public System.Object shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.specialFolder")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        public System.Object specialFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.video")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;video&quot; property, of type &quot;microsoft.graph.video&quot;.")]
        public System.Object video { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webDavUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;children&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] children { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.permission")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;permissions&quot; property, of type &quot;microsoft.graph.permission&quot;.")]
        public System.Object[] permissions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnailSet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;thumbnails&quot; property, of type &quot;microsoft.graph.thumbnailSet&quot;.")]
        public System.Object[] thumbnails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItem", HelpMessage = @"The &quot;workbook&quot; property, of type &quot;microsoft.graph.workbook&quot;.")]
        public System.Object workbook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteCollection&quot; property, of type &quot;microsoft.graph.siteCollection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.site&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.siteCollection")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;siteCollection&quot; property, of type &quot;microsoft.graph.siteCollection&quot;.")]
        public System.Object siteCollection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.site&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object[] drives { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lists&quot; property, of type &quot;microsoft.graph.list&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.site&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.list")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;lists&quot; property, of type &quot;microsoft.graph.list&quot;.")]
        public System.Object[] lists { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.site&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.site")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.")]
        public System.Object[] sites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.site&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenote")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.site", HelpMessage = @"The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.")]
        public System.Object onenote { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String driveType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.quota")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;quota&quot; property, of type &quot;microsoft.graph.quota&quot;.")]
        public System.Object quota { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.drive&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.drive", HelpMessage = @"The &quot;special&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object[] special { get; set; }
    }
}