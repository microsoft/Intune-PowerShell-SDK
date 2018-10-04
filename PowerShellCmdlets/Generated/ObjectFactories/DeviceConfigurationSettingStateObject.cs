// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationSettingState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceConfigurationSettingState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceConfigurationSettingStateObject", DefaultParameterSetName = @"microsoft.graph.deviceConfigurationSettingState")]
    [ODataType("microsoft.graph.deviceConfigurationSettingState")]
    public class New_DeviceConfigurationSettingStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">The setting that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Localized/user friendly setting name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;instanceDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Name of setting instance that is being reported.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;instanceDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String instanceDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Error code for the setting</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDescription&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Error description</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;errorDescription&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String errorDescription { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">UserId</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">UserName</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">UserEmail</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">UserPrincipalName.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sources&quot; property, of type &quot;microsoft.graph.settingSource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Contributing policies</para>
        /// </summary>
        [ODataType("microsoft.graph.settingSource")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;sources&quot; property, of type &quot;microsoft.graph.settingSource&quot;.")]
        public System.Object[] sources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;currentValue&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceConfigurationSettingState&quot; type.</para>
        ///     <para type="description">Current value of setting on device</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceConfigurationSettingState", HelpMessage = @"The &quot;currentValue&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String currentValue { get; set; }
    }
}