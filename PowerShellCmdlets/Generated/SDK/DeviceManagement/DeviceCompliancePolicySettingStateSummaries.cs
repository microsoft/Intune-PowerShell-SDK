// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; objects in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
    ///     <para type="description">The summary states of compliance policy settings for this account.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/deviceCompliancePolicySettingStateSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ResourceTypePropertyName("deviceCompliancePolicySettingStateSummaryODataType")]
    [ResourceReference]
    [Alias("Get-IntuneDeviceCompliancePolicySettingSummary")]
    public class Get_DeviceManagement_DeviceCompliancePolicySettingStateSummaries : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Name of the setting.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Setting platform</para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [Sortable]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 unknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 notApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 compliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 remediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 nonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 errorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 conflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceSettingState")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceComplianceSettingStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object to the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
    ///     <para type="description">The summary states of compliance policy settings for this account.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/deviceCompliancePolicySettingStateSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ResourceTypePropertyName("deviceCompliancePolicySettingStateSummaryODataType")]
    [ResourceReference]
    [Alias("New-IntuneDeviceCompliancePolicySettingSummary")]
    public class New_DeviceManagement_DeviceCompliancePolicySettingStateSummaries : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Name of the setting.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Setting platform</para>
        ///     <para type="description">
        ///          Valid values: &apos;android&apos;, &apos;iOS&apos;, &apos;macOS&apos;, &apos;windowsPhone81&apos;, &apos;windows81AndLater&apos;, &apos;windows10AndLater&apos;, &apos;androidWorkProfile&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [ValidateSet(@"android", @"iOS", @"macOS", @"windowsPhone81", @"windows81AndLater", @"windows10AndLater", @"androidWorkProfile", @"all")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 compliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 remediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 nonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 conflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceSettingState")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.")]
        public System.Object[] deviceComplianceSettingStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
    ///     <para type="description">The summary states of compliance policy settings for this account.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/deviceCompliancePolicySettingStateSummaries</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ResourceTypePropertyName("deviceCompliancePolicySettingStateSummaryODataType")]
    [Alias("Update-IntuneDeviceCompliancePolicySettingSummary")]
    public class Update_DeviceManagement_DeviceCompliancePolicySettingStateSummaries : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Name of the setting.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Setting platform</para>
        ///     <para type="description">
        ///          Valid values: &apos;android&apos;, &apos;iOS&apos;, &apos;macOS&apos;, &apos;windowsPhone81&apos;, &apos;windows81AndLater&apos;, &apos;windows10AndLater&apos;, &apos;androidWorkProfile&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.policyPlatformType")]
        [Selectable]
        [ValidateSet(@"android", @"iOS", @"macOS", @"windowsPhone81", @"windows81AndLater", @"windows10AndLater", @"androidWorkProfile", @"all")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;platformType&quot; property, of type &quot;microsoft.graph.policyPlatformType&quot;.")]
        public System.String platformType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 compliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 remediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of NonCompliant devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 nonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of error devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 conflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceComplianceSettingState")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceCompliancePolicySettingStateSummary", HelpMessage = @"The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceComplianceSettingStates&quot; property, of type &quot;microsoft.graph.deviceComplianceSettingState&quot;.")]
        public System.Object[] deviceComplianceSettingStates { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object from the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
    ///     <para type="description">The summary states of compliance policy settings for this account.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/deviceCompliancePolicySettingStateSummaryId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCompliancePolicySettingStateSummary")]
    [ResourceTypePropertyName("deviceCompliancePolicySettingStateSummaryODataType")]
    [Alias("Remove-IntuneDeviceCompliancePolicySettingSummary")]
    public class Remove_DeviceManagement_DeviceCompliancePolicySettingStateSummaries : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}";
        }
    }
}