// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingNewZealand&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingNewZealand&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingNewZealandObject", DefaultParameterSetName = @"microsoft.graph.mediaContentRatingNewZealand")]
    [ODataType("microsoft.graph.mediaContentRatingNewZealand")]
    public class New_MediaContentRatingNewZealandObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingNewZealandMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingNewZealand&quot; type.</para>
        ///     <para type="description">Movies rating selected for New Zealand</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;mature&apos;, &apos;agesAbove13&apos;, &apos;agesAbove15&apos;, &apos;agesAbove16&apos;, &apos;agesAbove18&apos;, &apos;restricted&apos;, &apos;agesAbove16Restricted&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingNewZealandMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"mature", @"agesAbove13", @"agesAbove15", @"agesAbove16", @"agesAbove18", @"restricted", @"agesAbove16Restricted")]
        [Parameter(ParameterSetName = @"microsoft.graph.mediaContentRatingNewZealand", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingNewZealandMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingNewZealandTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingNewZealand&quot; type.</para>
        ///     <para type="description">TV rating selected for New Zealand</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingNewZealandTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"adults")]
        [Parameter(ParameterSetName = @"microsoft.graph.mediaContentRatingNewZealand", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingNewZealandTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}