// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceCompliancePolicyState&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceCompliancePolicyState&quot; objects in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
    ///     <para type="description">Device compliance policy states for this device.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceCompliancePolicyState")]
    [ResourceTypePropertyName("deviceCompliancePolicyStateODataType")]
    [ResourceReference]
    [Alias("Get-IntuneManagedDeviceDeviceCompliancePolicyState")]
    public class Get_DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.")]
        public System.String deviceCompliancePolicyStateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicySettingState")]
        [Selectable]
        public System.Object[] settingStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The name of the policy for this policyBase</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The version of the policy</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Platform type that the policy applies to</para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [Sortable]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The compliance state of the policy</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [Sortable]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Count of how many setting a policy holds</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 settingCount { get; set; }

        internal override System.String GetResourcePath()
        {
            /// Addition of /settingStates as used in Intune > Devices > {Device} > Device Complaince > {Policy}
            return $"deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/{(deviceCompliancePolicyStateId==null?null: deviceCompliancePolicyStateId+ "/settingStates") ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object to the &quot;deviceCompliancePolicyStates&quot; collection.</para>
    ///     <para type="description">Device compliance policy states for this device.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceCompliancePolicyState")]
    [ODataType("microsoft.graph.deviceCompliancePolicyState")]
    [ResourceTypePropertyName("deviceCompliancePolicyStateODataType")]
    [ResourceReference]
    [Alias("New-IntuneManagedDeviceDeviceCompliancePolicyState")]
    public class New_DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceCompliancePolicyStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicySettingState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.")]
        public System.Object[] settingStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The name of the policy for this policyBase</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The version of the policy</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Platform type that the policy applies to</para>
        ///     <para type="description">
        ///          Valid values: &apos;android&apos;, &apos;iOS&apos;, &apos;macOS&apos;, &apos;windowsPhone81&apos;, &apos;windows81AndLater&apos;, &apos;windows10AndLater&apos;, &apos;androidWorkProfile&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [ValidateSet(@"android", @"iOS", @"macOS", @"windowsPhone81", @"windows81AndLater", @"windows10AndLater", @"androidWorkProfile", @"all")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The compliance state of the policy</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Count of how many setting a policy holds</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 settingCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/{deviceCompliancePolicyStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCompliancePolicyState&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
    ///     <para type="description">Device compliance policy states for this device.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceCompliancePolicyState")]
    [ODataType("microsoft.graph.deviceCompliancePolicyState")]
    [ResourceTypePropertyName("deviceCompliancePolicyStateODataType")]
    [Alias("Update-IntuneManagedDeviceDeviceCompliancePolicyState")]
    public class Update_DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.")]
        public System.String deviceCompliancePolicyStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceCompliancePolicySettingState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingStates&quot; property, of type &quot;microsoft.graph.deviceCompliancePolicySettingState&quot;.")]
        public System.Object[] settingStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The name of the policy for this policyBase</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The version of the policy</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Platform type that the policy applies to</para>
        ///     <para type="description">
        ///          Valid values: &apos;android&apos;, &apos;iOS&apos;, &apos;macOS&apos;, &apos;windowsPhone81&apos;, &apos;windows81AndLater&apos;, &apos;windows10AndLater&apos;, &apos;androidWorkProfile&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [ValidateSet(@"android", @"iOS", @"macOS", @"windowsPhone81", @"windows81AndLater", @"windows10AndLater", @"androidWorkProfile", @"all")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">The compliance state of the policy</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicyState&quot; type.</para>
        ///     <para type="description">Count of how many setting a policy holds</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicyState", HelpMessage = @"The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 settingCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/{deviceCompliancePolicyStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object from the &quot;deviceCompliancePolicyStates&quot; collection.</para>
    ///     <para type="description">Device compliance policy states for this device.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/deviceCompliancePolicyStateId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicyState")]
    [ResourceTypePropertyName("deviceCompliancePolicyStateODataType")]
    [Alias("Remove-IntuneManagedDeviceDeviceCompliancePolicyState")]
    public class Remove_DeviceManagement_ManagedDevices_DeviceCompliancePolicyStates : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicyState&quot; object in the &quot;deviceCompliancePolicyStates&quot; collection.")]
        public System.String deviceCompliancePolicyStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/{deviceCompliancePolicyStateId}";
        }
    }
}