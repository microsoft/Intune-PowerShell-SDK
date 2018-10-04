// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.invitedUserMessageInfo&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.invitedUserMessageInfo&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "InvitedUserMessageInfoObject", DefaultParameterSetName = @"microsoft.graph.invitedUserMessageInfo")]
    [ODataType("microsoft.graph.invitedUserMessageInfo")]
    public class New_InvitedUserMessageInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitedUserMessageInfo&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.invitedUserMessageInfo", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitedUserMessageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitedUserMessageInfo", HelpMessage = @"The &quot;messageLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String messageLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customizedMessageBody&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitedUserMessageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitedUserMessageInfo", HelpMessage = @"The &quot;customizedMessageBody&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String customizedMessageBody { get; set; }
    }
}