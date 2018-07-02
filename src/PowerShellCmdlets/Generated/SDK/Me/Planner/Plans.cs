// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.plannerPlan&quot; objects.</para>
    ///     <para type="description">GET ~/me/planner/plans</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.plannerPlan&quot; objects in the &quot;plans&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Planner_Plans", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.plannerPlan")]
    [ResourceIdPropertyName("planId")]
    public class Get_Me_Planner_Plans : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.")]
        public System.String planId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [Expandable]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;buckets&quot; property, of type &quot;microsoft.graph.plannerBucket&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucket")]
        [Selectable]
        [Expandable]
        public System.Object[] buckets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerPlanDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlanDetails")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object details { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/plans/{planId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.plannerPlan&quot; object references.</para>
    ///     <para type="description">GET ~/me/planner/plans/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.plannerPlan&quot; object references in the &quot;plans&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Planner_PlansReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.plannerPlan")]
    [ResourceIdPropertyName("planId")]
    public class Get_Me_Planner_PlansReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.")]
        public System.String planId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [Expandable]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;buckets&quot; property, of type &quot;microsoft.graph.plannerBucket&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucket")]
        [Selectable]
        [Expandable]
        public System.Object[] buckets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerPlanDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlanDetails")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object details { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/plans/{planId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;planner&quot; to a &quot;microsoft.graph.plannerPlan&quot; object.</para>
    ///     <para type="description">POST ~/me/planner/plans/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;planner&quot; object to a &quot;plan&quot;.</para>
    /// </summary>
    [Cmdlet("New", "Me_Planner_PlansReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.plannerPlan")]
    [ResourceIdPropertyName("plannerPlanReferenceUrl")]
    public class New_Me_Planner_PlansReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.plannerPlan&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.plannerPlan&quot; object.")]
        public System.String plannerPlanReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/plans/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(plannerPlanReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;planner&quot; to a &quot;microsoft.graph.plannerPlan&quot; object.</para>
    ///     <para type="description">DELETE ~/me/planner/plans/planId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;planner&quot; object to a &quot;plan&quot;.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Planner_PlansReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.plannerPlan")]
    [ResourceIdPropertyName("planId")]
    public class Remove_Me_Planner_PlansReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.plannerPlan&quot; object in the &quot;plans&quot; collection.")]
        public System.String planId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner/plans/{planId}/$ref";
        }
    }
}