// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerPlanDetails&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerPlanDetails&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerPlanDetailsObject", DefaultParameterSetName = @"#microsoft.graph.plannerPlanDetails")]
    [ODataType("microsoft.graph.plannerPlanDetails")]
    public class New_PlannerPlanDetailsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;sharedWith&quot; property, of type &quot;microsoft.graph.plannerUserIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlanDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerUserIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlanDetails", HelpMessage = @"The &quot;sharedWith&quot; property, of type &quot;microsoft.graph.plannerUserIds&quot;.")]
        public System.Object SharedWith { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categoryDescriptions&quot; property, of type &quot;microsoft.graph.plannerCategoryDescriptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerPlanDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerCategoryDescriptions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerPlanDetails", HelpMessage = @"The &quot;categoryDescriptions&quot; property, of type &quot;microsoft.graph.plannerCategoryDescriptions&quot;.")]
        public System.Object CategoryDescriptions { get; set; }
    }
}