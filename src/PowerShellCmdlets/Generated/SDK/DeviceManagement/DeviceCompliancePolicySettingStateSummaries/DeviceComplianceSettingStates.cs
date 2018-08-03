// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceComplianceSettingState&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceComplianceSettingState&quot; objects in the &quot;deviceComplianceSettingStates&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceIdPropertyName("DeviceComplianceSettingStateId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String DeviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String DeviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String SettingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DeviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [Sortable]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{DeviceComplianceSettingStateId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceSettingState&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceComplianceSettingState&quot; object to the &quot;deviceComplianceSettingStates&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceSettingState")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String DeviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SettingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceSettingState&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceSettingState")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceIdPropertyName("DeviceComplianceSettingStateId")]
    public class Update_DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String DeviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String DeviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SettingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ComplianceGracePeriodExpirationDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{DeviceComplianceSettingStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceSettingState&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/DeviceComplianceSettingStateId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceComplianceSettingState&quot; object from the &quot;deviceComplianceSettingStates&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceIdPropertyName("DeviceComplianceSettingStateId")]
    public class Remove_DeviceManagement_DeviceCompliancePolicySettingStateSummaries_DeviceComplianceSettingStates : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String DeviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String DeviceCompliancePolicySettingStateSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{DeviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{DeviceComplianceSettingStateId}";
        }
    }
}