// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.event&quot; objects.</para>
    ///     <para type="description">GET ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.event&quot; objects in the &quot;instances&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Calendars_CalendarView_Calendar_Events_Instances", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    [ResourceReference]
    public class Get_Me_Calendars_CalendarView_Calendar_Events_Instances : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalStartTimeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String originalStartTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalEndTimeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String originalEndTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responseStatus&quot; property, of type &quot;microsoft.graph.responseStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.responseStatus")]
        [Selectable]
        [Sortable]
        public System.Object responseStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iCalUId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String iCalUId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;reminderMinutesBeforeStart&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 reminderMinutesBeforeStart { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReminderOn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isReminderOn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;body&quot; property, of type &quot;microsoft.graph.itemBody&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemBody")]
        [Selectable]
        [Sortable]
        public System.Object body { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyPreview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String bodyPreview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;importance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [Sortable]
        public System.String importance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sensitivity&quot; property, of type &quot;microsoft.graph.sensitivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sensitivity")]
        [Selectable]
        [Sortable]
        public System.String sensitivity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Sortable]
        public System.Object start { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;originalStart&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset originalStart { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Sortable]
        public System.Object end { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        [Sortable]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locations&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        public System.Object[] locations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAllDay&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isAllDay { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCancelled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isCancelled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isOrganizer&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isOrganizer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recurrence&quot; property, of type &quot;microsoft.graph.patternedRecurrence&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.patternedRecurrence")]
        [Selectable]
        [Sortable]
        public System.Object recurrence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responseRequested&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean responseRequested { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seriesMasterId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String seriesMasterId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showAs&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyStatus")]
        [Selectable]
        [Sortable]
        public System.String showAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.eventType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.eventType")]
        [Selectable]
        [Sortable]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attendees&quot; property, of type &quot;microsoft.graph.attendee&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attendee")]
        [Selectable]
        public System.Object[] attendees { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizer&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [Sortable]
        public System.Object organizer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String webLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onlineMeetingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String onlineMeetingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;instances&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        public System.Object[] instances { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [Expandable]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attachments&quot; property, of type &quot;microsoft.graph.attachment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attachment")]
        [Selectable]
        [Expandable]
        public System.Object[] attachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] multiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.event&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] categories { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/accept</para>
    ///     <para type="description">The action &quot;microsoft.graph.accept&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_Accept", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_Accept : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.accept&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.accept&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.accept&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.accept&quot; action.")]
        public System.Boolean SendResponse { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId}/accept";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/decline</para>
    ///     <para type="description">The action &quot;microsoft.graph.decline&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_Decline", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_Decline : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.decline&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.decline&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.decline&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.decline&quot; action.")]
        public System.Boolean SendResponse { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId}/decline";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/tentativelyAccept</para>
    ///     <para type="description">The action &quot;microsoft.graph.tentativelyAccept&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_TentativelyAccept", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_TentativelyAccept : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.tentativelyAccept&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;Comment&quot; parameter, which is accepted by the &quot;microsoft.graph.tentativelyAccept&quot; action.")]
        public System.String Comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.tentativelyAccept&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;SendResponse&quot; parameter, which is accepted by the &quot;microsoft.graph.tentativelyAccept&quot; action.")]
        public System.Boolean SendResponse { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId}/tentativelyAccept";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/snoozeReminder</para>
    ///     <para type="description">The action &quot;microsoft.graph.snoozeReminder&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_SnoozeReminder", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_SnoozeReminder : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;NewReminderTime&quot; parameter, which is accepted by the &quot;microsoft.graph.snoozeReminder&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;NewReminderTime&quot; parameter, which is accepted by the &quot;microsoft.graph.snoozeReminder&quot; action.")]
        public System.Object NewReminderTime { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId}/snoozeReminder";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/dismissReminder</para>
    ///     <para type="description">The action &quot;microsoft.graph.dismissReminder&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_DismissReminder", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.event")]
    [ResourceIdPropertyName("instanceId")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_DismissReminder : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/{instanceId}/dismissReminder";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.event&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.event&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Calendars_CalendarView_Calendar_Events_Instances_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.event")]
    public class Invoke_Me_Calendars_CalendarView_Calendar_Events_Instances_Delta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;events&quot; collection.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;calendarView&quot; collection.")]
        public System.String calendarViewId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/calendar/events/{eventId}/instances/delta({this.GetFunctionUrlSegment()})";
        }
    }
}