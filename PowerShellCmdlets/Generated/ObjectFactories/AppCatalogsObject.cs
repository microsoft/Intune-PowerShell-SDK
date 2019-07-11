// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.appCatalogs&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.appCatalogs&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AppCatalogsObject", DefaultParameterSetName = @"microsoft.graph.appCatalogs")]
    [ODataType("microsoft.graph.appCatalogs")]
    public class New_AppCatalogsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;teamsApps&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appCatalogs&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.teamsApp")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.appCatalogs", HelpMessage = @"The &quot;teamsApps&quot; property, of type &quot;microsoft.graph.teamsApp&quot;.")]
        public System.Object[] teamsApps { get; set; }
    }
}