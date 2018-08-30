// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceConfigurationUserStatus&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceConfigurationUserStatus&quot; objects in the &quot;userStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by user.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceConfigurations_UserStatuses", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceConfigurationUserStatus")]
    [ResourceTypePropertyName("userStatusODataType")]
    [ResourceIdPropertyName("userStatusId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceConfigurations_UserStatuses : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.")]
        public System.String userStatusId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">User name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Devices count for that user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 devicesCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses/{userStatusId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object to the &quot;userStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by user.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceConfigurations_UserStatuses", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus")]
    [ODataType("microsoft.graph.deviceConfigurationUserStatus")]
    [ResourceTypePropertyName("userStatusODataType")]
    [ResourceIdPropertyName("userStatusId")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceConfigurations_UserStatuses : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String userStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">User name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Devices count for that user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 devicesCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses/{userStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceConfigurationUserStatus&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by user.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceConfigurations_UserStatuses", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus")]
    [ODataType("microsoft.graph.deviceConfigurationUserStatus")]
    [ResourceTypePropertyName("userStatusODataType")]
    [ResourceIdPropertyName("userStatusId")]
    public class Update_DeviceManagement_DeviceConfigurations_UserStatuses : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.")]
        public System.String userStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">User name of the DevicePolicyStatus.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Devices count for that user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;devicesCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 devicesCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Compliance status of the policy report.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">Last modified date time of the policy report.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastReportedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastReportedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationUserStatus&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationUserStatus", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses/{userStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses/userStatusId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object from the &quot;userStatuses&quot; collection.</para>
    ///     <para type="description">Device configuration installation status by user.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceConfigurations_UserStatuses", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceConfigurationUserStatus")]
    [ResourceTypePropertyName("userStatusODataType")]
    [ResourceIdPropertyName("userStatusId")]
    public class Remove_DeviceManagement_DeviceConfigurations_UserStatuses : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceConfigurationUserStatus&quot; object in the &quot;userStatuses&quot; collection.")]
        public System.String userStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceConfiguration&quot; object in the &quot;deviceConfigurations&quot; collection.")]
        public System.String deviceConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceConfigurations/{deviceConfigurationId}/userStatuses/{userStatusId}";
        }
    }
}