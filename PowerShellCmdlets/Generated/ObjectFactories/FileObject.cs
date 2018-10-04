// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.file&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.file&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "FileObject", DefaultParameterSetName = @"microsoft.graph.file")]
    [ODataType("microsoft.graph.file")]
    public class New_FileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;hashes&quot; property, of type &quot;microsoft.graph.hashes&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.file&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.hashes")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.file", HelpMessage = @"The &quot;hashes&quot; property, of type &quot;microsoft.graph.hashes&quot;.")]
        public System.Object hashes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mimeType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.file&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.file", HelpMessage = @"The &quot;mimeType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mimeType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;processingMetadata&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.file&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.file", HelpMessage = @"The &quot;processingMetadata&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean processingMetadata { get; set; }
    }
}