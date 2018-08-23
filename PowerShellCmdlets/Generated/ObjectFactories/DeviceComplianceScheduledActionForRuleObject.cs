// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Scheduled Action for Rule</para>
    /// </summary>
    [Cmdlet("New", "DeviceComplianceScheduledActionForRuleObject", DefaultParameterSetName = @"microsoft.graph.deviceComplianceScheduledActionForRule")]
    [ODataType("microsoft.graph.deviceComplianceScheduledActionForRule")]
    public class New_DeviceComplianceScheduledActionForRuleObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">Name of the rule which this scheduled action applies to.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;ruleName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ruleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceScheduledActionForRule&quot; type.</para>
        ///     <para type="description">The list of scheduled action configurations for this compliance policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceActionItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceScheduledActionForRule", HelpMessage = @"The &quot;scheduledActionConfigurations&quot; property, of type &quot;microsoft.graph.deviceComplianceActionItem&quot;.")]
        public System.Object[] scheduledActionConfigurations { get; set; }
    }
}