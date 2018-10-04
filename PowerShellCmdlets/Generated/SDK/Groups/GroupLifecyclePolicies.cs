// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.groupLifecyclePolicy&quot; objects.</para>
    ///     <para type="description">GET ~/groups/{groupId}/groupLifecyclePolicies</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.groupLifecyclePolicy&quot; objects in the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "Groups_GroupLifecyclePolicies", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceReference]
    public class Get_Groups_GroupLifecyclePolicies : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
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
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.groupLifecyclePolicy&quot; object.</para>
    ///     <para type="description">POST ~/groups/{groupId}/groupLifecyclePolicies</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.groupLifecyclePolicy&quot; object to the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "Groups_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.groupLifecyclePolicy")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    [ResourceReference]
    public class New_Groups_GroupLifecyclePolicies : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

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
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">PATCH ~/groups/{groupId}/groupLifecyclePolicies</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "Groups_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.groupLifecyclePolicy")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    public class Update_Groups_GroupLifecyclePolicies : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

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
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.groupLifecyclePolicy&quot; object.</para>
    ///     <para type="description">DELETE ~/groups/{groupId}/groupLifecyclePolicies/groupLifecyclePolicyId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.groupLifecyclePolicy&quot; object from the &quot;groupLifecyclePolicies&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "Groups_GroupLifecyclePolicies", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    public class Remove_Groups_GroupLifecyclePolicies : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/{groupId}/groupLifecyclePolicies/addGroup</para>
    ///     <para type="description">The action &quot;microsoft.graph.addGroup&quot;, which exists on the type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">This action returns a &quot;Edm.Boolean&quot; object.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "Groups_GroupLifecyclePolicies_AddGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    public class Invoke_Groups_GroupLifecyclePolicies_AddGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId}/addGroup";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/{groupId}/groupLifecyclePolicies/removeGroup</para>
    ///     <para type="description">The action &quot;microsoft.graph.removeGroup&quot;, which exists on the type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
    ///     <para type="description">This action returns a &quot;Edm.Boolean&quot; object.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "Groups_GroupLifecyclePolicies_RemoveGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    [ResourceTypePropertyName("groupLifecyclePolicyODataType")]
    public class Invoke_Groups_GroupLifecyclePolicies_RemoveGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupLifecyclePolicy&quot; object in the &quot;groupLifecyclePolicies&quot; collection.")]
        public System.String groupLifecyclePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/groupLifecyclePolicies/{groupLifecyclePolicyId}/removeGroup";
        }
    }
}