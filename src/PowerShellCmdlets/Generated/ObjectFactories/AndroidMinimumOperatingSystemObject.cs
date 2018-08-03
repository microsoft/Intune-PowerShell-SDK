// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.androidMinimumOperatingSystem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.androidMinimumOperatingSystem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AndroidMinimumOperatingSystemObject", DefaultParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem")]
    [ODataType("microsoft.graph.androidMinimumOperatingSystem")]
    public class New_AndroidMinimumOperatingSystemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;v4_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V40 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v4_0_3&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.0.3 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_0_3&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V403 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v4_1&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.1 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_1&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V41 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v4_2&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.2 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_2&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V42 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v4_3&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.3 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_3&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V43 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v4_4&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 4.4 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v4_4&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V44 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v5_0&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 5.0 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v5_0&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V50 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;v5_1&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMinimumOperatingSystem&quot; type.</para>
        ///     <para type="description">Version 5.1 or later.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidMinimumOperatingSystem", HelpMessage = @"The &quot;v5_1&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean V51 { get; set; }
    }
}