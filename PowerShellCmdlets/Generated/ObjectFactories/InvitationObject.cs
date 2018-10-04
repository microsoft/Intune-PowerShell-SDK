// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.invitation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.invitation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "InvitationObject", DefaultParameterSetName = @"microsoft.graph.invitation")]
    [ODataType("microsoft.graph.invitation")]
    public class New_InvitationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;invitedUserDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;invitedUserDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String invitedUserDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitedUserType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;invitedUserType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String invitedUserType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitedUserEmailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;invitedUserEmailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String invitedUserEmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitedUserMessageInfo&quot; property, of type &quot;microsoft.graph.invitedUserMessageInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.invitedUserMessageInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;invitedUserMessageInfo&quot; property, of type &quot;microsoft.graph.invitedUserMessageInfo&quot;.")]
        public System.Object invitedUserMessageInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sendInvitationMessage&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;sendInvitationMessage&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean sendInvitationMessage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inviteRedirectUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;inviteRedirectUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String inviteRedirectUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inviteRedeemUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;inviteRedeemUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String inviteRedeemUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;status&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitedUser&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.invitation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.invitation", HelpMessage = @"The &quot;invitedUser&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object invitedUser { get; set; }
    }
}