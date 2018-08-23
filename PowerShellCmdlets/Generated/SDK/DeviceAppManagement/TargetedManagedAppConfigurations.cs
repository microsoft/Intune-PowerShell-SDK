// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.targetedManagedAppConfiguration&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/targetedManagedAppConfigurations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.targetedManagedAppConfiguration&quot; objects in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
    ///     <para type="description">Targeted managed app configurations.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_TargetedManagedAppConfigurations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_TargetedManagedAppConfigurations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String targetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [Expandable]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        public System.Object[] customSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/targetedManagedAppConfigurations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object to the &quot;targetedManagedAppConfigurations&quot; collection.</para>
    ///     <para type="description">Targeted managed app configurations.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_TargetedManagedAppConfigurations", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration")]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    [ResourceReference]
    public class New_DeviceAppManagement_TargetedManagedAppConfigurations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String targetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        public System.Object[] customSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/targetedManagedAppConfigurations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
    ///     <para type="description">Targeted managed app configurations.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_TargetedManagedAppConfigurations", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration")]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    public class Update_DeviceAppManagement_TargetedManagedAppConfigurations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String targetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Count of apps to which the current policy is deployed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deployedAppCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deployedAppCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Indicates if the policy is deployed to any inclusion groups or not.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isAssigned&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAssigned { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">List of apps to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;apps&quot; property, of type &quot;microsoft.graph.managedMobileApp&quot;.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to deployment summary of the configuration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppPolicyDeploymentSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deploymentSummary&quot; property, of type &quot;microsoft.graph.managedAppPolicyDeploymentSummary&quot;.")]
        public System.Object deploymentSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.targetedManagedAppPolicyAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValuePair")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;customSettings&quot; property, of type &quot;microsoft.graph.keyValuePair&quot;.")]
        public System.Object[] customSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Policy display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The policy&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">The date and time the policy was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Last time the policy was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetedManagedAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetedManagedAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/targetedManagedAppConfigurations/targetedManagedAppConfigurationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object from the &quot;targetedManagedAppConfigurations&quot; collection.</para>
    ///     <para type="description">Targeted managed app configurations.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_TargetedManagedAppConfigurations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    public class Remove_DeviceAppManagement_TargetedManagedAppConfigurations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String targetedManagedAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/targetedManagedAppConfigurations/assign</para>
    ///     <para type="description">The action &quot;microsoft.graph.assign&quot;, which exists on the type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_TargetedManagedAppConfigurations_Assign", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    public class Invoke_DeviceAppManagement_TargetedManagedAppConfigurations_Assign : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetedManagedAppPolicyAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String targetedManagedAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId}/assign";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/targetedManagedAppConfigurations/targetApps</para>
    ///     <para type="description">The action &quot;microsoft.graph.targetApps&quot;, which exists on the type &quot;microsoft.graph.targetedManagedAppConfiguration&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_TargetedManagedAppConfigurations_TargetApps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.targetedManagedAppConfiguration")]
    [ResourceTypePropertyName("targetedManagedAppConfigurationODataType")]
    [ResourceIdPropertyName("targetedManagedAppConfigurationId")]
    public class Invoke_DeviceAppManagement_TargetedManagedAppConfigurations_TargetApps : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;apps&quot; parameter, which is accepted by the &quot;microsoft.graph.targetApps&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedMobileApp")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;apps&quot; parameter, which is accepted by the &quot;microsoft.graph.targetApps&quot; action.")]
        public System.Object[] apps { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String targetedManagedAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfigurationId}/targetApps";
        }
    }
}