// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemActionStat&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemActionStat&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemActionStatObject", DefaultParameterSetName = @"microsoft.graph.itemActionStat")]
    [ODataType("microsoft.graph.itemActionStat")]
    public class New_ItemActionStatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;actionCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActionStat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActionStat", HelpMessage = @"The &quot;actionCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 actionCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActionStat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActionStat", HelpMessage = @"The &quot;actorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 actorCount { get; set; }
    }
}