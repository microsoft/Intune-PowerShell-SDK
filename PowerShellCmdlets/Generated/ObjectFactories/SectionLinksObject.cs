// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sectionLinks&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sectionLinks&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SectionLinksObject", DefaultParameterSetName = @"microsoft.graph.sectionLinks")]
    [ODataType("microsoft.graph.sectionLinks")]
    public class New_SectionLinksObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sectionLinks", HelpMessage = @"The &quot;oneNoteClientUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object oneNoteClientUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sectionLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sectionLinks", HelpMessage = @"The &quot;oneNoteWebUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object oneNoteWebUrl { get; set; }
    }
}