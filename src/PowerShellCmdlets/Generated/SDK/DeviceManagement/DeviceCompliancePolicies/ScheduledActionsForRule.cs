// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; objects in the &quot;scheduledActionsForRule&quot; collection.</para>
    ///     <para type="description">The list of scheduled action for this rule</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ResourceIdPropertyName("ScheduledActionsForRuleId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String ScheduledActionsForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">Name of the rule which this scheduled action applies to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String RuleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionItem")]
        [Selectable]
        [Expandable]
        public System.Object[] ScheduledActionConfigurations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule/{ScheduledActionsForRuleId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object to the &quot;scheduledActionsForRule&quot; collection.</para>
    ///     <para type="description">The list of scheduled action for this rule</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">Name of the rule which this scheduled action applies to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String RuleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.")]
        public System.Object[] ScheduledActionConfigurations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
    ///     <para type="description">The list of scheduled action for this rule</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ResourceIdPropertyName("ScheduledActionsForRuleId")]
    public class Update_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String ScheduledActionsForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">Name of the rule which this scheduled action applies to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String RuleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.")]
        public System.Object[] ScheduledActionConfigurations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule/{ScheduledActionsForRuleId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule/ScheduledActionsForRuleId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object from the &quot;scheduledActionsForRule&quot; collection.</para>
    ///     <para type="description">The list of scheduled action for this rule</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ResourceIdPropertyName("ScheduledActionsForRuleId")]
    public class Remove_DeviceManagement_DeviceCompliancePolicies_ScheduledActionsForRule : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; object in the &quot;scheduledActionsForRule&quot; collection.")]
        public System.String ScheduledActionsForRuleId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/scheduledActionsForRule/{ScheduledActionsForRuleId}";
        }
    }
}