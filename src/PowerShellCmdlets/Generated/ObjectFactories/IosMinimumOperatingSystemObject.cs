// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosMinimumOperatingSystem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosMinimumOperatingSystem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosMinimumOperatingSystemObject", DefaultParameterSetName = @"#microsoft.graph.iosMinimumOperatingSystem")]
    [ODataType("microsoft.graph.iosMinimumOperatingSystem")]
    public class New_IosMinimumOperatingSystemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;v8_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 8.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMinimumOperatingSystem", HelpMessage = @"The &quot;v8_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V80 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v9_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 9.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMinimumOperatingSystem", HelpMessage = @"The &quot;v9_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V90 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v10_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 10.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMinimumOperatingSystem", HelpMessage = @"The &quot;v10_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V100 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v11_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 11.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosMinimumOperatingSystem", HelpMessage = @"The &quot;v11_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V110 { get; set; }
    }
}