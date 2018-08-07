// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingUnitedStates&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mediaContentRatingUnitedStates&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MediaContentRatingUnitedStatesObject", DefaultParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedStates")]
    [ODataType("microsoft.graph.mediaContentRatingUnitedStates")]
    public class New_MediaContentRatingUnitedStatesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingUnitedStatesMoviesType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingUnitedStates&quot; type.</para>
        ///     <para type="description">Movies rating selected for United States</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;parentalGuidance13&apos;, &apos;restricted&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingUnitedStatesMoviesType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"general", @"parentalGuidance", @"parentalGuidance13", @"restricted", @"adults")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedStates", HelpMessage = @"The &quot;movieRating&quot; property, of type &quot;microsoft.graph.ratingUnitedStatesMoviesType&quot;.")]
        public System.String movieRating { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingUnitedStatesTelevisionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mediaContentRatingUnitedStates&quot; type.</para>
        ///     <para type="description">TV rating selected for United States</para>
        ///     <para type="description">
        ///          Valid values: &apos;allAllowed&apos;, &apos;allBlocked&apos;, &apos;childrenAll&apos;, &apos;childrenAbove7&apos;, &apos;general&apos;, &apos;parentalGuidance&apos;, &apos;childrenAbove14&apos;, &apos;adults&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.ratingUnitedStatesTelevisionType")]
        [Selectable]
        [ValidateSet(@"allAllowed", @"allBlocked", @"childrenAll", @"childrenAbove7", @"general", @"parentalGuidance", @"childrenAbove14", @"adults")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mediaContentRatingUnitedStates", HelpMessage = @"The &quot;tvRating&quot; property, of type &quot;microsoft.graph.ratingUnitedStatesTelevisionType&quot;.")]
        public System.String tvRating { get; set; }
    }
}