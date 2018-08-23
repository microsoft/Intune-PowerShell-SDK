// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.meetingTimeSuggestionsResult&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.meetingTimeSuggestionsResult&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MeetingTimeSuggestionsResultObject", DefaultParameterSetName = @"microsoft.graph.meetingTimeSuggestionsResult")]
    [ODataType("microsoft.graph.meetingTimeSuggestionsResult")]
    public class New_MeetingTimeSuggestionsResultObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;meetingTimeSuggestions&quot; property, of type &quot;microsoft.graph.meetingTimeSuggestion&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestionsResult&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.meetingTimeSuggestion")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.meetingTimeSuggestionsResult", HelpMessage = @"The &quot;meetingTimeSuggestions&quot; property, of type &quot;microsoft.graph.meetingTimeSuggestion&quot;.")]
        public System.Object[] meetingTimeSuggestions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emptySuggestionsReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestionsResult&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.meetingTimeSuggestionsResult", HelpMessage = @"The &quot;emptySuggestionsReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String emptySuggestionsReason { get; set; }
    }
}