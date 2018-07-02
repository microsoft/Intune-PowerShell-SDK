// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.permission&quot; objects.</para>
    ///     <para type="description">GET ~/me/drive/root/listItem/driveItem/permissions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.permission&quot; objects in the &quot;permissions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Root_ListItem_DriveItem_Permissions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.permission")]
    [ResourceIdPropertyName("permissionId")]
    [ResourceReference]
    public class Get_Me_Drive_Root_ListItem_DriveItem_Permissions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.")]
        public System.String permissionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object grantedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Sortable]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingInvitation")]
        [Selectable]
        [Sortable]
        public System.Object invitation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingLink")]
        [Selectable]
        [Sortable]
        public System.Object link { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roles&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] roles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String shareId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/driveItem/permissions/{permissionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.permission&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/root/listItem/driveItem/permissions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.permission&quot; object to the &quot;permissions&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Root_ListItem_DriveItem_Permissions", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.permission")]
    [ODataType("microsoft.graph.permission")]
    [ResourceReference]
    public class New_Me_Drive_Root_ListItem_DriveItem_Permissions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object grantedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingInvitation")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.")]
        public System.Object invitation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.")]
        public System.Object link { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roles&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;roles&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;roles&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] roles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String shareId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/driveItem/permissions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.permission&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/root/listItem/driveItem/permissions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Root_ListItem_DriveItem_Permissions", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.permission")]
    [ODataType("microsoft.graph.permission")]
    [ResourceIdPropertyName("permissionId")]
    public class Update_Me_Drive_Root_ListItem_DriveItem_Permissions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.")]
        public System.String permissionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object grantedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object inheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingInvitation")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.")]
        public System.Object invitation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.")]
        public System.Object link { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roles&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;roles&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;roles&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] roles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String shareId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/driveItem/permissions/{permissionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.permission&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/root/listItem/driveItem/permissions/permissionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.permission&quot; object from the &quot;permissions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Root_ListItem_DriveItem_Permissions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.permission")]
    [ResourceIdPropertyName("permissionId")]
    public class Remove_Me_Drive_Root_ListItem_DriveItem_Permissions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.permission&quot; object in the &quot;permissions&quot; collection.")]
        public System.String permissionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/driveItem/permissions/{permissionId}";
        }
    }
}