// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedAppStatus&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedAppStatus&quot; (or one of its derived types).</para>
    ///     <para type="description">Represents app protection and configuration status for the organization.</para>
    /// </summary>
    [Cmdlet("New", "ManagedAppStatusObject", DefaultParameterSetName = @"microsoft.graph.managedAppStatus")]
    [ODataType("microsoft.graph.managedAppStatus")]
    public class New_ManagedAppStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Friendly name of the status report.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.managedAppStatusRaw")]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatusRaw", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.")]
        public System.Management.Automation.SwitchParameter managedAppStatusRaw { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        ///     <para type="description">Status report content.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object content { get; set; }
    }
}