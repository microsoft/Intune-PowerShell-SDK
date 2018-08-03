// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.</para>
    /// </summary>
    [Cmdlet("New", "OnPremisesConditionalAccessSettingsObject", DefaultParameterSetName = @"#microsoft.graph.onPremisesConditionalAccessSettings")]
    [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
    public class New_OnPremisesConditionalAccessSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Indicates if on premises conditional access is enabled for this organization</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] IncludedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] ExcludedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Override the default access rule when allowing a device to ensure access is granted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean OverrideDefaultRule { get; set; }
    }
}