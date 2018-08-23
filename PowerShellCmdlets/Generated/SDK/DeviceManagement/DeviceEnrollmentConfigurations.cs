// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceEnrollmentConfigurations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; objects in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
    ///     <para type="description">The list of device enrollment configurations</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceEnrollmentConfigurations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceEnrollmentConfigurations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.")]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 priority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignments for the device configuration profile.</para>
        /// </summary>
        [ODataType("microsoft.graph.enrollmentConfigurationAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Int32 pinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Int32 pinMaximumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.String pinUppercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.String pinLowercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.String pinSpecialCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Boolean securityDeviceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Boolean unlockWithBiometricsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Boolean remotePassportEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Int32 pinPreviousBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.Int32 pinExpirationInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        public System.String enhancedBiometricsState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        public System.Object iosRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        public System.Object windowsRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        public System.Object windowsMobileRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        public System.Object androidRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        public System.Object macOSRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.deviceEnrollmentLimitConfiguration")]
        public System.Int32 limit { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceEnrollmentConfigurations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object to the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
    ///     <para type="description">The list of device enrollment configurations</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceEnrollmentConfigurations", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceEnrollmentConfigurations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 priority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignments for the device configuration profile.</para>
        /// </summary>
        [ODataType("microsoft.graph.enrollmentConfigurationAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentWindowsHelloForBusinessConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinMaximumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinUppercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinLowercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinSpecialCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notConfigured&apos;, &apos;enabled&apos;, &apos;disabled&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [ValidateSet(@"notConfigured", @"enabled", @"disabled")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityDeviceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean unlockWithBiometricsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean remotePassportEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinPreviousBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinExpirationInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notConfigured&apos;, &apos;enabled&apos;, &apos;disabled&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [ValidateSet(@"notConfigured", @"enabled", @"disabled")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String enhancedBiometricsState { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentPlatformRestrictionsConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object iosRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object windowsRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object windowsMobileRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object androidRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object macOSRestriction { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentLimitConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentLimitConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 limit { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceEnrollmentConfigurations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
    ///     <para type="description">The list of device enrollment configurations</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceEnrollmentConfigurations", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    public class Update_DeviceManagement_DeviceEnrollmentConfigurations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.")]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 priority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignments for the device configuration profile.</para>
        /// </summary>
        [ODataType("microsoft.graph.enrollmentConfigurationAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentWindowsHelloForBusinessConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinMaximumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinUppercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinLowercaseCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;allowed&apos;, &apos;required&apos;, &apos;disallowed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsHelloForBusinessPinUsage")]
        [Selectable]
        [ValidateSet(@"allowed", @"required", @"disallowed")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String pinSpecialCharactersUsage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notConfigured&apos;, &apos;enabled&apos;, &apos;disabled&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [ValidateSet(@"notConfigured", @"enabled", @"disabled")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityDeviceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean unlockWithBiometricsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean remotePassportEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinPreviousBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 pinExpirationInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notConfigured&apos;, &apos;enabled&apos;, &apos;disabled&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.enablement")]
        [Selectable]
        [ValidateSet(@"notConfigured", @"enabled", @"disabled")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String enhancedBiometricsState { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentPlatformRestrictionsConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object iosRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object windowsRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object windowsMobileRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object androidRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object macOSRestriction { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceEnrollmentLimitConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceEnrollmentLimitConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 limit { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceEnrollmentConfigurations/deviceEnrollmentConfigurationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object from the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
    ///     <para type="description">The list of device enrollment configurations</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceEnrollmentConfigurations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    public class Remove_DeviceManagement_DeviceEnrollmentConfigurations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.")]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceManagement/deviceEnrollmentConfigurations/setPriority</para>
    ///     <para type="description">The action &quot;microsoft.graph.setPriority&quot;, which exists on the type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceManagement_DeviceEnrollmentConfigurations_SetPriority", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    public class Invoke_DeviceManagement_DeviceEnrollmentConfigurations_SetPriority : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;priority&quot; parameter, which is accepted by the &quot;microsoft.graph.setPriority&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;priority&quot; parameter, which is accepted by the &quot;microsoft.graph.setPriority&quot; action.")]
        public System.Int32 priority { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.")]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId}/setPriority";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceManagement/deviceEnrollmentConfigurations/assign</para>
    ///     <para type="description">The action &quot;microsoft.graph.assign&quot;, which exists on the type &quot;microsoft.graph.deviceEnrollmentConfiguration&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceManagement_DeviceEnrollmentConfigurations_Assign", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration", "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", "microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", "microsoft.graph.deviceEnrollmentLimitConfiguration")]
    [ResourceTypePropertyName("deviceEnrollmentConfigurationODataType")]
    [ResourceIdPropertyName("deviceEnrollmentConfigurationId")]
    public class Invoke_DeviceManagement_DeviceEnrollmentConfigurations_Assign : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;enrollmentConfigurationAssignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.enrollmentConfigurationAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;enrollmentConfigurationAssignments&quot; parameter, which is accepted by the &quot;microsoft.graph.assign&quot; action.")]
        public System.Object[] enrollmentConfigurationAssignments { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; object in the &quot;deviceEnrollmentConfigurations&quot; collection.")]
        public System.String deviceEnrollmentConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfigurationId}/assign";
        }
    }
}