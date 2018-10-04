// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.reminder&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.reminder&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ReminderObject", DefaultParameterSetName = @"microsoft.graph.reminder")]
    [ODataType("microsoft.graph.reminder")]
    public class New_ReminderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;eventId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eventId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventStartTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventStartTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object eventStartTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventEndTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventEndTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object eventEndTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventSubject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventSubject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eventSubject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventLocation&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location", "microsoft.graph.locationConstraintItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventLocation&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object eventLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventWebLink&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;eventWebLink&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String eventWebLink { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;reminderFireTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.reminder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.reminder", HelpMessage = @"The &quot;reminderFireTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object reminderFireTime { get; set; }
    }
}