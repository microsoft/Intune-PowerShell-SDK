// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.recurrencePattern&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.recurrencePattern&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RecurrencePatternObject", DefaultParameterSetName = @"#microsoft.graph.recurrencePattern")]
    [ODataType("microsoft.graph.recurrencePattern")]
    public class New_RecurrencePatternObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.recurrencePatternType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos;, &apos;relativeMonthly&apos;, &apos;absoluteYearly&apos;, &apos;relativeYearly&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.recurrencePatternType")]
        [Selectable]
        [ValidateSet(@"daily", @"weekly", @"absoluteMonthly", @"relativeMonthly", @"absoluteYearly", @"relativeYearly")]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.recurrencePatternType&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;interval&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;interval&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 interval { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;month&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;month&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 month { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dayOfMonth&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;dayOfMonth&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 dayOfMonth { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daysOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos;, &apos;saturday&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.dayOfWeek")]
        [Selectable]
        [ValidateSet(@"sunday", @"monday", @"tuesday", @"wednesday", @"thursday", @"friday", @"saturday")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;daysOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.")]
        public System.String[] daysOfWeek { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstDayOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos;, &apos;saturday&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.dayOfWeek")]
        [Selectable]
        [ValidateSet(@"sunday", @"monday", @"tuesday", @"wednesday", @"thursday", @"friday", @"saturday")]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;firstDayOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.")]
        public System.String firstDayOfWeek { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;microsoft.graph.weekIndex&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrencePattern&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;first&apos;, &apos;second&apos;, &apos;third&apos;, &apos;fourth&apos;, &apos;last&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.weekIndex")]
        [Selectable]
        [ValidateSet(@"first", @"second", @"third", @"fourth", @"last")]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrencePattern", HelpMessage = @"The &quot;index&quot; property, of type &quot;microsoft.graph.weekIndex&quot;.")]
        public System.String index { get; set; }
    }
}