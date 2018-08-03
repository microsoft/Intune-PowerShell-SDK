// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.folderView&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.folderView&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "FolderViewObject", DefaultParameterSetName = @"#microsoft.graph.folderView")]
    [ODataType("microsoft.graph.folderView")]
    public class New_FolderViewObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;sortBy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.folderView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.folderView", HelpMessage = @"The &quot;sortBy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SortBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sortOrder&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.folderView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.folderView", HelpMessage = @"The &quot;sortOrder&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SortOrder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;viewType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.folderView&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.folderView", HelpMessage = @"The &quot;viewType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ViewType { get; set; }
    }
}