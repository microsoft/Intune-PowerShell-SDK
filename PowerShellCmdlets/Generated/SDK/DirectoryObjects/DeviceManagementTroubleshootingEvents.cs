// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; objects.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; objects in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Get", "DirectoryObjects_DeviceManagementTroubleshootingEvents", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent", "microsoft.graph.enrollmentTroubleshootingEvent")]
    [ResourceTypePropertyName("deviceManagementTroubleshootingEventODataType")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    [ResourceReference]
    public class Get_DirectoryObjects_DeviceManagementTroubleshootingEvents : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object.</para>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object to the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("New", "DirectoryObjects_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent", "microsoft.graph.enrollmentTroubleshootingEvent")]
    [ResourceTypePropertyName("deviceManagementTroubleshootingEventODataType")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    [ResourceReference]
    public class New_DirectoryObjects_DeviceManagementTroubleshootingEvents : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceManagementTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.enrollmentTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter enrollmentTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;userEnrollment&apos;, &apos;deviceEnrollmentManager&apos;, &apos;appleBulkWithUser&apos;, &apos;appleBulkWithoutUser&apos;, &apos;windowsAzureADJoin&apos;, &apos;windowsBulkUserless&apos;, &apos;windowsAutoEnrollment&apos;, &apos;windowsBulkAzureDomainJoin&apos;, &apos;windowsCoManagement&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [ValidateSet(@"unknown", @"userEnrollment", @"deviceEnrollmentManager", @"appleBulkWithUser", @"appleBulkWithoutUser", @"windowsAzureADJoin", @"windowsBulkUserless", @"windowsAutoEnrollment", @"windowsBulkAzureDomainJoin", @"windowsCoManagement")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;authentication&apos;, &apos;authorization&apos;, &apos;accountValidation&apos;, &apos;userValidation&apos;, &apos;deviceNotSupported&apos;, &apos;inMaintenance&apos;, &apos;badRequest&apos;, &apos;featureNotSupported&apos;, &apos;enrollmentRestrictionsEnforced&apos;, &apos;clientDisconnected&apos;, &apos;userAbandonment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [ValidateSet(@"unknown", @"authentication", @"authorization", @"accountValidation", @"userValidation", @"deviceNotSupported", @"inMaintenance", @"badRequest", @"featureNotSupported", @"enrollmentRestrictionsEnforced", @"clientDisconnected", @"userAbandonment")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
    ///     <para type="description">PATCH ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Update", "DirectoryObjects_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent", "microsoft.graph.enrollmentTroubleshootingEvent")]
    [ResourceTypePropertyName("deviceManagementTroubleshootingEventODataType")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    public class Update_DirectoryObjects_DeviceManagementTroubleshootingEvents : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceManagementTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.enrollmentTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter enrollmentTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;userEnrollment&apos;, &apos;deviceEnrollmentManager&apos;, &apos;appleBulkWithUser&apos;, &apos;appleBulkWithoutUser&apos;, &apos;windowsAzureADJoin&apos;, &apos;windowsBulkUserless&apos;, &apos;windowsAutoEnrollment&apos;, &apos;windowsBulkAzureDomainJoin&apos;, &apos;windowsCoManagement&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [ValidateSet(@"unknown", @"userEnrollment", @"deviceEnrollmentManager", @"appleBulkWithUser", @"appleBulkWithoutUser", @"windowsAzureADJoin", @"windowsBulkUserless", @"windowsAutoEnrollment", @"windowsBulkAzureDomainJoin", @"windowsCoManagement")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;authentication&apos;, &apos;authorization&apos;, &apos;accountValidation&apos;, &apos;userValidation&apos;, &apos;deviceNotSupported&apos;, &apos;inMaintenance&apos;, &apos;badRequest&apos;, &apos;featureNotSupported&apos;, &apos;enrollmentRestrictionsEnforced&apos;, &apos;clientDisconnected&apos;, &apos;userAbandonment&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [ValidateSet(@"unknown", @"authentication", @"authorization", @"accountValidation", @"userValidation", @"deviceNotSupported", @"inMaintenance", @"badRequest", @"featureNotSupported", @"enrollmentRestrictionsEnforced", @"clientDisconnected", @"userAbandonment")]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object.</para>
    ///     <para type="description">DELETE ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents/deviceManagementTroubleshootingEventId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object from the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Remove", "DirectoryObjects_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent", "microsoft.graph.enrollmentTroubleshootingEvent")]
    [ResourceTypePropertyName("deviceManagementTroubleshootingEventODataType")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    public class Remove_DirectoryObjects_DeviceManagementTroubleshootingEvents : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId}";
        }
    }
}