// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamMemberSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamMemberSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamMemberSettingsObject", DefaultParameterSetName = @"microsoft.graph.teamMemberSettings")]
    [ODataType("microsoft.graph.teamMemberSettings")]
    public class New_TeamMemberSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowCreateUpdateChannels&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMemberSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMemberSettings", HelpMessage = @"The &quot;allowCreateUpdateChannels&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowCreateUpdateChannels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowDeleteChannels&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMemberSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMemberSettings", HelpMessage = @"The &quot;allowDeleteChannels&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowDeleteChannels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowAddRemoveApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMemberSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMemberSettings", HelpMessage = @"The &quot;allowAddRemoveApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowAddRemoveApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowCreateUpdateRemoveTabs&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMemberSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMemberSettings", HelpMessage = @"The &quot;allowCreateUpdateRemoveTabs&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowCreateUpdateRemoveTabs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowCreateUpdateRemoveConnectors&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamMemberSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamMemberSettings", HelpMessage = @"The &quot;allowCreateUpdateRemoveConnectors&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowCreateUpdateRemoveConnectors { get; set; }
    }
}