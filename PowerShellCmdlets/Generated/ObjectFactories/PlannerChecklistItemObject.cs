// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerChecklistItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerChecklistItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerChecklistItemObject", DefaultParameterSetName = @"microsoft.graph.plannerChecklistItem")]
    [ODataType("microsoft.graph.plannerChecklistItem")]
    public class New_PlannerChecklistItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;isChecked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerChecklistItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerChecklistItem", HelpMessage = @"The &quot;isChecked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isChecked { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerChecklistItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerChecklistItem", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerChecklistItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerChecklistItem", HelpMessage = @"The &quot;orderHint&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String orderHint { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerChecklistItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerChecklistItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerChecklistItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerChecklistItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }
    }
}