// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.calendarGroup&quot; objects.</para>
    ///     <para type="description">GET ~/me/calendarGroups</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.calendarGroup&quot; objects in the &quot;calendarGroups&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_CalendarGroups", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.calendarGroup")]
    [ResourceIdPropertyName("calendarGroupId")]
    [ResourceReference]
    public class Get_Me_CalendarGroups : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        public System.Guid classId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        public System.Object[] calendars { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.calendarGroup&quot; object.</para>
    ///     <para type="description">POST ~/me/calendarGroups</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.calendarGroup&quot; object to the &quot;calendarGroups&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_CalendarGroups", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.calendarGroup")]
    [ODataType("microsoft.graph.calendarGroup")]
    [ResourceReference]
    public class New_Me_CalendarGroups : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid classId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object[] calendars { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.calendarGroup&quot;.</para>
    ///     <para type="description">PATCH ~/me/calendarGroups</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_CalendarGroups", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.calendarGroup")]
    [ODataType("microsoft.graph.calendarGroup")]
    [ResourceIdPropertyName("calendarGroupId")]
    public class Update_Me_CalendarGroups : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;classId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid classId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendarGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.calendarGroup", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object[] calendars { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.calendarGroup&quot; object.</para>
    ///     <para type="description">DELETE ~/me/calendarGroups/calendarGroupId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.calendarGroup&quot; object from the &quot;calendarGroups&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_CalendarGroups", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.calendarGroup")]
    [ResourceIdPropertyName("calendarGroupId")]
    public class Remove_Me_CalendarGroups : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.calendarGroup&quot; object in the &quot;calendarGroups&quot; collection.")]
        public System.String calendarGroupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/calendarGroups/{calendarGroupId}";
        }
    }
}