// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.outlookItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.outlookItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OutlookItemObject", DefaultParameterSetName = @"#microsoft.graph.outlookItem")]
    [ODataType("microsoft.graph.outlookItem")]
    public class New_OutlookItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookItem", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ChangeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookItem", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Categories { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.post")]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.post&quot; type.")]
        public System.Management.Automation.SwitchParameter Post { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object Body { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;receivedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ReceivedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean HasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;from&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object From { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sender&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object Sender { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ConversationThreadId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;newParticipants&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;newParticipants&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] NewParticipants { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;conversationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ConversationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        public System.Object[] Extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inReplyTo&quot; property, of type &quot;microsoft.graph.post&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.post")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;inReplyTo&quot; property, of type &quot;microsoft.graph.post&quot;.")]
        public System.Object InReplyTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attachment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.")]
        public System.Object[] Attachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] SingleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.post&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.post", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] MultiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.contact")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contact&quot; type.")]
        public System.Management.Automation.SwitchParameter Contact { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ParentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset Birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileAs&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;fileAs&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String FileAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String GivenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;initials&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;initials&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Initials { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;middleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;middleName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MiddleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nickName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;nickName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String NickName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiGivenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;yomiGivenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String YomiGivenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiSurname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;yomiSurname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String YomiSurname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiCompanyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;yomiCompanyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String YomiCompanyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;generation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;generation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Generation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddresses&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;emailAddresses&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object[] EmailAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] ImAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String JobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CompanyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OfficeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;profession&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;profession&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Profession { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessHomePage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;businessHomePage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BusinessHomePage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assistantName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;assistantName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AssistantName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manager&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;manager&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Manager { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;homePhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;homePhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] HomePhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] BusinessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;homeAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;homeAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object HomeAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;businessAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object BusinessAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;otherAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;otherAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object OtherAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;spouseName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;spouseName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SpouseName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personalNotes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;personalNotes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PersonalNotes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;children&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;children&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Children { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contact&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contact", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object Photo { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.message")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.message&quot; type.")]
        public System.Management.Automation.SwitchParameter Message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;sentDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset SentDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String InternetMessageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.internetMessageHeader")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;internetMessageHeaders&quot; property, of type &quot;microsoft.graph.internetMessageHeader&quot;.")]
        public System.Object[] InternetMessageHeaders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BodyPreview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;normal&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [ValidateSet(@"low", @"normal", @"high")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        public System.String Importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ToRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] CcRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;bccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] BccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;replyTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ReplyTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;uniqueBody&quot; property, of type &quot;microsoft.graph.itemBody&quot;.")]
        public System.Object UniqueBody { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDeliveryReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsDeliveryReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isReadReceiptRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsReadReceiptRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsRead { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;isDraft&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsDraft { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String WebLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;focused&apos;, &apos;other&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [ValidateSet(@"focused", @"other")]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String InferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.message&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.followupFlag")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.message", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;flag&quot; property, of type &quot;microsoft.graph.followupFlag&quot;.")]
        public System.Object Flag { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.eventMessage")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.eventMessage&quot; type.")]
        public System.Management.Automation.SwitchParameter EventMessage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;meetingRequest&apos;, &apos;meetingCancelled&apos;, &apos;meetingAccepted&apos;, &apos;meetingTenativelyAccepted&apos;, &apos;meetingDeclined&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.meetingMessageType")]
        [Selectable]
        [ValidateSet(@"none", @"meetingRequest", @"meetingCancelled", @"meetingAccepted", @"meetingTenativelyAccepted", @"meetingDeclined")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;meetingMessageType&quot; property, of type &quot;microsoft.graph.meetingMessageType&quot;.")]
        public System.String MeetingMessageType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eventMessage&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.event")]
        [Parameter(ParameterSetName = @"#microsoft.graph.eventMessage", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;event&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object Event { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalStartTimeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;originalStartTimeZone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OriginalStartTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalEndTimeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;originalEndTimeZone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OriginalEndTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responseStatus&quot; property, of type &quot;microsoft.graph.responseStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.responseStatus")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;responseStatus&quot; property, of type &quot;microsoft.graph.responseStatus&quot;.")]
        public System.Object ResponseStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iCalUId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;iCalUId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ICalUId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;reminderMinutesBeforeStart&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;reminderMinutesBeforeStart&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ReminderMinutesBeforeStart { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReminderOn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;isReminderOn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsReminderOn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sensitivity&quot; property, of type &quot;microsoft.graph.sensitivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;normal&apos;, &apos;personal&apos;, &apos;private&apos;, &apos;confidential&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.sensitivity")]
        [Selectable]
        [ValidateSet(@"normal", @"personal", @"private", @"confidential")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;sensitivity&quot; property, of type &quot;microsoft.graph.sensitivity&quot;.")]
        public System.String Sensitivity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object Start { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalStart&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;originalStart&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset OriginalStart { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object End { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object Location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locations&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;locations&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object[] Locations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAllDay&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;isAllDay&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsAllDay { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCancelled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;isCancelled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsCancelled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isOrganizer&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;isOrganizer&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsOrganizer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recurrence&quot; property, of type &quot;microsoft.graph.patternedRecurrence&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.patternedRecurrence")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;recurrence&quot; property, of type &quot;microsoft.graph.patternedRecurrence&quot;.")]
        public System.Object Recurrence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responseRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;responseRequested&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ResponseRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seriesMasterId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;seriesMasterId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SeriesMasterId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showAs&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;free&apos;, &apos;tentative&apos;, &apos;busy&apos;, &apos;oof&apos;, &apos;workingElsewhere&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyStatus")]
        [Selectable]
        [ValidateSet(@"free", @"tentative", @"busy", @"oof", @"workingElsewhere", @"unknown")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;showAs&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.")]
        public System.String ShowAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.eventType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;singleInstance&apos;, &apos;occurrence&apos;, &apos;exception&apos;, &apos;seriesMaster&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.eventType")]
        [Selectable]
        [ValidateSet(@"singleInstance", @"occurrence", @"exception", @"seriesMaster")]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.eventType&quot;.")]
        public System.String Type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attendees&quot; property, of type &quot;microsoft.graph.attendee&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;attendees&quot; property, of type &quot;microsoft.graph.attendee&quot;.")]
        public System.Object[] Attendees { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizer&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;organizer&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object Organizer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onlineMeetingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;onlineMeetingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OnlineMeetingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object Calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;instances&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.event", HelpMessage = @"The &quot;instances&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] Instances { get; set; }
    }
}