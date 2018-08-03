// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;userStatusOverview&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview</para>
    ///     <para type="description">Retrieves the &quot;userStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;).</para>
    ///     <para type="description">Device compliance users status overview</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCompliancePolicies_UserStatusOverview", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceComplianceUserOverview")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCompliancePolicies_UserStatusOverview : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of pending Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of error Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of failed Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConfigurationVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceUserOverview&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview</para>
    ///     <para type="description">Creates the &quot;userStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;).</para>
    ///     <para type="description">Device compliance users status overview</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCompliancePolicies_UserStatusOverview", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview")]
    [ODataType("microsoft.graph.deviceComplianceUserOverview")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCompliancePolicies_UserStatusOverview : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of pending Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of error Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of failed Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceUserOverview&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview</para>
    ///     <para type="description">Updates the &quot;userStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;).</para>
    ///     <para type="description">Device compliance users status overview</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCompliancePolicies_UserStatusOverview", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview")]
    [ODataType("microsoft.graph.deviceComplianceUserOverview")]
    public class Update_DeviceManagement_DeviceCompliancePolicies_UserStatusOverview : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of pending Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pendingCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PendingCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of not applicable users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notApplicableCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of succeeded Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;successCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 SuccessCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of error Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;errorCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Number of failed Users</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Last update time</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastUpdateDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastUpdateDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceUserOverview&quot; type.</para>
        ///     <para type="description">Version of the policy for that overview</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceComplianceUserOverview", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;configurationVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConfigurationVersion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceUserOverview&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview</para>
    ///     <para type="description">Removes the &quot;userStatusOverview&quot; object (which is of type &quot;microsoft.graph.deviceComplianceUserOverview&quot;).</para>
    ///     <para type="description">Device compliance users status overview</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCompliancePolicies_UserStatusOverview", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceUserOverview")]
    public class Remove_DeviceManagement_DeviceCompliancePolicies_UserStatusOverview : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicy&quot; object in the &quot;deviceCompliancePolicies&quot; collection.")]
        public System.String DeviceCompliancePolicyId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicies/{DeviceCompliancePolicyId}/userStatusOverview";
        }
    }
}