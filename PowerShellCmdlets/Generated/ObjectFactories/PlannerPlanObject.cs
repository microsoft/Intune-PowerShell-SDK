// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerPlan&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerPlan&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerPlanObject", DefaultParameterSetName = @"#microsoft.graph.plannerPlan")]
    [ODataType("microsoft.graph.plannerPlan")]
    public class New_PlannerPlanObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;buckets&quot; property, of type &quot;microsoft.graph.plannerBucket&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerBucket")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;buckets&quot; property, of type &quot;microsoft.graph.plannerBucket&quot;.")]
        public System.Object[] buckets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;details&quot; property, of type &quot;microsoft.graph.plannerPlanDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlan&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlanDetails")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlan", HelpMessage = @"The &quot;details&quot; property, of type &quot;microsoft.graph.plannerPlanDetails&quot;.")]
        public System.Object details { get; set; }
    }
}