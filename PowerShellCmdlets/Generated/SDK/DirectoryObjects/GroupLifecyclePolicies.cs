// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.groupLifecyclePolicy&quot; objects.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.groupLifecyclePolicy&quot; objects in the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "DirectoryObjects_GroupLifecyclePolicies", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    [ResourceReference]
    public class Get_DirectoryObjects_GroupLifecyclePolicies : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 groupLifetimeInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String managedGroupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String alternateNotificationEmails { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.groupLifecyclePolicy&quot; object.</para>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.groupLifecyclePolicy&quot; object to the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "DirectoryObjects_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.groupLifecyclePolicy")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    [ResourceReference]
    public class New_DirectoryObjects_GroupLifecyclePolicies : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 groupLifetimeInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedGroupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String alternateNotificationEmails { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">PATCH ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "DirectoryObjects_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.groupLifecyclePolicy")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    public class Update_DirectoryObjects_GroupLifecyclePolicies : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 groupLifetimeInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedGroupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String alternateNotificationEmails { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.groupLifecyclePolicy&quot; object.</para>
    ///     <para type="description">DELETE ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/groupLifecyclePolicyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.groupLifecyclePolicy&quot; object from the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "DirectoryObjects_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    public class Remove_DirectoryObjects_GroupLifecyclePolicies : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/addGroup</para>
    ///     <para type="description">The action &quot;microsoft.graph.addGroup&quot;, which exists on the type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">This action returns a &quot;Edm.Boolean&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "DirectoryObjects_GroupLifecyclePolicies_AddGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    public class Invoke_DirectoryObjects_GroupLifecyclePolicies_AddGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; action parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; action parameter of type &quot;Edm.String&quot;.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId}/addGroup";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/removeGroup</para>
    ///     <para type="description">The action &quot;microsoft.graph.removeGroup&quot;, which exists on the type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">This action returns a &quot;Edm.Boolean&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "DirectoryObjects_GroupLifecyclePolicies_RemoveGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceIdPropertyName("groupLifecyclePolicyId")]
    public class Invoke_DirectoryObjects_GroupLifecyclePolicies_RemoveGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; action parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; action parameter of type &quot;Edm.String&quot;.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/groupLifecyclePolicies/{groupLifecyclePolicyId}/removeGroup";
        }
    }
}