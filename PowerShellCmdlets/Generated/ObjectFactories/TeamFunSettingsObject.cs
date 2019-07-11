// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamFunSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamFunSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamFunSettingsObject", DefaultParameterSetName = @"microsoft.graph.teamFunSettings")]
    [ODataType("microsoft.graph.teamFunSettings")]
    public class New_TeamFunSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowGiphy&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamFunSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamFunSettings", HelpMessage = @"The &quot;allowGiphy&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowGiphy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;giphyContentRating&quot; property, of type &quot;microsoft.graph.giphyRatingType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamFunSettings&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;moderate&apos;, &apos;strict&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.giphyRatingType")]
        [Selectable]
        [ValidateSet(@"moderate", @"strict", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.teamFunSettings", HelpMessage = @"The &quot;giphyContentRating&quot; property, of type &quot;microsoft.graph.giphyRatingType&quot;.")]
        public System.String giphyContentRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowStickersAndMemes&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamFunSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamFunSettings", HelpMessage = @"The &quot;allowStickersAndMemes&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowStickersAndMemes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowCustomMemes&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamFunSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamFunSettings", HelpMessage = @"The &quot;allowCustomMemes&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowCustomMemes { get; set; }
    }
}