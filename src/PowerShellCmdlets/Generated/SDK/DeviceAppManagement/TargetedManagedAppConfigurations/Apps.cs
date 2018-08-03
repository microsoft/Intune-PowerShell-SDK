// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_TargetedManagedAppConfigurations_Apps", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceIdPropertyName("AppId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_TargetedManagedAppConfigurations_Apps : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String TargetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String AppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object MobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps/{AppId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedMobileApp&quot; object to the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_TargetedManagedAppConfigurations_Apps", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceReference]
    public class New_DeviceAppManagement_TargetedManagedAppConfigurations_Apps : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String TargetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object MobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedMobileApp&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_TargetedManagedAppConfigurations_Apps", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceIdPropertyName("AppId")]
    public class Update_DeviceAppManagement_TargetedManagedAppConfigurations_Apps : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String AppId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String TargetedManagedAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object MobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps/{AppId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps/AppId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedMobileApp&quot; object from the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_TargetedManagedAppConfigurations_Apps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceIdPropertyName("AppId")]
    public class Remove_DeviceAppManagement_TargetedManagedAppConfigurations_Apps : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String AppId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.targetedManagedAppConfiguration&quot; object in the &quot;targetedManagedAppConfigurations&quot; collection.")]
        public System.String TargetedManagedAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/targetedManagedAppConfigurations/{TargetedManagedAppConfigurationId}/apps/{AppId}";
        }
    }
}