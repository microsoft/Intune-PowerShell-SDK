// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerBucketTaskBoardTaskFormatObject", DefaultParameterSetName = @"microsoft.graph.plannerBucketTaskBoardTaskFormat")]
    [ODataType("microsoft.graph.plannerBucketTaskBoardTaskFormat")]
    public class New_PlannerBucketTaskBoardTaskFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerBucketTaskBoardTaskFormat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerBucketTaskBoardTaskFormat", HelpMessage = @"The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String orderHint { get; set; }
    }
}