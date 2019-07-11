// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemAnalytics&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemAnalytics&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemAnalyticsObject", DefaultParameterSetName = @"microsoft.graph.itemAnalytics")]
    [ODataType("microsoft.graph.itemAnalytics")]
    public class New_ItemAnalyticsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;itemActivityStats&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAnalytics&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActivityStat")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.itemAnalytics", HelpMessage = @"The &quot;itemActivityStats&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.")]
        public System.Object[] itemActivityStats { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allTime&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAnalytics&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActivityStat")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemAnalytics", HelpMessage = @"The &quot;allTime&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.")]
        public System.Object allTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSevenDays&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAnalytics&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActivityStat")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemAnalytics", HelpMessage = @"The &quot;lastSevenDays&quot; property, of type &quot;microsoft.graph.itemActivityStat&quot;.")]
        public System.Object lastSevenDays { get; set; }
    }
}