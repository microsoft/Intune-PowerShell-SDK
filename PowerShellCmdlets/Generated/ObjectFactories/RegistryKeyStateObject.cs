// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.registryKeyState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.registryKeyState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "RegistryKeyStateObject", DefaultParameterSetName = @"microsoft.graph.registryKeyState")]
    [ODataType("microsoft.graph.registryKeyState")]
    public class New_RegistryKeyStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;hive&quot; property, of type &quot;microsoft.graph.registryHive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;currentConfig&apos;, &apos;currentUser&apos;, &apos;localMachineSam&apos;, &apos;localMachineSecurity&apos;, &apos;localMachineSoftware&apos;, &apos;localMachineSystem&apos;, &apos;usersDefault&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.registryHive")]
        [Selectable]
        [ValidateSet(@"unknown", @"currentConfig", @"currentUser", @"localMachineSam", @"localMachineSecurity", @"localMachineSoftware", @"localMachineSystem", @"usersDefault", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;hive&quot; property, of type &quot;microsoft.graph.registryHive&quot;.")]
        public System.String hive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;key&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;key&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String key { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oldKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;oldKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String oldKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oldValueData&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;oldValueData&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String oldValueData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oldValueName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;oldValueName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String oldValueName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operation&quot; property, of type &quot;microsoft.graph.registryOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;create&apos;, &apos;modify&apos;, &apos;delete&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.registryOperation")]
        [Selectable]
        [ValidateSet(@"unknown", @"create", @"modify", @"delete", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;operation&quot; property, of type &quot;microsoft.graph.registryOperation&quot;.")]
        public System.String operation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;processId&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;processId&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 processId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueData&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;valueData&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String valueData { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;valueName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String valueName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueType&quot; property, of type &quot;microsoft.graph.registryValueType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.registryKeyState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;binary&apos;, &apos;dword&apos;, &apos;dwordLittleEndian&apos;, &apos;dwordBigEndian&apos;, &apos;expandSz&apos;, &apos;link&apos;, &apos;multiSz&apos;, &apos;none&apos;, &apos;qword&apos;, &apos;qwordlittleEndian&apos;, &apos;sz&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.registryValueType")]
        [Selectable]
        [ValidateSet(@"unknown", @"binary", @"dword", @"dwordLittleEndian", @"dwordBigEndian", @"expandSz", @"link", @"multiSz", @"none", @"qword", @"qwordlittleEndian", @"sz", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.registryKeyState", HelpMessage = @"The &quot;valueType&quot; property, of type &quot;microsoft.graph.registryValueType&quot;.")]
        public System.String valueType { get; set; }
    }
}