// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneAppProtectionPolicyAndroidApp", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceReference]
    public class Get_IntuneAppProtectionPolicyAndroidApp : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String androidManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String managedMobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps/{managedMobileAppId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedMobileApp&quot; object to the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneAppProtectionPolicyAndroidApp", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceReference]
    public class New_IntuneAppProtectionPolicyAndroidApp : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String managedMobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String androidManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps/{managedMobileAppId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedMobileApp&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneAppProtectionPolicyAndroidApp", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    public class Update_IntuneAppProtectionPolicyAndroidApp : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String managedMobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String androidManagedAppProtectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps/{managedMobileAppId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps/managedMobileAppId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedMobileApp&quot; object from the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneAppProtectionPolicyAndroidApp", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    public class Remove_IntuneAppProtectionPolicyAndroidApp : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String managedMobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.androidManagedAppProtection&quot; object in the &quot;androidManagedAppProtections&quot; collection.")]
        public System.String androidManagedAppProtectionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtectionId}/apps/{managedMobileAppId}";
        }
    }
}