// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.calendar&quot; objects.</para>
    ///     <para type="description">GET ~/me/calendars</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.calendar&quot; objects in the &quot;calendars&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Calendars", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.calendar")]
    [ResourceIdPropertyName("calendarId")]
    [ResourceReference]
    public class Get_Me_Calendars : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendarColor")]
        [Selectable]
        [Sortable]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean canShare { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean canViewPrivateItems { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean canEdit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Sortable]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.calendar&quot; object.</para>
    ///     <para type="description">POST ~/me/calendars</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.calendar&quot; object to the &quot;calendars&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Calendars", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.calendar")]
    [ODataType("microsoft.graph.calendar")]
    [ResourceReference]
    public class New_Me_Calendars : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;lightBlue&apos;, &apos;lightGreen&apos;, &apos;lightOrange&apos;, &apos;lightGray&apos;, &apos;lightYellow&apos;, &apos;lightTeal&apos;, &apos;lightPink&apos;, &apos;lightBrown&apos;, &apos;lightRed&apos;, &apos;maxColor&apos;, &apos;auto&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.calendarColor")]
        [Selectable]
        [ValidateSet(@"lightBlue", @"lightGreen", @"lightOrange", @"lightGray", @"lightYellow", @"lightTeal", @"lightPink", @"lightBrown", @"lightRed", @"maxColor", @"auto")]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canShare { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canViewPrivateItems { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canEdit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.calendar&quot;.</para>
    ///     <para type="description">PATCH ~/me/calendars</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Calendars", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.calendar")]
    [ODataType("microsoft.graph.calendar")]
    [ResourceIdPropertyName("calendarId")]
    public class Update_Me_Calendars : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;lightBlue&apos;, &apos;lightGreen&apos;, &apos;lightOrange&apos;, &apos;lightGray&apos;, &apos;lightYellow&apos;, &apos;lightTeal&apos;, &apos;lightPink&apos;, &apos;lightBrown&apos;, &apos;lightRed&apos;, &apos;maxColor&apos;, &apos;auto&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.calendarColor")]
        [Selectable]
        [ValidateSet(@"lightBlue", @"lightGreen", @"lightOrange", @"lightGray", @"lightYellow", @"lightTeal", @"lightPink", @"lightBrown", @"lightRed", @"maxColor", @"auto")]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canShare { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canViewPrivateItems { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canEdit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendar", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.calendar&quot; object.</para>
    ///     <para type="description">DELETE ~/me/calendars/calendarId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.calendar&quot; object from the &quot;calendars&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Calendars", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.calendar")]
    [ResourceIdPropertyName("calendarId")]
    public class Remove_Me_Calendars : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendar&quot; object in the &quot;calendars&quot; collection.")]
        public System.String calendarId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendars/{calendarId}";
        }
    }
}