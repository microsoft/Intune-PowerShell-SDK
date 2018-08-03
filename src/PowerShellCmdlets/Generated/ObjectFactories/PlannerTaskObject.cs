// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerTask&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerTask&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerTaskObject", DefaultParameterSetName = @"#microsoft.graph.plannerTask")]
    [ODataType("microsoft.graph.plannerTask")]
    public class New_PlannerTaskObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object CreatedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;planId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PlanId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;bucketId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BucketId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OrderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assigneePriority&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;assigneePriority&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AssigneePriority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PercentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset StartDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dueDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;dueDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset DueDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasDescription&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;hasDescription&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean HasDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;automatic&apos;, &apos;noPreview&apos;, &apos;checklist&apos;, &apos;description&apos;, &apos;reference&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPreviewType")]
        [Selectable]
        [ValidateSet(@"automatic", @"noPreview", @"checklist", @"description", @"reference")]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.")]
        public System.String PreviewType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CompletedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;completedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;completedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object CompletedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;referenceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;referenceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ReferenceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;checklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;checklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ChecklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeChecklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;activeChecklistItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ActiveChecklistItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedCategories&quot; property, of type &quot;microsoft.graph.plannerAppliedCategories&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAppliedCategories")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;appliedCategories&quot; property, of type &quot;microsoft.graph.plannerAppliedCategories&quot;.")]
        public System.Object AppliedCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.plannerAssignments&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignments")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.plannerAssignments&quot;.")]
        public System.Object Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;conversationThreadId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ConversationThreadId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerTaskDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTaskDetails")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;details&quot; property, of type &quot;microsoft.graph.plannerTaskDetails&quot;.")]
        public System.Object Details { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedToTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerAssignedToTaskBoardTaskFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;assignedToTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot;.")]
        public System.Object AssignedToTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;progressTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerProgressTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerProgressTaskBoardTaskFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;progressTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerProgressTaskBoardTaskFormat&quot;.")]
        public System.Object ProgressTaskBoardFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bucketTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTask&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucketTaskBoardTaskFormat")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerTask", HelpMessage = @"The &quot;bucketTaskBoardFormat&quot; property, of type &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot;.")]
        public System.Object BucketTaskBoardFormat { get; set; }
    }
}