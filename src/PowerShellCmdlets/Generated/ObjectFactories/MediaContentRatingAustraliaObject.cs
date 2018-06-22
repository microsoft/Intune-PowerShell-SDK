// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingAustralia&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingAustralia&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingAustraliaObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingAustralia")]
    [ODataType("microsoft.graph.mediaContentRatingAustralia")]
    public class New_MediaContentRatingAustraliaObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingAustraliaMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingAustralia&quot; type.</para>
        ///     <para type="description">Movies rating selected for Australia</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;mature&apos;, &apos;agesAbove15&apos;, &apos;agesAbove18&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingAustraliaMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"mature", @"agesAbove15", @"agesAbove18")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingAustralia", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingAustraliaMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingAustraliaTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingAustralia&quot; type.</para>
        ///     <para type="description">TV rating selected for Australia</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;preschoolers&apos;, &apos;children&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;mature&apos;, &apos;agesAbove15&apos;, &apos;agesAbove15AdultViolence&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingAustraliaTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"preschoolers", @"children", @"general", @"parentalGuidance", @"mature", @"agesAbove15", @"agesAbove15AdultViolence")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingAustralia", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingAustraliaTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}