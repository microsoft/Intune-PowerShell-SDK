// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingGermany&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingGermany&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingGermanyObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingGermany")]
    [ODataType("microsoft.graph.mediaContentRatingGermany")]
    public class New_MediaContentRatingGermanyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingGermanyMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingGermany&quot; type.</para>
        ///     <para type="description">Movies rating selected for Germany</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;agesAbove6&apos;, &apos;agesAbove12&apos;, &apos;agesAbove16&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingGermanyMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"agesAbove6", @"agesAbove12", @"agesAbove16", @"adults")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingGermany", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingGermanyMoviesType&quot;.")]
        public System.String MovieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingGermanyTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingGermany&quot; type.</para>
        ///     <para type="description">TV rating selected for Germany</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;agesAbove6&apos;, &apos;agesAbove12&apos;, &apos;agesAbove16&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingGermanyTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"agesAbove6", @"agesAbove12", @"agesAbove16", @"adults")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingGermany", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingGermanyTelevisionType&quot;.")]
        public System.String TvRating { get; set; }
    }
}