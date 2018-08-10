// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedAppPolicyDeploymentSummaryPerApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedAppPolicyDeploymentSummaryPerApp&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ManagedAppPolicyDeploymentSummaryPerAppObject", DefaultParameterSetName = @"#microsoft.graph.managedAppPolicyDeploymentSummaryPerApp")]
    [ODataType("microsoft.graph.managedAppPolicyDeploymentSummaryPerApp")]
    public class New_ManagedAppPolicyDeploymentSummaryPerAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicyDeploymentSummaryPerApp&quot; type.</para>
        ///     <para type="description">Deployment of an app.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicyDeploymentSummaryPerApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationAppliedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppPolicyDeploymentSummaryPerApp&quot; type.</para>
        ///     <para type="description">Number of users the policy is applied.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppPolicyDeploymentSummaryPerApp", HelpMessage = @"The &quot;configurationAppliedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 configurationAppliedUserCount { get; set; }
    }
}