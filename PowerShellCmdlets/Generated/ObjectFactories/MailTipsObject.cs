// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mailTips&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mailTips&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MailTipsObject", DefaultParameterSetName = @"microsoft.graph.mailTips")]
    [ODataType("microsoft.graph.mailTips")]
    public class New_MailTipsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object emailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;automaticReplies&quot; property, of type &quot;microsoft.graph.automaticRepliesMailTips&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.automaticRepliesMailTips")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;automaticReplies&quot; property, of type &quot;microsoft.graph.automaticRepliesMailTips&quot;.")]
        public System.Object automaticReplies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailboxFull&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;mailboxFull&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean mailboxFull { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customMailTip&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;customMailTip&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String customMailTip { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalMemberCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;externalMemberCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 externalMemberCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalMemberCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;totalMemberCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalMemberCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deliveryRestricted&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;deliveryRestricted&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deliveryRestricted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isModerated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;isModerated&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isModerated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recipientScope&quot; property, of type &quot;microsoft.graph.recipientScopeType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;internal&apos;, &apos;external&apos;, &apos;externalPartner&apos;, &apos;externalNonPartner&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.recipientScopeType")]
        [Selectable]
        [ValidateSet(@"none", @"internal", @"external", @"externalPartner", @"externalNonPartner")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;recipientScope&quot; property, of type &quot;microsoft.graph.recipientScopeType&quot;.")]
        public System.String recipientScope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recipientSuggestions&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;recipientSuggestions&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] recipientSuggestions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maxMessageSize&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;maxMessageSize&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 maxMessageSize { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.mailTipsError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailTipsError")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTips", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.mailTipsError&quot;.")]
        public System.Object error { get; set; }
    }
}