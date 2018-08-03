// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingJapan&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingJapan&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingJapanObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingJapan")]
    [ODataType("microsoft.graph.mediaContentRatingJapan")]
    public class New_MediaContentRatingJapanObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingJapanMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingJapan&quot; type.</para>
        ///     <para type="description">Movies rating selected for Japan</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;agesAbove15&apos;, &apos;agesAbove18&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingJapanMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"agesAbove15", @"agesAbove18")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingJapan", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingJapanMoviesType&quot;.")]
        public System.String MovieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingJapanTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingJapan&quot; type.</para>
        ///     <para type="description">TV rating selected for Japan</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;explicitAllowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingJapanTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"explicitAllowed")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingJapan", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingJapanTelevisionType&quot;.")]
        public System.String TvRating { get; set; }
    }
}