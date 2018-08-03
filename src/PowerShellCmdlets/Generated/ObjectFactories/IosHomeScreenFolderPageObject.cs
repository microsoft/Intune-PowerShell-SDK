// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenFolderPage&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenFolderPage&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosHomeScreenFolderPageObject", DefaultParameterSetName = @"#microsoft.graph.iosHomeScreenFolderPage")]
    [ODataType("microsoft.graph.iosHomeScreenFolderPage")]
    public class New_IosHomeScreenFolderPageObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenFolderPage&quot; type.</para>
        ///     <para type="description">Name of the folder page</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenFolderPage", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.iosHomeScreenApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenFolderPage&quot; type.</para>
        ///     <para type="description">A list of apps to appear on a page within a folder. This collection can contain a maximum of 500 elements.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosHomeScreenApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenFolderPage", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.iosHomeScreenApp&quot;.")]
        public System.Object[] Apps { get; set; }
    }
}