// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.")]
        public System.String mdmWindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.")]
        public System.String mdmWindowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
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
            return $"deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object to the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    [ResourceReference]
    public class New_DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String exemptAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.")]
        public System.String mdmWindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.")]
        public System.String mdmWindowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    public class Update_DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles : PatchCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.")]
        public System.String mdmWindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.")]
        public System.String mdmWindowsInformationProtectionPolicyODataType { get; set; }

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
            return $"deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/exemptAppLockerFileId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object from the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceIdPropertyName("exemptAppLockerFileId")]
    public class Remove_DeviceAppManagement_MdmWindowsInformationProtectionPolicies_ExemptAppLockerFiles : DeleteCmdlet
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
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; object in the &quot;mdmWindowsInformationProtectionPolicies&quot; collection.")]
        public System.String mdmWindowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.mdmWindowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.mdmWindowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.mdmWindowsInformationProtectionPolicy&quot; objects.")]
        public System.String mdmWindowsInformationProtectionPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicyId}/{mdmWindowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{exemptAppLockerFileId}";
        }
    }
}