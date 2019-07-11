// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.alert&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.alert&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AlertObject", DefaultParameterSetName = @"microsoft.graph.alert")]
    [ODataType("microsoft.graph.alert")]
    public class New_AlertObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;activityGroupName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;activityGroupName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activityGroupName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String assignedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureSubscriptionId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;azureSubscriptionId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureSubscriptionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureTenantId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;category&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;closedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;closedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset closedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cloudAppStates&quot; property, of type &quot;microsoft.graph.cloudAppSecurityState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.cloudAppSecurityState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;cloudAppStates&quot; property, of type &quot;microsoft.graph.cloudAppSecurityState&quot;.")]
        public System.Object[] cloudAppStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comments&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;comments&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] comments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;confidence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;confidence&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 confidence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;detectionIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;detectionIds&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] detectionIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;feedback&quot; property, of type &quot;microsoft.graph.alertFeedback&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;truePositive&apos;, &apos;falsePositive&apos;, &apos;benignPositive&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.alertFeedback")]
        [Selectable]
        [ValidateSet(@"unknown", @"truePositive", @"falsePositive", @"benignPositive", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;feedback&quot; property, of type &quot;microsoft.graph.alertFeedback&quot;.")]
        public System.String feedback { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileStates&quot; property, of type &quot;microsoft.graph.fileSecurityState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSecurityState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;fileStates&quot; property, of type &quot;microsoft.graph.fileSecurityState&quot;.")]
        public System.Object[] fileStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyStates&quot; property, of type &quot;microsoft.graph.alertHistoryState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alertHistoryState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;historyStates&quot; property, of type &quot;microsoft.graph.alertHistoryState&quot;.")]
        public System.Object[] historyStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hostStates&quot; property, of type &quot;microsoft.graph.hostSecurityState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.hostSecurityState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;hostStates&quot; property, of type &quot;microsoft.graph.hostSecurityState&quot;.")]
        public System.Object[] hostStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;malwareStates&quot; property, of type &quot;microsoft.graph.malwareState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.malwareState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;malwareStates&quot; property, of type &quot;microsoft.graph.malwareState&quot;.")]
        public System.Object[] malwareStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;networkConnections&quot; property, of type &quot;microsoft.graph.networkConnection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.networkConnection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;networkConnections&quot; property, of type &quot;microsoft.graph.networkConnection&quot;.")]
        public System.Object[] networkConnections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;processes&quot; property, of type &quot;microsoft.graph.process&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.process")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;processes&quot; property, of type &quot;microsoft.graph.process&quot;.")]
        public System.Object[] processes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recommendedActions&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;recommendedActions&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] recommendedActions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registryKeyStates&quot; property, of type &quot;microsoft.graph.registryKeyState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.registryKeyState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;registryKeyStates&quot; property, of type &quot;microsoft.graph.registryKeyState&quot;.")]
        public System.Object[] registryKeyStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;severity&quot; property, of type &quot;microsoft.graph.alertSeverity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;informational&apos;, &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.alertSeverity")]
        [Selectable]
        [ValidateSet(@"unknown", @"informational", @"low", @"medium", @"high", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;severity&quot; property, of type &quot;microsoft.graph.alertSeverity&quot;.")]
        public System.String severity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceMaterials&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;sourceMaterials&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] sourceMaterials { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.alertStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;newAlert&apos;, &apos;inProgress&apos;, &apos;resolved&apos;, &apos;dismissed&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.alertStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"newAlert", @"inProgress", @"resolved", @"dismissed", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.alertStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tags&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;tags&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] tags { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;triggers&quot; property, of type &quot;microsoft.graph.alertTrigger&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alertTrigger")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;triggers&quot; property, of type &quot;microsoft.graph.alertTrigger&quot;.")]
        public System.Object[] triggers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStates&quot; property, of type &quot;microsoft.graph.userSecurityState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userSecurityState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;userStates&quot; property, of type &quot;microsoft.graph.userSecurityState&quot;.")]
        public System.Object[] userStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.securityVendorInformation")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.")]
        public System.Object vendorInformation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vulnerabilityStates&quot; property, of type &quot;microsoft.graph.vulnerabilityState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alert&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.vulnerabilityState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alert", HelpMessage = @"The &quot;vulnerabilityStates&quot; property, of type &quot;microsoft.graph.vulnerabilityState&quot;.")]
        public System.Object[] vulnerabilityStates { get; set; }
    }
}