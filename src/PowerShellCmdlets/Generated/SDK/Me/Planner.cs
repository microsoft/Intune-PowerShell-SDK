// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;planner&quot; object.</para>
    ///     <para type="description">GET ~/me/planner</para>
    ///     <para type="description">Retrieves the &quot;planner&quot; object (which is of type &quot;microsoft.graph.plannerUser&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Planner", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.plannerUser")]
    [ResourceReference]
    public class Get_Me_Planner : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [Expandable]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlan")]
        [Selectable]
        [Expandable]
        public System.Object[] plans { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.plannerUser&quot; object.</para>
    ///     <para type="description">POST ~/me/planner</para>
    ///     <para type="description">Creates the &quot;planner&quot; object (which is of type &quot;microsoft.graph.plannerUser&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Planner", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.plannerUser")]
    [ODataType("microsoft.graph.plannerUser")]
    [ResourceReference]
    public class New_Me_Planner : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerUser", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerUser", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        public System.Object[] plans { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.plannerUser&quot;.</para>
    ///     <para type="description">PATCH ~/me/planner</para>
    ///     <para type="description">Updates the &quot;planner&quot; object (which is of type &quot;microsoft.graph.plannerUser&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Planner", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.plannerUser")]
    [ODataType("microsoft.graph.plannerUser")]
    public class Update_Me_Planner : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerUser", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        public System.Object[] tasks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerUser", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        public System.Object[] plans { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/planner";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.plannerUser&quot; object.</para>
    ///     <para type="description">DELETE ~/me/planner</para>
    ///     <para type="description">Removes the &quot;planner&quot; object (which is of type &quot;microsoft.graph.plannerUser&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Planner", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.plannerUser")]
    public class Remove_Me_Planner : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/planner";
        }
    }
}