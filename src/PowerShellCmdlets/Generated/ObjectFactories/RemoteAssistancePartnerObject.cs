// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.remoteAssistancePartner&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.remoteAssistancePartner&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">remoteAssistPartner resources represent the metadata and status of a given Remote Assistance partner service.</para>
    /// </summary>
    [Cmdlet("New", "RemoteAssistancePartnerObject", DefaultParameterSetName = @"#microsoft.graph.remoteAssistancePartner")]
    [ODataType("microsoft.graph.remoteAssistancePartner")]
    public class New_RemoteAssistancePartnerObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Display name of the partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;onboardingUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onboardingUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">TBD</para>
        ///     <para type="description">
        ///          Valid values: &apos;notOnboarded&apos;, &apos;onboarding&apos;, &apos;onboarded&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.remoteAssistanceOnboardingStatus")]
        [Selectable]
        [ValidateSet(@"notOnboarded", @"onboarding", @"onboarded")]
        [Parameter(ParameterSetName = @"#microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;onboardingStatus&quot; property, of type &quot;microsoft.graph.remoteAssistanceOnboardingStatus&quot;.")]
        public System.String onboardingStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteAssistancePartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.remoteAssistancePartner", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }
    }
}