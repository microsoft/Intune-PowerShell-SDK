// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.attachment&quot; objects.</para>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.attachment&quot; objects in the &quot;attachments&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_MailFolders_ChildFolders_Messages_Attachments", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.attachment")]
    [ResourceIdPropertyName("attachmentId")]
    [ResourceReference]
    public class Get_Me_MailFolders_ChildFolders_Messages_Attachments : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.attachment&quot; object in the &quot;attachments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.attachment&quot; object in the &quot;attachments&quot; collection.")]
        public System.String attachmentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isInline { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAttachment&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookItem")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.itemAttachment")]
        public System.Object item { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.fileAttachment")]
        public System.String contentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.fileAttachment")]
        public System.String contentLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.fileAttachment")]
        public System.Byte[] contentBytes { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments/{attachmentId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.attachment&quot; object.</para>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.attachment&quot; object to the &quot;attachments&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_MailFolders_ChildFolders_Messages_Attachments", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.attachment")]
    [ResourceReference]
    public class New_Me_MailFolders_ChildFolders_Messages_Attachments : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isInline { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.referenceAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.referenceAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.referenceAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter referenceAttachment { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.itemAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.itemAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.itemAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter itemAttachment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAttachment&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.")]
        public System.Object item { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.fileAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.fileAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter fileAttachment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] contentBytes { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.attachment&quot; object.</para>
    ///     <para type="description">DELETE ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments/attachmentId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.attachment&quot; object from the &quot;attachments&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_MailFolders_ChildFolders_Messages_Attachments", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.attachment")]
    [ResourceIdPropertyName("attachmentId")]
    public class Remove_Me_MailFolders_ChildFolders_Messages_Attachments : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.attachment&quot; object in the &quot;attachments&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.attachment&quot; object in the &quot;attachments&quot; collection.")]
        public System.String attachmentId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.message&quot; object in the &quot;messages&quot; collection.")]
        public System.String messageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
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
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messages/{messageId}/attachments/{attachmentId}";
        }
    }
}