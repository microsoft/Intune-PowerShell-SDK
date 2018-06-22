// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenPage&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenPage&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosHomeScreenPageObject", DefaultParameterSetName = @"#microsoft.graph.iosHomeScreenPage")]
    [ODataType("microsoft.graph.iosHomeScreenPage")]
    public class New_IosHomeScreenPageObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenPage&quot; type.</para>
        ///     <para type="description">Name of the page</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenPage", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;icons&quot; property, of type &quot;microsoft.graph.iosHomeScreenItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenPage&quot; type.</para>
        ///     <para type="description">A list of apps and folders to appear on a page. This collection can contain a maximum of 500 elements.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosHomeScreenItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenPage", HelpMessage = @"The &quot;icons&quot; property, of type &quot;microsoft.graph.iosHomeScreenItem&quot;.")]
        public System.Object[] icons { get; set; }
    }
}