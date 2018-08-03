// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenotePagePreviewLinks&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenotePagePreviewLinks&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenotePagePreviewLinksObject", DefaultParameterSetName = @"#microsoft.graph.onenotePagePreviewLinks")]
    [ODataType("microsoft.graph.onenotePagePreviewLinks")]
    public class New_OnenotePagePreviewLinksObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;previewImageUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePagePreviewLinks&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.externalLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePagePreviewLinks", HelpMessage = @"The &quot;previewImageUrl&quot; property, of type &quot;microsoft.graph.externalLink&quot;.")]
        public System.Object PreviewImageUrl { get; set; }
    }
}