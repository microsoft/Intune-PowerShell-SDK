// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sharingInvitation&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sharingInvitation&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharingInvitationObject", DefaultParameterSetName = @"#microsoft.graph.sharingInvitation")]
    [ODataType("microsoft.graph.sharingInvitation")]
    public class New_SharingInvitationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;email&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingInvitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingInvitation", HelpMessage = @"The &quot;email&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String email { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingInvitation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingInvitation", HelpMessage = @"The &quot;invitedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object invitedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redeemedBy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingInvitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingInvitation", HelpMessage = @"The &quot;redeemedBy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String redeemedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;signInRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingInvitation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingInvitation", HelpMessage = @"The &quot;signInRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean signInRequired { get; set; }
    }
}