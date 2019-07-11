// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.scheduleItem&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.scheduleItem&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ScheduleItemObject", DefaultParameterSetName = @"microsoft.graph.scheduleItem")]
    [ODataType("microsoft.graph.scheduleItem")]
    public class New_ScheduleItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;start&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object start { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;end&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object end { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isPrivate&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;isPrivate&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isPrivate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;free&apos;, &apos;tentative&apos;, &apos;busy&apos;, &apos;oof&apos;, &apos;workingElsewhere&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyStatus")]
        [Selectable]
        [ValidateSet(@"free", @"tentative", @"busy", @"oof", @"workingElsewhere", @"unknown")]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleItem", HelpMessage = @"The &quot;location&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String location { get; set; }
    }
}