// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.timeZoneBase&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.timeZoneBase&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "TimeZoneBaseObject", DefaultParameterSetName = @"#microsoft.graph.timeZoneBase")]
    [ODataType("microsoft.graph.timeZoneBase")]
    public class New_TimeZoneBaseObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.timeZoneBase&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.timeZoneBase")]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeZoneBase", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.timeZoneBase&quot; type.")]
        public System.Management.Automation.SwitchParameter timeZoneBase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.timeZoneBase&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeZoneBase", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.customTimeZone", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.customTimeZone&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.customTimeZone")]
        [Parameter(ParameterSetName = @"#microsoft.graph.customTimeZone", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.customTimeZone&quot; type.")]
        public System.Management.Automation.SwitchParameter customTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bias&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.customTimeZone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.customTimeZone", HelpMessage = @"The &quot;bias&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 bias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardOffset&quot; property, of type &quot;microsoft.graph.standardTimeZoneOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.customTimeZone&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.standardTimeZoneOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.customTimeZone", HelpMessage = @"The &quot;standardOffset&quot; property, of type &quot;microsoft.graph.standardTimeZoneOffset&quot;.")]
        public System.Object standardOffset { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;daylightOffset&quot; property, of type &quot;microsoft.graph.daylightTimeZoneOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.customTimeZone&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.daylightTimeZoneOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.customTimeZone", HelpMessage = @"The &quot;daylightOffset&quot; property, of type &quot;microsoft.graph.daylightTimeZoneOffset&quot;.")]
        public System.Object daylightOffset { get; set; }
    }
}