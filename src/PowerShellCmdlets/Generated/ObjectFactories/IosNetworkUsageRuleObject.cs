// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosNetworkUsageRule&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosNetworkUsageRule&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosNetworkUsageRuleObject", DefaultParameterSetName = @"#microsoft.graph.iosNetworkUsageRule")]
    [ODataType("microsoft.graph.iosNetworkUsageRule")]
    public class New_IosNetworkUsageRuleObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;managedApps&quot; property, of type &quot;microsoft.graph.appListItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNetworkUsageRule&quot; type.</para>
        ///     <para type="description">Information about the managed apps that this rule is going to apply to. This collection can contain a maximum of 500 elements.</para>
        /// </summary>
        [ODataType("microsoft.graph.appListItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosNetworkUsageRule", HelpMessage = @"The &quot;managedApps&quot; property, of type &quot;microsoft.graph.appListItem&quot;.")]
        public System.Object[] managedApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cellularDataBlockWhenRoaming&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNetworkUsageRule&quot; type.</para>
        ///     <para type="description">If set to true, corresponding managed apps will not be allowed to use cellular data when roaming.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosNetworkUsageRule", HelpMessage = @"The &quot;cellularDataBlockWhenRoaming&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean cellularDataBlockWhenRoaming { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cellularDataBlocked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNetworkUsageRule&quot; type.</para>
        ///     <para type="description">If set to true, corresponding managed apps will not be allowed to use cellular data at any time.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosNetworkUsageRule", HelpMessage = @"The &quot;cellularDataBlocked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean cellularDataBlocked { get; set; }
    }
}