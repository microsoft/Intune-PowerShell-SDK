// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemActivityStat&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemActivityStat&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemActivityStatObject", DefaultParameterSetName = @"microsoft.graph.itemActivityStat")]
    [ODataType("microsoft.graph.itemActivityStat")]
    public class New_ItemActivityStatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset startDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;endDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset endDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;access&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActionStat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;access&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.")]
        public System.Object access { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;create&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActionStat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;create&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.")]
        public System.Object create { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;delete&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActionStat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;delete&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.")]
        public System.Object delete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;edit&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActionStat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;edit&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.")]
        public System.Object edit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;move&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActionStat")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;move&quot; property, of type &quot;microsoft.graph.itemActionStat&quot;.")]
        public System.Object move { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isTrending&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;isTrending&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isTrending { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;incompleteData&quot; property, of type &quot;microsoft.graph.incompleteData&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.incompleteData")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;incompleteData&quot; property, of type &quot;microsoft.graph.incompleteData&quot;.")]
        public System.Object incompleteData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activities&quot; property, of type &quot;microsoft.graph.itemActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivityStat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemActivity")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivityStat", HelpMessage = @"The &quot;activities&quot; property, of type &quot;microsoft.graph.itemActivity&quot;.")]
        public System.Object[] activities { get; set; }
    }
}