// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.messageRulePredicates&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.messageRulePredicates&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "MessageRulePredicatesObject", DefaultParameterSetName = @"microsoft.graph.messageRulePredicates")]
    [ODataType("microsoft.graph.messageRulePredicates")]
    public class New_MessageRulePredicatesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;categories&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] categories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subjectContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;subjectContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] subjectContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;bodyContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] bodyContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyOrSubjectContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;bodyOrSubjectContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] bodyOrSubjectContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;senderContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;senderContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] senderContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recipientContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;recipientContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] recipientContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;headerContains&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;headerContains&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] headerContains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageActionFlag&quot; property, of type &quot;microsoft.graph.messageActionFlag&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;any&apos;, &apos;call&apos;, &apos;doNotForward&apos;, &apos;followUp&apos;, &apos;fyi&apos;, &apos;forward&apos;, &apos;noResponseNecessary&apos;, &apos;read&apos;, &apos;reply&apos;, &apos;replyToAll&apos;, &apos;review&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.messageActionFlag")]
        [Selectable]
        [ValidateSet(@"any", @"call", @"doNotForward", @"followUp", @"fyi", @"forward", @"noResponseNecessary", @"read", @"reply", @"replyToAll", @"review")]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;messageActionFlag&quot; property, of type &quot;microsoft.graph.messageActionFlag&quot;.")]
        public System.String messageActionFlag { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;normal&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [ValidateSet(@"low", @"normal", @"high")]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        public System.String importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sensitivity&quot; property, of type &quot;microsoft.graph.sensitivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;normal&apos;, &apos;personal&apos;, &apos;private&apos;, &apos;confidential&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.sensitivity")]
        [Selectable]
        [ValidateSet(@"normal", @"personal", @"private", @"confidential")]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sensitivity&quot; property, of type &quot;microsoft.graph.sensitivity&quot;.")]
        public System.String sensitivity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fromAddresses&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;fromAddresses&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] fromAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentToAddresses&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sentToAddresses&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] sentToAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentToMe&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sentToMe&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean sentToMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentOnlyToMe&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sentOnlyToMe&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean sentOnlyToMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentCcMe&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sentCcMe&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean sentCcMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sentToOrCcMe&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;sentToOrCcMe&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean sentToOrCcMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notSentToMe&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;notSentToMe&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean notSentToMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isApprovalRequest&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isApprovalRequest&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isApprovalRequest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAutomaticForward&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isAutomaticForward&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAutomaticForward { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAutomaticReply&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isAutomaticReply&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAutomaticReply { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isEncrypted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEncrypted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isMeetingRequest&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isMeetingRequest&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isMeetingRequest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isMeetingResponse&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isMeetingResponse&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isMeetingResponse { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isNonDeliveryReport&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isNonDeliveryReport&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isNonDeliveryReport { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isPermissionControlled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isPermissionControlled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isPermissionControlled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadReceipt&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isReadReceipt&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadReceipt { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isSigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isVoicemail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;isVoicemail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isVoicemail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;withinSizeRange&quot; property, of type &quot;microsoft.graph.sizeRange&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRulePredicates&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sizeRange")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.messageRulePredicates", HelpMessage = @"The &quot;withinSizeRange&quot; property, of type &quot;microsoft.graph.sizeRange&quot;.")]
        public System.Object withinSizeRange { get; set; }
    }
}