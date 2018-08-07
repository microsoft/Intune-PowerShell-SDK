// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.assignedPlan&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.assignedPlan&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AssignedPlanObject", DefaultParameterSetName = @"#microsoft.graph.assignedPlan")]
    [ODataType("microsoft.graph.assignedPlan")]
    public class New_AssignedPlanObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;assignedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedPlan", HelpMessage = @"The &quot;assignedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset assignedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedPlan", HelpMessage = @"The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String capabilityStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;service&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedPlan", HelpMessage = @"The &quot;service&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String service { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlanId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedPlan", HelpMessage = @"The &quot;servicePlanId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid servicePlanId { get; set; }
    }
}