// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mailFolder&quot; objects.</para>
    ///     <para type="description">GET ~/me/mailFolders</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mailFolder&quot; objects in the &quot;mailFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_MailFolders", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("mailFolderId")]
    [ResourceReference]
    public class Get_Me_MailFolders : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

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
            return $"me/mailFolders/{mailFolderId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.mailFolder&quot; object.</para>
    ///     <para type="description">POST ~/me/mailFolders</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.mailFolder&quot; object to the &quot;mailFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_MailFolders", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceReference]
    public class New_Me_MailFolders : PostCmdlet
    {
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
            return $"me/mailFolders";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">PATCH ~/me/mailFolders</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_MailFolders", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("mailFolderId")]
    public class Update_Me_MailFolders : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
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
            return $"me/mailFolders/{mailFolderId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.mailFolder&quot; object.</para>
    ///     <para type="description">DELETE ~/me/mailFolders/mailFolderId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.mailFolder&quot; object from the &quot;mailFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_MailFolders", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("mailFolderId")]
    public class Remove_Me_MailFolders : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/copy</para>
    ///     <para type="description">The action &quot;microsoft.graph.copy&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.mailFolder&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_Copy", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("mailFolderId")]
    public class Invoke_Me_MailFolders_Copy : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.copy&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/copy";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/mailFolders/move</para>
    ///     <para type="description">The action &quot;microsoft.graph.move&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.mailFolder&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_Move", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mailFolder")]
    [ResourceIdPropertyName("mailFolderId")]
    public class Invoke_Me_MailFolders_Move : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;DestinationId&quot; parameter, which is accepted by the &quot;microsoft.graph.move&quot; action.")]
        public System.String DestinationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/move";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/mailFolders/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.mailFolder&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.mailFolder&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_MailFolders_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mailFolder")]
    public class Invoke_Me_MailFolders_Delta : FunctionReturningCollectionCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/delta({this.GetFunctionUrlSegment()})";
        }
    }
}