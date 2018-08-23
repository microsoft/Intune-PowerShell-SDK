// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.recentNotebook&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.recentNotebook&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RecentNotebookObject", DefaultParameterSetName = @"microsoft.graph.recentNotebook")]
    [ODataType("microsoft.graph.recentNotebook")]
    public class New_RecentNotebookObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recentNotebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.recentNotebook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastAccessedTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recentNotebook&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.recentNotebook", HelpMessage = @"The &quot;lastAccessedTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastAccessedTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.recentNotebookLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recentNotebook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recentNotebookLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.recentNotebook", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.recentNotebookLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceService&quot; property, of type &quot;microsoft.graph.onenoteSourceService&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recentNotebook&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;Unknown&apos;, &apos;OneDrive&apos;, &apos;OneDriveForBusiness&apos;, &apos;OnPremOneDriveForBusiness&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSourceService")]
        [Selectable]
        [ValidateSet(@"Unknown", @"OneDrive", @"OneDriveForBusiness", @"OnPremOneDriveForBusiness")]
        [Parameter(ParameterSetName = @"microsoft.graph.recentNotebook", HelpMessage = @"The &quot;sourceService&quot; property, of type &quot;microsoft.graph.onenoteSourceService&quot;.")]
        public System.String sourceService { get; set; }
    }
}