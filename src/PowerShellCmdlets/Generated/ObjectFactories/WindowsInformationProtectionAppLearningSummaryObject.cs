// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Windows Information Protection AppLearning Summary entity.</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionAppLearningSummaryObject", DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    public class New_WindowsInformationProtectionAppLearningSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String applicationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Type</para>
        ///     <para type="description">
        ///          Valid values: &apos;universal&apos;, &apos;desktop&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.applicationType")]
        [Selectable]
        [ValidateSet(@"universal", @"desktop")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.")]
        public System.String applicationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }
    }
}