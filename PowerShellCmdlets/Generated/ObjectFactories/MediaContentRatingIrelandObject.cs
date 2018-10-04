// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingIreland&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingIreland&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingIrelandObject", DefaultParameterSetName = @"microsoft.graph.mediaContentRatingIreland")]
    [ODataType("microsoft.graph.mediaContentRatingIreland")]
    public class New_MediaContentRatingIrelandObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingIrelandMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingIreland&quot; type.</para>
        ///     <para type="description">Movies rating selected for Ireland</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;agesAbove12&apos;, &apos;agesAbove15&apos;, &apos;agesAbove16&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingIrelandMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"agesAbove12", @"agesAbove15", @"agesAbove16", @"adults")]
        [Parameter(ParameterSetName = @"microsoft.graph.mediaContentRatingIreland", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingIrelandMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingIrelandTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingIreland&quot; type.</para>
        ///     <para type="description">TV rating selected for Ireland</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;children&apos;, &apos;youngAdults&apos;, &apos;parentalSupervision&apos;, &apos;mature&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingIrelandTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"children", @"youngAdults", @"parentalSupervision", @"mature")]
        [Parameter(ParameterSetName = @"microsoft.graph.mediaContentRatingIreland", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingIrelandTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}