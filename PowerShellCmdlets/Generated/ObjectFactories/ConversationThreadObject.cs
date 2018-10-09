// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.conversationThread&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.conversationThread&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ConversationThreadObject", DefaultParameterSetName = @"microsoft.graph.conversationThread")]
    [ODataType("microsoft.graph.conversationThread")]
    public class New_ConversationThreadObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;toRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] toRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;topic&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;topic&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String topic { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;hasAttachments&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasAttachments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastDeliveredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;lastDeliveredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastDeliveredDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueSenders&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;uniqueSenders&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] uniqueSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient", "microsoft.graph.attendeeBase", "microsoft.graph.attendee")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;ccRecipients&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ccRecipients { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preview&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;preview&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String preview { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isLocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;isLocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isLocked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;posts&quot; property, of type &quot;microsoft.graph.post&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.conversationThread&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.post")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.conversationThread", HelpMessage = @"The &quot;posts&quot; property, of type &quot;microsoft.graph.post&quot;.")]
        public System.Object[] posts { get; set; }
    }
}