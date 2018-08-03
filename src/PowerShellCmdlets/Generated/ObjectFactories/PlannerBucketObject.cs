// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerBucket&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerBucket&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerBucketObject", DefaultParameterSetName = @"#microsoft.graph.plannerBucket")]
    [ODataType("microsoft.graph.plannerBucket")]
    public class New_PlannerBucketObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerBucket&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerBucket", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerBucket&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerBucket", HelpMessage = @"The &quot;planId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PlanId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerBucket&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerBucket", HelpMessage = @"The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OrderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerBucket&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerTask")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerBucket", HelpMessage = @"The &quot;tasks&quot; property, of type &quot;microsoft.graph.plannerTask&quot;.")]
        public System.Object[] Tasks { get; set; }
    }
}