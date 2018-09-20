// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceActionItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceActionItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Scheduled Action Configuration</para>
    /// </summary>
    [Cmdlet("New", "DeviceComplianceActionItemObject", DefaultParameterSetName = @"microsoft.graph.deviceComplianceActionItem")]
    [ODataType("microsoft.graph.deviceComplianceActionItem")]
    public class New_DeviceComplianceActionItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">Number of hours to wait till the action will be enforced. Valid values 0 to 8760</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;gracePeriodHours&quot; property, of type &quot;Edm.Int32&quot;.")]
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
        public System.String actionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceActionItem&quot; type.</para>
        ///     <para type="description">What notification Message template to use</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceActionItem", HelpMessage = @"The &quot;notificationTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
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
        public System.String[] notificationMessageCCList { get; set; }
    }
}