// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamGuestSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamGuestSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamGuestSettingsObject", DefaultParameterSetName = @"microsoft.graph.teamGuestSettings")]
    [ODataType("microsoft.graph.teamGuestSettings")]
    public class New_TeamGuestSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowCreateUpdateChannels&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamGuestSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamGuestSettings", HelpMessage = @"The &quot;allowCreateUpdateChannels&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowCreateUpdateChannels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowDeleteChannels&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamGuestSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamGuestSettings", HelpMessage = @"The &quot;allowDeleteChannels&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowDeleteChannels { get; set; }
    }
}