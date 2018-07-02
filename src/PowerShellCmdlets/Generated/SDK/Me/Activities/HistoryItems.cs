// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.activityHistoryItem&quot; objects.</para>
    ///     <para type="description">GET ~/me/activities/{activityId}/historyItems</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.activityHistoryItem&quot; objects in the &quot;historyItems&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Activities_HistoryItems", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.activityHistoryItem")]
    [ResourceIdPropertyName("historyItemId")]
    [ResourceReference]
    public class Get_Me_Activities_HistoryItems : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 activeDurationSeconds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastActiveDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset startedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object activity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.activityHistoryItem&quot; object.</para>
    ///     <para type="description">POST ~/me/activities/{activityId}/historyItems</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.activityHistoryItem&quot; object to the &quot;historyItems&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Activities_HistoryItems", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.activityHistoryItem")]
    [ODataType("microsoft.graph.activityHistoryItem")]
    [ResourceReference]
    public class New_Me_Activities_HistoryItems : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 activeDurationSeconds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActiveDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset startedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        public System.Object activity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.activityHistoryItem&quot;.</para>
    ///     <para type="description">PATCH ~/me/activities/{activityId}/historyItems</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Activities_HistoryItems", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.activityHistoryItem")]
    [ODataType("microsoft.graph.activityHistoryItem")]
    [ResourceIdPropertyName("historyItemId")]
    public class Update_Me_Activities_HistoryItems : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activeDurationSeconds&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 activeDurationSeconds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastActiveDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActiveDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;startedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset startedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.activityHistoryItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.activityHistoryItem", HelpMessage = @"The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activity&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        public System.Object activity { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.activityHistoryItem&quot; object.</para>
    ///     <para type="description">DELETE ~/me/activities/{activityId}/historyItems/historyItemId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.activityHistoryItem&quot; object from the &quot;historyItems&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Activities_HistoryItems", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.activityHistoryItem")]
    [ResourceIdPropertyName("historyItemId")]
    public class Remove_Me_Activities_HistoryItems : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId}";
        }
    }
}