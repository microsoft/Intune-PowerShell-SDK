// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mailFolder&quot; objects.</para>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mailFolder&quot; objects in the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_MailFolders_ChildFolders", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("childFolderId")]
    [ResourceReference]
    public class Get_Me_MailFolders_ChildFolders : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 childFolderCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 unreadItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 totalItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [Expandable]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRule")]
        [Selectable]
        [Expandable]
        public System.Object[] messageRules { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [Expandable]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mailFolder&quot; object.</para>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mailFolder&quot; object to the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_MailFolders_ChildFolders", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceReference]
    public class New_Me_MailFolders_ChildFolders : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 childFolderCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unreadItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        public System.Object[] messageRules { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">PATCH ~/me/mailFolders/{mailFolderId}/childFolders</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_MailFolders_ChildFolders", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Update_Me_MailFolders_ChildFolders : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 childFolderCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unreadItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        public System.Object[] messageRules { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mailFolder&quot; object.</para>
    ///     <para type="description">DELETE ~/me/mailFolders/{mailFolderId}/childFolders/childFolderId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mailFolder&quot; object from the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_MailFolders_ChildFolders", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Remove_Me_MailFolders_ChildFolders : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/copy</para>
    ///     <para type="description">The action &quot;microsoft.graph.copy&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.mailFolder&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Copy", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Invoke_Me_MailFolders_ChildFolders_Copy : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/copy";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/move</para>
    ///     <para type="description">The action &quot;microsoft.graph.move&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.mailFolder&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Move", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Invoke_Me_MailFolders_ChildFolders_Move : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/move";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.mailFolder&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_ChildFolders_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mailFolder")]
    public class Invoke_Me_MailFolders_ChildFolders_Delta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/delta({this.GetFunctionUrlSegment()})";
        }
    }
}