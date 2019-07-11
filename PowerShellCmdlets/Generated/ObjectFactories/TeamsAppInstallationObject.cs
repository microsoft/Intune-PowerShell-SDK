// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsAppInstallation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsAppInstallation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsAppInstallationObject", DefaultParameterSetName = @"microsoft.graph.teamsAppInstallation")]
    [ODataType("microsoft.graph.teamsAppInstallation")]
    public class New_TeamsAppInstallationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;teamsApp&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAppInstallation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsApp")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAppInstallation", HelpMessage = @"The &quot;teamsApp&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.")]
        public System.Object teamsApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;teamsAppDefinition&quot; property, of type &quot;microsoft.graph.teamsAppDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAppInstallation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAppDefinition")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAppInstallation", HelpMessage = @"The &quot;teamsAppDefinition&quot; property, of type &quot;microsoft.graph.teamsAppDefinition&quot;.")]
        public System.Object teamsAppDefinition { get; set; }
    }
}