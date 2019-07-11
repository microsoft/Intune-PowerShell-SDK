// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsTabConfiguration&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsTabConfiguration&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsTabConfigurationObject", DefaultParameterSetName = @"microsoft.graph.teamsTabConfiguration")]
    [ODataType("microsoft.graph.teamsTabConfiguration")]
    public class New_TeamsTabConfigurationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;entityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTabConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTabConfiguration", HelpMessage = @"The &quot;entityId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String entityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTabConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTabConfiguration", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;removeUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTabConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTabConfiguration", HelpMessage = @"The &quot;removeUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String removeUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;websiteUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsTabConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsTabConfiguration", HelpMessage = @"The &quot;websiteUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String websiteUrl { get; set; }
    }
}