// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.timeConstraint&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.timeConstraint&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "TimeConstraintObject", DefaultParameterSetName = @"#microsoft.graph.timeConstraint")]
    [ODataType("microsoft.graph.timeConstraint")]
    public class New_TimeConstraintObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;activityDomain&quot; property, of type &quot;microsoft.graph.activityDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.timeConstraint&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;work&apos;, &apos;personal&apos;, &apos;unrestricted&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.activityDomain")]
        [Selectable]
        [ValidateSet(@"unknown", @"work", @"personal", @"unrestricted")]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeConstraint", HelpMessage = @"The &quot;activityDomain&quot; property, of type &quot;microsoft.graph.activityDomain&quot;.")]
        public System.String activityDomain { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;timeslots&quot; property, of type &quot;microsoft.graph.timeSlot&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.timeConstraint&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.timeSlot")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.timeConstraint", HelpMessage = @"The &quot;timeslots&quot; property, of type &quot;microsoft.graph.timeSlot&quot;.")]
        public System.Object[] timeslots { get; set; }
    }
}