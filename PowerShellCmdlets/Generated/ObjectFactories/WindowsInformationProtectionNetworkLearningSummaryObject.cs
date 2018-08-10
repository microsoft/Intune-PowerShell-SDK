// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Windows Information Protection Network learning Summary entity.</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionNetworkLearningSummaryObject", DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    public class New_WindowsInformationProtectionNetworkLearningSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }
    }
}