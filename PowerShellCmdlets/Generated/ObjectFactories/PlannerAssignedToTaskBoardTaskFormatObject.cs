// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerAssignedToTaskBoardTaskFormatObject", DefaultParameterSetName = @"microsoft.graph.plannerAssignedToTaskBoardTaskFormat")]
    [ODataType("microsoft.graph.plannerAssignedToTaskBoardTaskFormat")]
    public class New_PlannerAssignedToTaskBoardTaskFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;unassignedOrderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerAssignedToTaskBoardTaskFormat", HelpMessage = @"The &quot;unassignedOrderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String unassignedOrderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHintsByAssignee&quot; property, of type &quot;microsoft.graph.plannerOrderHintsByAssignee&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerAssignedToTaskBoardTaskFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerOrderHintsByAssignee")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerAssignedToTaskBoardTaskFormat", HelpMessage = @"The &quot;orderHintsByAssignee&quot; property, of type &quot;microsoft.graph.plannerOrderHintsByAssignee&quot;.")]
        public System.Object orderHintsByAssignee { get; set; }
    }
}