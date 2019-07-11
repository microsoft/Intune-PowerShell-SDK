// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsApp&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsApp&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsAppObject", DefaultParameterSetName = @"microsoft.graph.teamsApp")]
    [ODataType("microsoft.graph.teamsApp")]
    public class New_TeamsAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsApp&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsApp", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String externalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsApp&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;distributionMethod&quot; property, of type &quot;microsoft.graph.teamsAppDistributionMethod&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsApp&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;store&apos;, &apos;organization&apos;, &apos;sideloaded&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAppDistributionMethod")]
        [Selectable]
        [ValidateSet(@"store", @"organization", @"sideloaded", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsApp", HelpMessage = @"The &quot;distributionMethod&quot; property, of type &quot;microsoft.graph.teamsAppDistributionMethod&quot;.")]
        public System.String distributionMethod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDefinitions&quot; property, of type &quot;microsoft.graph.teamsAppDefinition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsApp&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAppDefinition")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsApp", HelpMessage = @"The &quot;appDefinitions&quot; property, of type &quot;microsoft.graph.teamsAppDefinition&quot;.")]
        public System.Object[] appDefinitions { get; set; }
    }
}