// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.plannerTask&quot; objects.</para>
    ///     <para type="description">GET ~/me/planner/tasks</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.plannerTask&quot; objects in the &quot;tasks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Planner_Tasks", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.plannerTask")]
    [ResourceIdPropertyName("taskId")]
    public class Get_Me_Planner_Tasks : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.")]
        public System.String taskId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String planId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String bucketId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String orderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assigneePriority&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String assigneePriority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 percentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset startDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dueDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset dueDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasDescription&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hasDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPreviewType")]
        [Selectable]
        [Sortable]
        public System.String previewType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset completedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object completedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;referenceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 referenceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;checklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 checklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeChecklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 activeChecklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedCategories&quot; property, of type &quot;microsoft.graph.plannerAppliedCategories&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAppliedCategories")]
        [Selectable]
        [Sortable]
        public System.Object appliedCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.plannerAssignments&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignments")]
        [Selectable]
        [Sortable]
        public System.Object assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String conversationThreadId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerTaskDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTaskDetails")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object details { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedToTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignedToTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object assignedToTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;progressTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerProgressTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerProgressTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object progressTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucketTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object bucketTaskBoardFormat { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/tasks/{taskId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.plannerTask&quot; object references.</para>
    ///     <para type="description">GET ~/me/planner/tasks/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.plannerTask&quot; object references in the &quot;tasks&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Planner_TasksReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.plannerTask")]
    [ResourceIdPropertyName("taskId")]
    public class Get_Me_Planner_TasksReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.")]
        public System.String taskId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String planId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String bucketId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String orderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assigneePriority&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String assigneePriority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 percentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset startDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dueDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset dueDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasDescription&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hasDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPreviewType")]
        [Selectable]
        [Sortable]
        public System.String previewType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset completedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object completedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;referenceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 referenceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;checklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 checklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeChecklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 activeChecklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedCategories&quot; property, of type &quot;microsoft.graph.plannerAppliedCategories&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAppliedCategories")]
        [Selectable]
        [Sortable]
        public System.Object appliedCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.plannerAssignments&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignments")]
        [Selectable]
        [Sortable]
        public System.Object assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String conversationThreadId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerTaskDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTaskDetails")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object details { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedToTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignedToTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object assignedToTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;progressTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerProgressTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerProgressTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object progressTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucketTaskBoardTaskFormat")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object bucketTaskBoardFormat { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/tasks/{taskId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;planner&quot; to a &quot;microsoft.graph.plannerTask&quot; object.</para>
    ///     <para type="description">POST ~/me/planner/tasks/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;planner&quot; object to a &quot;task&quot;.</para>
    /// </summary>
    [Cmdlet("New", "Me_Planner_TasksReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.plannerTask")]
    [ResourceIdPropertyName("plannerTaskReferenceUrl")]
    public class New_Me_Planner_TasksReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.plannerTask&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.plannerTask&quot; object.")]
        public System.String plannerTaskReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/tasks/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(plannerTaskReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;planner&quot; to a &quot;microsoft.graph.plannerTask&quot; object.</para>
    ///     <para type="description">DELETE ~/me/planner/tasks/taskId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;planner&quot; object to a &quot;task&quot;.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Planner_TasksReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.plannerTask")]
    [ResourceIdPropertyName("taskId")]
    public class Remove_Me_Planner_TasksReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerTask&quot; object in the &quot;tasks&quot; collection.")]
        public System.String taskId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/tasks/{taskId}/$ref";
        }
    }
}