// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsTab&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsTab&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsTabObject", DefaultParameterSetName = @"microsoft.graph.teamsTab")]
    [ODataType("microsoft.graph.teamsTab")]
    public class New_TeamsTabObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTab&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTab", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTab&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTab", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configuration&quot; property, of type &quot;microsoft.graph.teamsTabConfiguration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTab&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsTabConfiguration")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTab", HelpMessage = @"The &quot;configuration&quot; property, of type &quot;microsoft.graph.teamsTabConfiguration&quot;.")]
        public System.Object configuration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;teamsApp&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTab&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsApp")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTab", HelpMessage = @"The &quot;teamsApp&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.")]
        public System.Object teamsApp { get; set; }
    }
}