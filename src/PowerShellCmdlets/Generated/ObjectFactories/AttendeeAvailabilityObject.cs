// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.attendeeAvailability&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.attendeeAvailability&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AttendeeAvailabilityObject", DefaultParameterSetName = @"#microsoft.graph.attendeeAvailability")]
    [ODataType("microsoft.graph.attendeeAvailability")]
    public class New_AttendeeAvailabilityObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;attendee&quot; property, of type &quot;microsoft.graph.attendeeBase&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attendeeAvailability&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.attendeeBase")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendeeAvailability", HelpMessage = @"The &quot;attendee&quot; property, of type &quot;microsoft.graph.attendeeBase&quot;.")]
        public System.Object attendee { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;availability&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attendeeAvailability&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;free&apos;, &apos;tentative&apos;, &apos;busy&apos;, &apos;oof&apos;, &apos;workingElsewhere&apos;, &apos;unknown&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyStatus")]
        [Selectable]
        [ValidateSet(@"free", @"tentative", @"busy", @"oof", @"workingElsewhere", @"unknown")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendeeAvailability", HelpMessage = @"The &quot;availability&quot; property, of type &quot;microsoft.graph.freeBusyStatus&quot;.")]
        public System.String availability { get; set; }
    }
}