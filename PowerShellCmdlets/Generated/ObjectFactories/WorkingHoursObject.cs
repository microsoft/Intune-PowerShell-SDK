// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workingHours&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workingHours&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkingHoursObject", DefaultParameterSetName = @"microsoft.graph.workingHours")]
    [ODataType("microsoft.graph.workingHours")]
    public class New_WorkingHoursObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;daysOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workingHours&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos;, &apos;saturday&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.dayOfWeek")]
        [Selectable]
        [ValidateSet(@"sunday", @"monday", @"tuesday", @"wednesday", @"thursday", @"friday", @"saturday")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.workingHours", HelpMessage = @"The &quot;daysOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.")]
        public System.String[] daysOfWeek { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workingHours&quot; type.</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workingHours", HelpMessage = @"The &quot;startTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan startTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workingHours&quot; type.</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workingHours", HelpMessage = @"The &quot;endTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan endTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;timeZone&quot; property, of type &quot;microsoft.graph.timeZoneBase&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workingHours&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.timeZoneBase", "microsoft.graph.customTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workingHours", HelpMessage = @"The &quot;timeZone&quot; property, of type &quot;microsoft.graph.timeZoneBase&quot;.")]
        public System.Object timeZone { get; set; }
    }
}