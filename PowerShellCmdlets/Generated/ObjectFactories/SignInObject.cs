// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.signIn&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.signIn&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SignInObject", DefaultParameterSetName = @"microsoft.graph.signIn")]
    [ODataType("microsoft.graph.signIn")]
    public class New_SignInObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.signIn")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.signIn&quot; type.")]
        public System.Management.Automation.SwitchParameter signIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;appId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;appId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ipAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;ipAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;ipAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ipAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.signInStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.signInStatus")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.signInStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.signInStatus&quot;.")]
        public System.Object status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;clientAppUsed&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;clientAppUsed&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;clientAppUsed&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String clientAppUsed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceDetail&quot; property, of type &quot;microsoft.graph.deviceDetail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceDetail")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;deviceDetail&quot; property, of type &quot;microsoft.graph.deviceDetail&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;deviceDetail&quot; property, of type &quot;microsoft.graph.deviceDetail&quot;.")]
        public System.Object deviceDetail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;location&quot; property, of type &quot;microsoft.graph.signInLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.signInLocation")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.signInLocation&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;location&quot; property, of type &quot;microsoft.graph.signInLocation&quot;.")]
        public System.Object location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditionalAccessStatus&quot; property, of type &quot;microsoft.graph.conditionalAccessStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;failure&apos;, &apos;notApplied&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.conditionalAccessStatus")]
        [Selectable]
        [ValidateSet(@"success", @"failure", @"notApplied", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;conditionalAccessStatus&quot; property, of type &quot;microsoft.graph.conditionalAccessStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;conditionalAccessStatus&quot; property, of type &quot;microsoft.graph.conditionalAccessStatus&quot;.")]
        public System.String conditionalAccessStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliedConditionalAccessPolicies&quot; property, of type &quot;microsoft.graph.appliedConditionalAccessPolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.appliedConditionalAccessPolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;appliedConditionalAccessPolicies&quot; property, of type &quot;microsoft.graph.appliedConditionalAccessPolicy&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;appliedConditionalAccessPolicies&quot; property, of type &quot;microsoft.graph.appliedConditionalAccessPolicy&quot;.")]
        public System.Object[] appliedConditionalAccessPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isInteractive&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;isInteractive&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;isInteractive&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isInteractive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskDetail&quot; property, of type &quot;microsoft.graph.riskDetail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;adminGeneratedTemporaryPassword&apos;, &apos;userPerformedSecuredPasswordChange&apos;, &apos;userPerformedSecuredPasswordReset&apos;, &apos;adminConfirmedSigninSafe&apos;, &apos;aiConfirmedSigninSafe&apos;, &apos;userPassedMFADrivenByRiskBasedPolicy&apos;, &apos;adminDismissedAllRiskForUser&apos;, &apos;adminConfirmedSigninCompromised&apos;, &apos;hidden&apos;, &apos;adminConfirmedUserCompromised&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.riskDetail")]
        [Selectable]
        [ValidateSet(@"none", @"adminGeneratedTemporaryPassword", @"userPerformedSecuredPasswordChange", @"userPerformedSecuredPasswordReset", @"adminConfirmedSigninSafe", @"aiConfirmedSigninSafe", @"userPassedMFADrivenByRiskBasedPolicy", @"adminDismissedAllRiskForUser", @"adminConfirmedSigninCompromised", @"hidden", @"adminConfirmedUserCompromised", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;riskDetail&quot; property, of type &quot;microsoft.graph.riskDetail&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;riskDetail&quot; property, of type &quot;microsoft.graph.riskDetail&quot;.")]
        public System.String riskDetail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskLevelAggregated&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;hidden&apos;, &apos;none&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.riskLevel")]
        [Selectable]
        [ValidateSet(@"low", @"medium", @"high", @"hidden", @"none", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;riskLevelAggregated&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;riskLevelAggregated&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.")]
        public System.String riskLevelAggregated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskLevelDuringSignIn&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;hidden&apos;, &apos;none&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.riskLevel")]
        [Selectable]
        [ValidateSet(@"low", @"medium", @"high", @"hidden", @"none", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;riskLevelDuringSignIn&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;riskLevelDuringSignIn&quot; property, of type &quot;microsoft.graph.riskLevel&quot;.")]
        public System.String riskLevelDuringSignIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskState&quot; property, of type &quot;microsoft.graph.riskState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;confirmedSafe&apos;, &apos;remediated&apos;, &apos;dismissed&apos;, &apos;atRisk&apos;, &apos;confirmedCompromised&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.riskState")]
        [Selectable]
        [ValidateSet(@"none", @"confirmedSafe", @"remediated", @"dismissed", @"atRisk", @"confirmedCompromised", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;riskState&quot; property, of type &quot;microsoft.graph.riskState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;riskState&quot; property, of type &quot;microsoft.graph.riskState&quot;.")]
        public System.String riskState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskEventTypes&quot; property, of type &quot;microsoft.graph.riskEventType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unlikelyTravel&apos;, &apos;anonymizedIPAddress&apos;, &apos;maliciousIPAddress&apos;, &apos;unfamiliarFeatures&apos;, &apos;malwareInfectedIPAddress&apos;, &apos;suspiciousIPAddress&apos;, &apos;leakedCredentials&apos;, &apos;investigationsThreatIntelligence&apos;, &apos;generic&apos;, &apos;adminConfirmedUserCompromised&apos;, &apos;mcasImpossibleTravel&apos;, &apos;mcasSuspiciousInboxManipulationRules&apos;, &apos;investigationsThreatIntelligenceSigninLinked&apos;, &apos;maliciousIPAddressValidCredentialsBlockedIP&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.riskEventType")]
        [Selectable]
        [ValidateSet(@"unlikelyTravel", @"anonymizedIPAddress", @"maliciousIPAddress", @"unfamiliarFeatures", @"malwareInfectedIPAddress", @"suspiciousIPAddress", @"leakedCredentials", @"investigationsThreatIntelligence", @"generic", @"adminConfirmedUserCompromised", @"mcasImpossibleTravel", @"mcasSuspiciousInboxManipulationRules", @"investigationsThreatIntelligenceSigninLinked", @"maliciousIPAddressValidCredentialsBlockedIP", @"unknownFutureValue")]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;riskEventTypes&quot; property, of type &quot;microsoft.graph.riskEventType&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;riskEventTypes&quot; property, of type &quot;microsoft.graph.riskEventType&quot;.")]
        public System.String[] riskEventTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;resourceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;resourceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signIn", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.restrictedSignIn&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.restrictedSignIn")]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.restrictedSignIn&quot; type.")]
        public System.Management.Automation.SwitchParameter restrictedSignIn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetTenantId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.restrictedSignIn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.restrictedSignIn", HelpMessage = @"The &quot;targetTenantId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid targetTenantId { get; set; }
    }
}