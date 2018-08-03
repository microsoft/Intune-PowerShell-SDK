// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingUnitedKingdom&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingUnitedKingdom&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingUnitedKingdomObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedKingdom")]
    [ODataType("microsoft.graph.mediaContentRatingUnitedKingdom")]
    public class New_MediaContentRatingUnitedKingdomObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingUnitedKingdomMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingUnitedKingdom&quot; type.</para>
        ///     <para type="description">Movies rating selected for United Kingdom</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;universalChildren&apos;, &apos;parentalGuidance&apos;, &apos;agesAbove12Video&apos;, &apos;agesAbove12Cinema&apos;, &apos;agesAbove15&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingUnitedKingdomMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"universalChildren", @"parentalGuidance", @"agesAbove12Video", @"agesAbove12Cinema", @"agesAbove15", @"adults")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedKingdom", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingUnitedKingdomMoviesType&quot;.")]
        public System.String MovieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingUnitedKingdomTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingUnitedKingdom&quot; type.</para>
        ///     <para type="description">TV rating selected for United Kingdom</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;caution&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingUnitedKingdomTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"caution")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedKingdom", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingUnitedKingdomTelevisionType&quot;.")]
        public System.String TvRating { get; set; }
    }
}