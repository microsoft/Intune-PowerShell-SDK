// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.appConfigurationSettingItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.appConfigurationSettingItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AppConfigurationSettingItemObject", DefaultParameterSetName = @"#microsoft.graph.appConfigurationSettingItem")]
    [ODataType("microsoft.graph.appConfigurationSettingItem")]
    public class New_AppConfigurationSettingItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;appConfigKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appConfigurationSettingItem&quot; type.</para>
        ///     <para type="description">app configuration key.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.appConfigurationSettingItem", HelpMessage = @"The &quot;appConfigKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppConfigKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appConfigKeyType&quot; property, of type &quot;microsoft.graph.mdmAppConfigKeyType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appConfigurationSettingItem&quot; type.</para>
        ///     <para type="description">app configuration key type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;stringType&apos;, &apos;integerType&apos;, &apos;realType&apos;, &apos;booleanType&apos;, &apos;tokenType&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mdmAppConfigKeyType")]
        [Selectable]
        [ValidateSet(@"stringType", @"integerType", @"realType", @"booleanType", @"tokenType")]
        [Parameter(ParameterSetName = @"#microsoft.graph.appConfigurationSettingItem", HelpMessage = @"The &quot;appConfigKeyType&quot; property, of type &quot;microsoft.graph.mdmAppConfigKeyType&quot;.")]
        public System.String AppConfigKeyType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appConfigKeyValue&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appConfigurationSettingItem&quot; type.</para>
        ///     <para type="description">app configuration key value.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.appConfigurationSettingItem", HelpMessage = @"The &quot;appConfigKeyValue&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppConfigKeyValue { get; set; }
    }
}