// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceActionResult&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceActionResult&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceActionResultObject", DefaultParameterSetName = @"microsoft.graph.deviceActionResult")]
    [ODataType("microsoft.graph.deviceActionResult")]
    public class New_DeviceActionResultObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deviceActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceActionResult&quot; type.</para>
        ///     <para type="description">Action name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceActionResult&quot; type.</para>
        ///     <para type="description">State of the action</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;pending&apos;, &apos;canceled&apos;, &apos;active&apos;, &apos;done&apos;, &apos;failed&apos;, &apos;notSupported&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.actionState")]
        [Selectable]
        [ValidateSet(@"none", @"pending", @"canceled", @"active", @"done", @"failed", @"notSupported")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", HelpMessage = @"The &quot;actionState&quot; property, of type &quot;microsoft.graph.actionState&quot;.")]
        public System.String actionState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceActionResult&quot; type.</para>
        ///     <para type="description">Time the action was initiated</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset startDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceActionResult&quot; type.</para>
        ///     <para type="description">Time the action state was last updated</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", HelpMessage = @"The &quot;lastUpdatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastUpdatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.resetPasscodeActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.resetPasscodeActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.resetPasscodeActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter resetPasscodeActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passcode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resetPasscodeActionResult&quot; type.</para>
        ///     <para type="description">Newly generated passcode for the device </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resetPasscodeActionResult", HelpMessage = @"The &quot;passcode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String passcode { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.remoteLockActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.remoteLockActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.remoteLockActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter remoteLockActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unlockPin&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteLockActionResult&quot; type.</para>
        ///     <para type="description">Pin to unlock the client</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteLockActionResult", HelpMessage = @"The &quot;unlockPin&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String unlockPin { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.locateDeviceActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.locateDeviceActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.locateDeviceActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter locateDeviceActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceLocation&quot; property, of type &quot;microsoft.graph.deviceGeoLocation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.locateDeviceActionResult&quot; type.</para>
        ///     <para type="description">device location</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceGeoLocation")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.locateDeviceActionResult", HelpMessage = @"The &quot;deviceLocation&quot; property, of type &quot;microsoft.graph.deviceGeoLocation&quot;.")]
        public System.Object deviceLocation { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deleteUserFromSharedAppleDeviceActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deleteUserFromSharedAppleDeviceActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter deleteUserFromSharedAppleDeviceActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deleteUserFromSharedAppleDeviceActionResult&quot; type.</para>
        ///     <para type="description">User principal name of the user to be deleted</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deleteUserFromSharedAppleDeviceActionResult", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDefenderScanActionResult&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsDefenderScanActionResult")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDefenderScanActionResult&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsDefenderScanActionResult { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scanType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsDefenderScanActionResult&quot; type.</para>
        ///     <para type="description">Scan type either full scan or quick scan</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDefenderScanActionResult", HelpMessage = @"The &quot;scanType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String scanType { get; set; }
    }
}