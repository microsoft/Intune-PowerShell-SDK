// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.recipient&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.recipient&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RecipientObject", DefaultParameterSetName = @"#microsoft.graph.recipient")]
    [ODataType("microsoft.graph.recipient")]
    public class New_RecipientObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.recipient&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.recipient")]
        [Parameter(ParameterSetName = @"#microsoft.graph.recipient", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.recipient&quot; type.")]
        public System.Management.Automation.SwitchParameter Recipient { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recipient&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recipient", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendeeBase", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendee", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object EmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.attendeeBase&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.attendeeBase")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendeeBase", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.attendeeBase&quot; type.")]
        public System.Management.Automation.SwitchParameter AttendeeBase { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.attendeeType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attendeeBase&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;required&apos;, &apos;optional&apos;, &apos;resource&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.attendeeType")]
        [Selectable]
        [ValidateSet(@"required", @"optional", @"resource")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendeeBase", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.attendeeType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendee", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.attendeeType&quot;.")]
        public System.String Type { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.attendee&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.attendee")]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendee", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.attendee&quot; type.")]
        public System.Management.Automation.SwitchParameter Attendee { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.responseStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attendee&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.responseStatus")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attendee", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.responseStatus&quot;.")]
        public System.Object Status { get; set; }
    }
}