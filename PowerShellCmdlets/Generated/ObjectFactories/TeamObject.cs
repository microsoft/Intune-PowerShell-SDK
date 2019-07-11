// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.team&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.team&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamObject", DefaultParameterSetName = @"microsoft.graph.team")]
    [ODataType("microsoft.graph.team")]
    public class New_TeamObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberSettings&quot; property, of type &quot;microsoft.graph.teamMemberSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamMemberSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;memberSettings&quot; property, of type &quot;microsoft.graph.teamMemberSettings&quot;.")]
        public System.Object memberSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;guestSettings&quot; property, of type &quot;microsoft.graph.teamGuestSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamGuestSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;guestSettings&quot; property, of type &quot;microsoft.graph.teamGuestSettings&quot;.")]
        public System.Object guestSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messagingSettings&quot; property, of type &quot;microsoft.graph.teamMessagingSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamMessagingSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;messagingSettings&quot; property, of type &quot;microsoft.graph.teamMessagingSettings&quot;.")]
        public System.Object messagingSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;funSettings&quot; property, of type &quot;microsoft.graph.teamFunSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamFunSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;funSettings&quot; property, of type &quot;microsoft.graph.teamFunSettings&quot;.")]
        public System.Object funSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isArchived&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;isArchived&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isArchived { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;channels&quot; property, of type &quot;microsoft.graph.channel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.channel")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;channels&quot; property, of type &quot;microsoft.graph.channel&quot;.")]
        public System.Object[] channels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedApps&quot; property, of type &quot;microsoft.graph.teamsAppInstallation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAppInstallation")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;installedApps&quot; property, of type &quot;microsoft.graph.teamsAppInstallation&quot;.")]
        public System.Object[] installedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.teamsAsyncOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.team&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAsyncOperation")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.team", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.teamsAsyncOperation&quot;.")]
        public System.Object[] operations { get; set; }
    }
}