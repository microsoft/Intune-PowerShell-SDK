// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsUpdateInstallScheduleType&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsUpdateInstallScheduleType&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsUpdateInstallScheduleTypeObject", DefaultParameterSetName = @"microsoft.graph.windowsUpdateInstallScheduleType")]
    [ODataType("microsoft.graph.windowsUpdateInstallScheduleType")]
    public class New_WindowsUpdateInstallScheduleTypeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUpdateActiveHoursInstall&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsUpdateActiveHoursInstall")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateActiveHoursInstall", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUpdateActiveHoursInstall&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsUpdateActiveHoursInstall { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeHoursStart&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUpdateActiveHoursInstall&quot; type.</para>
        ///     <para type="description">Active Hours Start</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateActiveHoursInstall", HelpMessage = @"The &quot;activeHoursStart&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan activeHoursStart { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activeHoursEnd&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUpdateActiveHoursInstall&quot; type.</para>
        ///     <para type="description">Active Hours End</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateActiveHoursInstall", HelpMessage = @"The &quot;activeHoursEnd&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan activeHoursEnd { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUpdateScheduledInstall&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsUpdateScheduledInstall")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateScheduledInstall", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUpdateScheduledInstall&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsUpdateScheduledInstall { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledInstallDay&quot; property, of type &quot;microsoft.graph.weeklySchedule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUpdateScheduledInstall&quot; type.</para>
        ///     <para type="description">Scheduled Install Day in week</para>
        ///     <para type="description">
        ///          Valid values: &apos;userDefined&apos;, &apos;everyday&apos;, &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos;, &apos;saturday&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.weeklySchedule")]
        [Selectable]
        [ValidateSet(@"userDefined", @"everyday", @"sunday", @"monday", @"tuesday", @"wednesday", @"thursday", @"friday", @"saturday")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateScheduledInstall", HelpMessage = @"The &quot;scheduledInstallDay&quot; property, of type &quot;microsoft.graph.weeklySchedule&quot;.")]
        public System.String scheduledInstallDay { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledInstallTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUpdateScheduledInstall&quot; type.</para>
        ///     <para type="description">Scheduled Install Time during day</para>
        /// </summary>
        [ODataType("Edm.TimeOfDay")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsUpdateScheduledInstall", HelpMessage = @"The &quot;scheduledInstallTime&quot; property, of type &quot;Edm.TimeOfDay&quot;.")]
        public System.TimeSpan scheduledInstallTime { get; set; }
    }
}