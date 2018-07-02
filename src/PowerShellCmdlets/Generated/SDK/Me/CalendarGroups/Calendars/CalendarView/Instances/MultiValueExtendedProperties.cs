// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; objects.</para>
    ///     <para type="description">GET ~/me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; objects in the &quot;multiValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("multiValueExtendedPropertyId")]
    [ResourceReference]
    public class Get_Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties : GetOrSearchCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.")]
        public System.String multiValueExtendedPropertyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties/{multiValueExtendedPropertyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object.</para>
    ///     <para type="description">POST ~/me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object to the &quot;multiValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
    [ResourceReference]
    public class New_Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties : PostCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
    ///     <para type="description">PATCH ~/me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("multiValueExtendedPropertyId")]
    public class Update_Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.")]
        public System.String multiValueExtendedPropertyId { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] value { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties/{multiValueExtendedPropertyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object.</para>
    ///     <para type="description">DELETE ~/me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties/multiValueExtendedPropertyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object from the &quot;multiValueExtendedProperties&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
    [ResourceIdPropertyName("multiValueExtendedPropertyId")]
    public class Remove_Me_CalendarGroups_Calendars_CalendarView_Instances_MultiValueExtendedProperties : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; object in the &quot;multiValueExtendedProperties&quot; collection.")]
        public System.String multiValueExtendedPropertyId { get; set; }

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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}/calendars/{calendarId}/calendarView/{calendarViewId}/instances/{instanceId}/multiValueExtendedProperties/{multiValueExtendedPropertyId}";
        }
    }
}