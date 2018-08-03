// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerGroup&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerGroup&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerGroupObject", DefaultParameterSetName = @"#microsoft.graph.plannerGroup")]
    [ODataType("microsoft.graph.plannerGroup")]
    public class New_PlannerGroupObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerGroup&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerGroup", HelpMessage = @"The &quot;plans&quot; property, of type &quot;microsoft.graph.plannerPlan&quot;.")]
        public System.Object[] Plans { get; set; }
    }
}