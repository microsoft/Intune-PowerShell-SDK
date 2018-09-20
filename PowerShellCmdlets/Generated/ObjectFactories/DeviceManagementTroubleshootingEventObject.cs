// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Event representing an general failure.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementTroubleshootingEventObject", DefaultParameterSetName = @"microsoft.graph.deviceManagementTroubleshootingEvent")]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
    public class New_DeviceManagementTroubleshootingEventObject : ObjectFactoryCmdletBase
    {
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
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
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
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }
    }
}