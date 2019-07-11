// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsAppDefinition&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsAppDefinition&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsAppDefinitionObject", DefaultParameterSetName = @"microsoft.graph.teamsAppDefinition")]
    [ODataType("microsoft.graph.teamsAppDefinition")]
    public class New_TeamsAppDefinitionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;teamsAppId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAppDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAppDefinition", HelpMessage = @"The &quot;teamsAppId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String teamsAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAppDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAppDefinition", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAppDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAppDefinition", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }
    }
}