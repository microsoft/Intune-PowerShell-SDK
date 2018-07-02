// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.extension&quot; objects.</para>
    ///     <para type="description">GET ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.extension&quot; objects in the &quot;extensions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Calendars_CalendarView_Instances_Extensions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.extension")]
    [ResourceIdPropertyName("extensionId")]
    [ResourceReference]
    public class Get_Me_Calendars_CalendarView_Instances_Extensions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

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
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.openTypeExtension")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions/{extensionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">POST ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.extension&quot; object to the &quot;extensions&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Calendars_CalendarView_Instances_Extensions", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.extension")]
    [ResourceReference]
    public class New_Me_Calendars_CalendarView_Instances_Extensions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.openTypeExtension")]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.")]
        public System.Management.Automation.SwitchParameter openTypeExtension { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.extension&quot;.</para>
    ///     <para type="description">PATCH ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Calendars_CalendarView_Instances_Extensions", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.extension")]
    [ResourceIdPropertyName("extensionId")]
    public class Update_Me_Calendars_CalendarView_Instances_Extensions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.openTypeExtension")]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.")]
        public System.Management.Automation.SwitchParameter openTypeExtension { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions/{extensionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">DELETE ~/me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions/extensionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.extension&quot; object from the &quot;extensions&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Calendars_CalendarView_Instances_Extensions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.extension")]
    [ResourceIdPropertyName("extensionId")]
    public class Remove_Me_Calendars_CalendarView_Instances_Extensions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.event&quot; object in the &quot;instances&quot; collection.")]
        public System.String instanceId { get; set; }

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
            return $"me/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/extensions/{extensionId}";
        }
    }
}