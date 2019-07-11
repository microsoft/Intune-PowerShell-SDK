// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamMessagingSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamMessagingSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamMessagingSettingsObject", DefaultParameterSetName = @"microsoft.graph.teamMessagingSettings")]
    [ODataType("microsoft.graph.teamMessagingSettings")]
    public class New_TeamMessagingSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowUserEditMessages&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMessagingSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMessagingSettings", HelpMessage = @"The &quot;allowUserEditMessages&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowUserEditMessages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowUserDeleteMessages&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMessagingSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMessagingSettings", HelpMessage = @"The &quot;allowUserDeleteMessages&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowUserDeleteMessages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowOwnerDeleteMessages&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMessagingSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMessagingSettings", HelpMessage = @"The &quot;allowOwnerDeleteMessages&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowOwnerDeleteMessages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowTeamMentions&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMessagingSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMessagingSettings", HelpMessage = @"The &quot;allowTeamMentions&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowTeamMentions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowChannelMentions&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMessagingSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMessagingSettings", HelpMessage = @"The &quot;allowChannelMentions&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowChannelMentions { get; set; }
    }
}