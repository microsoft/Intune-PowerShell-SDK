// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;softwareUpdateStatusSummary&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/softwareUpdateStatusSummary</para>
    ///     <para type="description">Retrieves the &quot;softwareUpdateStatusSummary&quot; object (which is of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;).</para>
    ///     <para type="description">The software update status summary.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_SoftwareUpdateStatusSummary", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
    public class Get_DeviceManagement_SoftwareUpdateStatusSummary : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">The name of the policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of devices had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 CompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NonCompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 RemediatedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of users had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 UnknownUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConflictUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/softwareUpdateStatusSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;softwareUpdateStatusSummary&quot; object reference.</para>
    ///     <para type="description">GET ~/deviceManagement/softwareUpdateStatusSummary/$ref</para>
    ///     <para type="description">Retrieves the &quot;softwareUpdateStatusSummary&quot; object reference (which is of type &quot;microsoft.graph.softwareUpdateStatusSummary&quot;).</para>
    ///     <para type="description">The software update status summary.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_SoftwareUpdateStatusSummaryReference", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
    public class Get_DeviceManagement_SoftwareUpdateStatusSummaryReference : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">The name of the policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of devices had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 CompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NonCompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 RemediatedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of users had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ErrorUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 UnknownUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 ConflictUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 NotApplicableUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/softwareUpdateStatusSummary/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;deviceManagement&quot; to a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; object.</para>
    ///     <para type="description">PUT ~/deviceManagement/softwareUpdateStatusSummary/$ref</para>
    ///     <para type="description">Creates a reference from the &quot;deviceManagement&quot; object to a &quot;softwareUpdateStatusSummary&quot;.</para>
    ///     <para type="description">The software update status summary.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_SoftwareUpdateStatusSummaryReference", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
    [ResourceIdPropertyName("SoftwareUpdateStatusSummaryReferenceUrl")]
    public class New_DeviceManagement_SoftwareUpdateStatusSummaryReference : PutReferenceToEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; object.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; object.")]
        public System.String SoftwareUpdateStatusSummaryReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/softwareUpdateStatusSummary/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;deviceManagement&quot; to a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/softwareUpdateStatusSummary/$ref</para>
    ///     <para type="description">Removes a reference from the &quot;deviceManagement&quot; object to a &quot;softwareUpdateStatusSummary&quot;.</para>
    ///     <para type="description">The software update status summary.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_SoftwareUpdateStatusSummaryReference", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
    public class Remove_DeviceManagement_SoftwareUpdateStatusSummaryReference : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/softwareUpdateStatusSummary/$ref";
        }
    }
}