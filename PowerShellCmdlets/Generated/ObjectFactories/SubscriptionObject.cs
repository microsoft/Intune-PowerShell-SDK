// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.subscription&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.subscription&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SubscriptionObject", DefaultParameterSetName = @"microsoft.graph.subscription")]
    [ODataType("microsoft.graph.subscription")]
    public class New_SubscriptionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;resource&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;resource&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resource { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;changeType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;changeType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String changeType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;clientState&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;clientState&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String clientState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;notificationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String notificationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;applicationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String applicationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;creatorId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscription&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.subscription", HelpMessage = @"The &quot;creatorId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String creatorId { get; set; }
    }
}