// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerUser&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerUser&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerUserObject", DefaultParameterSetName = @"microsoft.graph.plannerUser")]
    [ODataType("microsoft.graph.plannerUser")]
    public class New_PlannerUserObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerUser", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlan")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerUser", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        public System.Object[] plans { get; set; }
    }
}