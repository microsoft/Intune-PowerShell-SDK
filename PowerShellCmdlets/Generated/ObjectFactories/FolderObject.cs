// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.folder&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.folder&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "FolderObject", DefaultParameterSetName = @"#microsoft.graph.folder")]
    [ODataType("microsoft.graph.folder")]
    public class New_FolderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;childCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.folder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.folder", HelpMessage = @"The &quot;childCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 childCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;view&quot; property, of type &quot;microsoft.graph.folderView&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.folder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folderView")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.folder", HelpMessage = @"The &quot;view&quot; property, of type &quot;microsoft.graph.folderView&quot;.")]
        public System.Object view { get; set; }
    }
}