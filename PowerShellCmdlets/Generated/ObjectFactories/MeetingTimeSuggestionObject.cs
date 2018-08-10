// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.meetingTimeSuggestion&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.meetingTimeSuggestion&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MeetingTimeSuggestionObject", DefaultParameterSetName = @"#microsoft.graph.meetingTimeSuggestion")]
    [ODataType("microsoft.graph.meetingTimeSuggestion")]
    public class New_MeetingTimeSuggestionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;meetingTimeSlot&quot; property, of type &quot;microsoft.graph.timeSlot&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.timeSlot")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;meetingTimeSlot&quot; property, of type &quot;microsoft.graph.timeSlot&quot;.")]
        public System.Object meetingTimeSlot { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;confidence&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;confidence&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double confidence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizerAvailability&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;free&apos;, &apos;tentative&apos;, &apos;busy&apos;, &apos;oof&apos;, &apos;workingElsewhere&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyStatus")]
        [Selectable]
        [ValidateSet(@"free", @"tentative", @"busy", @"oof", @"workingElsewhere", @"unknown")]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;organizerAvailability&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.")]
        public System.String organizerAvailability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attendeeAvailability&quot; property, of type &quot;microsoft.graph.attendeeAvailability&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attendeeAvailability")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;attendeeAvailability&quot; property, of type &quot;microsoft.graph.attendeeAvailability&quot;.")]
        public System.Object[] attendeeAvailability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locations&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;locations&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object[] locations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;suggestionReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.meetingTimeSuggestion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.meetingTimeSuggestion", HelpMessage = @"The &quot;suggestionReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String suggestionReason { get; set; }
    }
}