// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionIPRangeCollectionObject", DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionIPRangeCollection")]
    [ODataType("microsoft.graph.windowsInformationProtectionIPRangeCollection")]
    public class New_WindowsInformationProtectionIPRangeCollectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot; type.</para>
        ///     <para type="description">Display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionIPRangeCollection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ranges&quot; property, of type &quot;microsoft.graph.ipRange&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionIPRangeCollection&quot; type.</para>
        ///     <para type="description">Collection of ip ranges</para>
        /// </summary>
        [ODataType("microsoft.graph.ipRange")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionIPRangeCollection", HelpMessage = @"The &quot;ranges&quot; property, of type &quot;microsoft.graph.ipRange&quot;.")]
        public System.Object[] ranges { get; set; }
    }
}