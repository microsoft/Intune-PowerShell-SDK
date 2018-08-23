// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagementSettings&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagementSettings&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementSettingsObject", DefaultParameterSetName = @"microsoft.graph.deviceManagementSettings")]
    [ODataType("microsoft.graph.deviceManagementSettings")]
    public class New_DeviceManagementSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceCheckinThresholdDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementSettings&quot; type.</para>
        ///     <para type="description">The number of days a device is allowed to go without checking in to remain compliant. Valid values 0 to 120</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementSettings", HelpMessage = @"The &quot;deviceComplianceCheckinThresholdDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceComplianceCheckinThresholdDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isScheduledActionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementSettings&quot; type.</para>
        ///     <para type="description">Is feature enabled or not for scheduled action for rule.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementSettings", HelpMessage = @"The &quot;isScheduledActionEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isScheduledActionEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureByDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementSettings&quot; type.</para>
        ///     <para type="description">Device should be noncompliant when there is no compliance policy targeted when this is true</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementSettings", HelpMessage = @"The &quot;secureByDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean secureByDefault { get; set; }
    }
}