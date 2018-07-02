// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;activity&quot; object.</para>
    ///     <para type="description">GET ~/me/activities/{activityId}/historyItems/{historyItemId}/activity</para>
    ///     <para type="description">Retrieves the &quot;activity&quot; object (which is of type &quot;microsoft.graph.userActivity&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Activities_HistoryItems_Activity", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.userActivity")]
    public class Get_Me_Activities_HistoryItems_Activity : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Sortable]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object contentInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [Expandable]
        public System.Object[] historyItems { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId}/activity";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;activity&quot; object reference.</para>
    ///     <para type="description">GET ~/me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref</para>
    ///     <para type="description">Retrieves the &quot;activity&quot; object reference (which is of type &quot;microsoft.graph.userActivity&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Activities_HistoryItems_ActivityReference", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.userActivity")]
    public class Get_Me_Activities_HistoryItems_ActivityReference : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Sortable]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object contentInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [Expandable]
        public System.Object[] historyItems { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;historyItem&quot; to a &quot;microsoft.graph.userActivity&quot; object.</para>
    ///     <para type="description">PUT ~/me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref</para>
    ///     <para type="description">Creates a reference from the &quot;historyItem&quot; object to a &quot;activity&quot;.</para>
    /// </summary>
    [Cmdlet("New", "Me_Activities_HistoryItems_ActivityReference", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.userActivity")]
    [ResourceIdPropertyName("userActivityReferenceUrl")]
    public class New_Me_Activities_HistoryItems_ActivityReference : PutReferenceToEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
        public System.String historyItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.userActivity&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.userActivity&quot; object.")]
        public System.String userActivityReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;historyItem&quot; to a &quot;microsoft.graph.userActivity&quot; object.</para>
    ///     <para type="description">DELETE ~/me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref</para>
    ///     <para type="description">Removes a reference from the &quot;historyItem&quot; object to a &quot;activity&quot;.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Activities_HistoryItems_ActivityReference", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.userActivity")]
    public class Remove_Me_Activities_HistoryItems_ActivityReference : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.activityHistoryItem&quot; object in the &quot;historyItems&quot; collection.")]
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
            return $"me/activities/{activityId}/historyItems/{historyItemId}/activity/$ref";
        }
    }
}