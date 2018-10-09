// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.calendar&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.calendar&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "CalendarObject", DefaultParameterSetName = @"microsoft.graph.calendar")]
    [ODataType("microsoft.graph.calendar")]
    public class New_CalendarObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
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
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.calendarColor&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;changeKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;canShare&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canShare { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;canViewPrivateItems&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canViewPrivateItems { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;canEdit&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean canEdit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calendar&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.calendar", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }
    }
}