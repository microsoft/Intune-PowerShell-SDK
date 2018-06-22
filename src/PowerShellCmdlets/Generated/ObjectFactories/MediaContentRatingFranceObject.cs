// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingFrance&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingFrance&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingFranceObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingFrance")]
    [ODataType("microsoft.graph.mediaContentRatingFrance")]
    public class New_MediaContentRatingFranceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingFranceMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingFrance&quot; type.</para>
        ///     <para type="description">Movies rating selected for France</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;agesAbove10&apos;, &apos;agesAbove12&apos;, &apos;agesAbove16&apos;, &apos;agesAbove18&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingFranceMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"agesAbove10", @"agesAbove12", @"agesAbove16", @"agesAbove18")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingFrance", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingFranceMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingFranceTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingFrance&quot; type.</para>
        ///     <para type="description">TV rating selected for France</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;agesAbove10&apos;, &apos;agesAbove12&apos;, &apos;agesAbove16&apos;, &apos;agesAbove18&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingFranceTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"agesAbove10", @"agesAbove12", @"agesAbove16", @"agesAbove18")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingFrance", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingFranceTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}