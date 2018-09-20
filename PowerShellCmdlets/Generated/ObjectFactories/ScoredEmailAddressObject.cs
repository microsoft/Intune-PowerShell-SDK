// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.scoredEmailAddress&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.scoredEmailAddress&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ScoredEmailAddressObject", DefaultParameterSetName = @"microsoft.graph.scoredEmailAddress")]
    [ODataType("microsoft.graph.scoredEmailAddress")]
    public class New_ScoredEmailAddressObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scoredEmailAddress&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scoredEmailAddress", HelpMessage = @"The &quot;address&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;relevanceScore&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scoredEmailAddress&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scoredEmailAddress", HelpMessage = @"The &quot;relevanceScore&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double relevanceScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;selectionLikelihood&quot; property, of type &quot;microsoft.graph.selectionLikelihoodInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scoredEmailAddress&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notSpecified&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.selectionLikelihoodInfo")]
        [Selectable]
        [ValidateSet(@"notSpecified", @"high")]
        [Parameter(ParameterSetName = @"microsoft.graph.scoredEmailAddress", HelpMessage = @"The &quot;selectionLikelihood&quot; property, of type &quot;microsoft.graph.selectionLikelihoodInfo&quot;.")]
        public System.String selectionLikelihood { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ItemId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scoredEmailAddress&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scoredEmailAddress", HelpMessage = @"The &quot;ItemId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ItemId { get; set; }
    }
}