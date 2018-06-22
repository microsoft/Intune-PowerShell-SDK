// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingCanada&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingCanada&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingCanadaObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingCanada")]
    [ODataType("microsoft.graph.mediaContentRatingCanada")]
    public class New_MediaContentRatingCanadaObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingCanadaMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingCanada&quot; type.</para>
        ///     <para type="description">Movies rating selected for Canada</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;agesAbove14&apos;, &apos;agesAbove18&apos;, &apos;restricted&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingCanadaMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"agesAbove14", @"agesAbove18", @"restricted")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingCanada", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingCanadaMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingCanadaTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingCanada&quot; type.</para>
        ///     <para type="description">TV rating selected for Canada</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;children&apos;, &apos;childrenAbove8&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;agesAbove14&apos;, &apos;agesAbove18&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingCanadaTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"children", @"childrenAbove8", @"general", @"parentalGuidance", @"agesAbove14", @"agesAbove18")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingCanada", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingCanadaTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}