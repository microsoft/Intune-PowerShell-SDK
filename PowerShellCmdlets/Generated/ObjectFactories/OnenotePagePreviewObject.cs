// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenotePagePreview&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenotePagePreview&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenotePagePreviewObject", DefaultParameterSetName = @"microsoft.graph.onenotePagePreview")]
    [ODataType("microsoft.graph.onenotePagePreview")]
    public class New_OnenotePagePreviewObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;previewText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePagePreview&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onenotePagePreview", HelpMessage = @"The &quot;previewText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String previewText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.onenotePagePreviewLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePagePreview&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePagePreviewLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onenotePagePreview", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.onenotePagePreviewLinks&quot;.")]
        public System.Object links { get; set; }
    }
}