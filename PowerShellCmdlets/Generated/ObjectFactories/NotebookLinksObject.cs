// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.notebookLinks&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.notebookLinks&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "NotebookLinksObject", DefaultParameterSetName = @"microsoft.graph.notebookLinks")]
    [ODataType("microsoft.graph.notebookLinks")]
    public class New_NotebookLinksObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebookLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notebookLinks", HelpMessage = @"The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object oneNoteClientUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notebookLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notebookLinks", HelpMessage = @"The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object oneNoteWebUrl { get; set; }
    }
}