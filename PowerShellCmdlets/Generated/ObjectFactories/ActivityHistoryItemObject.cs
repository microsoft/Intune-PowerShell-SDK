// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.activityHistoryItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.activityHistoryItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ActivityHistoryItemObject", DefaultParameterSetName = @"microsoft.graph.activityHistoryItem")]
    [ODataType("microsoft.graph.activityHistoryItem")]
    public class New_ActivityHistoryItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;active&apos;, &apos;updated&apos;, &apos;deleted&apos;, &apos;ignored&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [ValidateSet(@"active", @"updated", @"deleted", @"ignored", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 activeDurationSeconds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActiveDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset startedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        public System.Object activity { get; set; }
    }
}