// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceComplianceActionItem&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceComplianceActionItem&quot; objects in the &quot;scheduledActionConfigurations&quot; collection.</para>
    ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceComplianceActionItem")]
    [ResourceTypePropertyName("scheduledActionConfigurationODataType")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String deviceComplianceScheduledActionForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.")]
        public System.String deviceComplianceActionItemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">Number of hours to wait till the action will be enforced. Valid values 0 to 8760</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 gracePeriodHours { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What action to take</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionType")]
        [Selectable]
        [Sortable]
        public System.String actionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What notification Message template to use</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String notificationTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">A list of group IDs to speicify who to CC this notification message to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] notificationMessageCCList { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations/{deviceComplianceActionItemId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceActionItem&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceComplianceActionItem&quot; object to the &quot;scheduledActionConfigurations&quot; collection.</para>
    ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceComplianceActionItem")]
    [ODataType("microsoft.graph.deviceComplianceActionItem")]
    [ResourceTypePropertyName("scheduledActionConfigurationODataType")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceComplianceActionItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String deviceComplianceScheduledActionForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">Number of hours to wait till the action will be enforced. Valid values 0 to 8760</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 gracePeriodHours { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What action to take</para>
        ///     <para type="description">
        ///          Valid values: &apos;noAction&apos;, &apos;notification&apos;, &apos;block&apos;, &apos;retire&apos;, &apos;wipe&apos;, &apos;removeResourceAccessProfiles&apos;, &apos;pushNotification&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionType")]
        [Selectable]
        [ValidateSet(@"noAction", @"notification", @"block", @"retire", @"wipe", @"removeResourceAccessProfiles", @"pushNotification")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.")]
        public System.String actionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What notification Message template to use</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String notificationTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">A list of group IDs to speicify who to CC this notification message to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] notificationMessageCCList { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations/{deviceComplianceActionItemId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceActionItem&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.</para>
    ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceComplianceActionItem")]
    [ODataType("microsoft.graph.deviceComplianceActionItem")]
    [ResourceTypePropertyName("scheduledActionConfigurationODataType")]
    public class Update_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.")]
        public System.String deviceComplianceActionItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String deviceComplianceScheduledActionForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">Number of hours to wait till the action will be enforced. Valid values 0 to 8760</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 gracePeriodHours { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What action to take</para>
        ///     <para type="description">
        ///          Valid values: &apos;noAction&apos;, &apos;notification&apos;, &apos;block&apos;, &apos;retire&apos;, &apos;wipe&apos;, &apos;removeResourceAccessProfiles&apos;, &apos;pushNotification&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionType")]
        [Selectable]
        [ValidateSet(@"noAction", @"notification", @"block", @"retire", @"wipe", @"removeResourceAccessProfiles", @"pushNotification")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;actionType&quot; property, of type &quot;microsoft.graph.deviceComplianceActionType&quot;.")]
        public System.String actionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What notification Message template to use</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String notificationTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">A list of group IDs to speicify who to CC this notification message to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notificationMessageCCList&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] notificationMessageCCList { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations/{deviceComplianceActionItemId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceActionItem&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations/deviceComplianceActionItemId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceComplianceActionItem&quot; object from the &quot;scheduledActionConfigurations&quot; collection.</para>
    ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceActionItem")]
    [ResourceTypePropertyName("scheduledActionConfigurationODataType")]
    public class Remove_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule_ScheduledActionConfigurations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceActionItem&quot; object in the &quot;scheduledActionConfigurations&quot; collection.")]
        public System.String deviceComplianceActionItemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String deviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String deviceComplianceScheduledActionForRuleId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicyId}/scheduledActionsForRule/{deviceComplianceScheduledActionForRuleId}/scheduledActionConfigurations/{deviceComplianceActionItemId}";
        }
    }
}