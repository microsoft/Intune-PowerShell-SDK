// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.timeSlot&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.timeSlot&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "TimeSlotObject", DefaultParameterSetName = @"#microsoft.graph.timeSlot")]
    [ODataType("microsoft.graph.timeSlot")]
    public class New_TimeSlotObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.timeSlot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeSlot", HelpMessage = @"The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object start { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.timeSlot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeSlot", HelpMessage = @"The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object end { get; set; }
    }
}