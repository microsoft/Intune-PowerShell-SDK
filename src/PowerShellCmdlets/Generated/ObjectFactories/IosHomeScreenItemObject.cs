// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosHomeScreenItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosHomeScreenItemObject", DefaultParameterSetName = @"#microsoft.graph.iosHomeScreenItem")]
    [ODataType("microsoft.graph.iosHomeScreenItem")]
    public class New_IosHomeScreenItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenItem&quot; type.</para>
        ///     <para type="description">Name of the app</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenItem", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosHomeScreenApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosHomeScreenApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosHomeScreenApp&quot; type.")]
        public System.Management.Automation.SwitchParameter IosHomeScreenApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bundleID&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenApp&quot; type.</para>
        ///     <para type="description">BundleID of app</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenApp", HelpMessage = @"The &quot;bundleID&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BundleID { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosHomeScreenFolder&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosHomeScreenFolder")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenFolder", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosHomeScreenFolder&quot; type.")]
        public System.Management.Automation.SwitchParameter IosHomeScreenFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.iosHomeScreenFolderPage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosHomeScreenFolder&quot; type.</para>
        ///     <para type="description">Pages of Home Screen Layout Icons which must be Application Type. This collection can contain a maximum of 500 elements.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosHomeScreenFolderPage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosHomeScreenFolder", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.iosHomeScreenFolderPage&quot;.")]
        public System.Object[] Pages { get; set; }
    }
}