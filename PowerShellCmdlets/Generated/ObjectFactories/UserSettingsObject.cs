// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.userSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.userSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "UserSettingsObject", DefaultParameterSetName = @"microsoft.graph.userSettings")]
    [ODataType("microsoft.graph.userSettings")]
    public class New_UserSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;contributionToContentDiscoveryDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSettings", HelpMessage = @"The &quot;contributionToContentDiscoveryDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean contributionToContentDiscoveryDisabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contributionToContentDiscoveryAsOrganizationDisabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSettings", HelpMessage = @"The &quot;contributionToContentDiscoveryAsOrganizationDisabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean contributionToContentDiscoveryAsOrganizationDisabled { get; set; }
    }
}