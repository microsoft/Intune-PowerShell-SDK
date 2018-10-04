// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.standardTimeZoneOffset&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.standardTimeZoneOffset&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "StandardTimeZoneOffsetObject", DefaultParameterSetName = @"microsoft.graph.standardTimeZoneOffset")]
    [ODataType("microsoft.graph.standardTimeZoneOffset")]
    public class New_StandardTimeZoneOffsetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.standardTimeZoneOffset")]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.")]
        public System.Management.Automation.SwitchParameter standardTimeZoneOffset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;time&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", HelpMessage = @"The &quot;time&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;time&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan time { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dayOccurrence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", HelpMessage = @"The &quot;dayOccurrence&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;dayOccurrence&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 dayOccurrence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dayOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos;, &apos;saturday&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.dayOfWeek")]
        [Selectable]
        [ValidateSet(@"sunday", @"monday", @"tuesday", @"wednesday", @"thursday", @"friday", @"saturday")]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", HelpMessage = @"The &quot;dayOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;dayOfWeek&quot; property, of type &quot;microsoft.graph.dayOfWeek&quot;.")]
        public System.String dayOfWeek { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;month&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", HelpMessage = @"The &quot;month&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;month&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 month { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.standardTimeZoneOffset&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.standardTimeZoneOffset", HelpMessage = @"The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 year { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.daylightTimeZoneOffset&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.daylightTimeZoneOffset")]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.daylightTimeZoneOffset&quot; type.")]
        public System.Management.Automation.SwitchParameter daylightTimeZoneOffset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daylightBias&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.daylightTimeZoneOffset&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.daylightTimeZoneOffset", HelpMessage = @"The &quot;daylightBias&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 daylightBias { get; set; }
    }
}