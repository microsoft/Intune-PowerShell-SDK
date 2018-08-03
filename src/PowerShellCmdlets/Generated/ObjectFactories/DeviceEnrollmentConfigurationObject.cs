// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceEnrollmentConfigurationObject", DefaultParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration")]
    [ODataType("microsoft.graph.deviceEnrollmentConfiguration")]
    public class New_DeviceEnrollmentConfigurationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;priority&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Priority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignments for the device configuration profile.</para>
        /// </summary>
        [ODataType("microsoft.graph.enrollmentConfigurationAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.enrollmentConfigurationAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter DeviceEnrollmentWindowsHelloForBusinessConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMinimumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinMinimumLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinMaximumLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinMaximumLength { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinUppercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String PinUppercaseCharactersUsage { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinLowercaseCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String PinLowercaseCharactersUsage { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinSpecialCharactersUsage&quot; property, of type &quot;microsoft.graph.windowsHelloForBusinessPinUsage&quot;.")]
        public System.String PinSpecialCharactersUsage { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;securityDeviceRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SecurityDeviceRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;unlockWithBiometricsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean UnlockWithBiometricsEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;remotePassportEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean RemotePassportEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinPreviousBlockCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinPreviousBlockCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;pinExpirationInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 PinExpirationInDays { get; set; }

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
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration", HelpMessage = @"The &quot;enhancedBiometricsState&quot; property, of type &quot;microsoft.graph.enablement&quot;.")]
        public System.String EnhancedBiometricsState { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter DeviceEnrollmentPlatformRestrictionsConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;iosRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object IosRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object WindowsRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;windowsMobileRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object WindowsMobileRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;androidRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object AndroidRestriction { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentPlatformRestriction")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration", HelpMessage = @"The &quot;macOSRestriction&quot; property, of type &quot;microsoft.graph.deviceEnrollmentPlatformRestriction&quot;.")]
        public System.Object MacOSRestriction { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceEnrollmentLimitConfiguration")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter DeviceEnrollmentLimitConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceEnrollmentLimitConfiguration&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceEnrollmentLimitConfiguration", HelpMessage = @"The &quot;limit&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Limit { get; set; }
    }
}