// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ConfigurationManagerClientEnabledFeaturesObject", DefaultParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures")]
    [ODataType("microsoft.graph.configurationManagerClientEnabledFeatures")]
    public class New_ConfigurationManagerClientEnabledFeaturesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;inventory&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether inventory is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;inventory&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean inventory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;modernApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether modern application is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;modernApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean modernApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceAccess&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether resource access is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;resourceAccess&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean resourceAccess { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceConfiguration&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether device configuration is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;deviceConfiguration&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deviceConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliancePolicy&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether compliance policy is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;compliancePolicy&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean compliancePolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsUpdateForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.configurationManagerClientEnabledFeatures&quot; type.</para>
        ///     <para type="description">Whether Windows Update for Business is managed by Intune</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.configurationManagerClientEnabledFeatures", HelpMessage = @"The &quot;windowsUpdateForBusiness&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean windowsUpdateForBusiness { get; set; }
    }
}