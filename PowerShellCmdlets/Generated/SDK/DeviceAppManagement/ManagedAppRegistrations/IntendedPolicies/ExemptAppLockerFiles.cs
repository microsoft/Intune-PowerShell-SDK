// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.managedAppPolicy&apos;, &apos;microsoft.graph.windowsInformationProtection&apos;, &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.managedAppConfiguration&apos;, &apos;microsoft.graph.targetedManagedAppConfiguration&apos;, &apos;microsoft.graph.managedAppProtection&apos;, &apos;microsoft.graph.defaultManagedAppProtection&apos;, &apos;microsoft.graph.targetedManagedAppProtection&apos;, &apos;microsoft.graph.androidManagedAppProtection&apos;, &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.managedAppPolicy", @"microsoft.graph.windowsInformationProtection", @"microsoft.graph.windowsInformationProtectionPolicy", @"microsoft.graph.mdmWindowsInformationProtectionPolicy", @"microsoft.graph.managedAppConfiguration", @"microsoft.graph.targetedManagedAppConfiguration", @"microsoft.graph.managedAppProtection", @"microsoft.graph.defaultManagedAppProtection", @"microsoft.graph.targetedManagedAppProtection", @"microsoft.graph.androidManagedAppProtection", @"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String exemptAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object to the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String exemptAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.managedAppPolicy&apos;, &apos;microsoft.graph.windowsInformationProtection&apos;, &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.managedAppConfiguration&apos;, &apos;microsoft.graph.targetedManagedAppConfiguration&apos;, &apos;microsoft.graph.managedAppProtection&apos;, &apos;microsoft.graph.defaultManagedAppProtection&apos;, &apos;microsoft.graph.targetedManagedAppProtection&apos;, &apos;microsoft.graph.androidManagedAppProtection&apos;, &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.managedAppPolicy", @"microsoft.graph.windowsInformationProtection", @"microsoft.graph.windowsInformationProtectionPolicy", @"microsoft.graph.mdmWindowsInformationProtectionPolicy", @"microsoft.graph.managedAppConfiguration", @"microsoft.graph.targetedManagedAppConfiguration", @"microsoft.graph.managedAppProtection", @"microsoft.graph.defaultManagedAppProtection", @"microsoft.graph.targetedManagedAppProtection", @"microsoft.graph.androidManagedAppProtection", @"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    public class Update_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String exemptAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.managedAppPolicy&apos;, &apos;microsoft.graph.windowsInformationProtection&apos;, &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.managedAppConfiguration&apos;, &apos;microsoft.graph.targetedManagedAppConfiguration&apos;, &apos;microsoft.graph.managedAppProtection&apos;, &apos;microsoft.graph.defaultManagedAppProtection&apos;, &apos;microsoft.graph.targetedManagedAppProtection&apos;, &apos;microsoft.graph.androidManagedAppProtection&apos;, &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.managedAppPolicy", @"microsoft.graph.windowsInformationProtection", @"microsoft.graph.windowsInformationProtectionPolicy", @"microsoft.graph.mdmWindowsInformationProtectionPolicy", @"microsoft.graph.managedAppConfiguration", @"microsoft.graph.targetedManagedAppConfiguration", @"microsoft.graph.managedAppProtection", @"microsoft.graph.defaultManagedAppProtection", @"microsoft.graph.targetedManagedAppProtection", @"microsoft.graph.androidManagedAppProtection", @"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles/exemptAppLockerFileId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object from the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    public class Remove_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_ExemptAppLockerFiles : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String exemptAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.managedAppPolicy&apos;, &apos;microsoft.graph.windowsInformationProtection&apos;, &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;, &apos;microsoft.graph.managedAppConfiguration&apos;, &apos;microsoft.graph.targetedManagedAppConfiguration&apos;, &apos;microsoft.graph.managedAppProtection&apos;, &apos;microsoft.graph.defaultManagedAppProtection&apos;, &apos;microsoft.graph.targetedManagedAppProtection&apos;, &apos;microsoft.graph.androidManagedAppProtection&apos;, &apos;microsoft.graph.iosManagedAppProtection&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.managedAppPolicy", @"microsoft.graph.windowsInformationProtection", @"microsoft.graph.windowsInformationProtectionPolicy", @"microsoft.graph.mdmWindowsInformationProtectionPolicy", @"microsoft.graph.managedAppConfiguration", @"microsoft.graph.targetedManagedAppConfiguration", @"microsoft.graph.managedAppProtection", @"microsoft.graph.defaultManagedAppProtection", @"microsoft.graph.targetedManagedAppProtection", @"microsoft.graph.androidManagedAppProtection", @"microsoft.graph.iosManagedAppProtection")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }
}