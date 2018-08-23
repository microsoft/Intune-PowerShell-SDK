// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerAssignment&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerAssignmentObject", DefaultParameterSetName = @"microsoft.graph.plannerAssignment")]
    [ODataType("microsoft.graph.plannerAssignment")]
    public class New_PlannerAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;assignedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerAssignment&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerAssignment", HelpMessage = @"The &quot;assignedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object assignedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerAssignment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerAssignment", HelpMessage = @"The &quot;assignedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset assignedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerAssignment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerAssignment", HelpMessage = @"The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String orderHint { get; set; }
    }
}