// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsMinimumOperatingSystem&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsMinimumOperatingSystem&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsMinimumOperatingSystemObject", DefaultParameterSetName = @"microsoft.graph.windowsMinimumOperatingSystem")]
    [ODataType("microsoft.graph.windowsMinimumOperatingSystem")]
    public class New_WindowsMinimumOperatingSystemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;v8_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Windows version 8.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsMinimumOperatingSystem", HelpMessage = @"The &quot;v8_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean v8_0 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v8_1&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Windows version 8.1 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsMinimumOperatingSystem", HelpMessage = @"The &quot;v8_1&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean v8_1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v10_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Windows version 10.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsMinimumOperatingSystem", HelpMessage = @"The &quot;v10_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean v10_0 { get; set; }
    }
}