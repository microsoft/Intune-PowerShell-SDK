// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.thumbnailSet&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.thumbnailSet&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ThumbnailSetObject", DefaultParameterSetName = @"#microsoft.graph.thumbnailSet")]
    [ODataType("microsoft.graph.thumbnailSet")]
    public class New_ThumbnailSetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;large&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object Large { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;medium&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object Medium { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;small&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object Small { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnailSet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.thumbnail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.thumbnailSet", HelpMessage = @"The &quot;source&quot; property, of type &quot;microsoft.graph.thumbnail&quot;.")]
        public System.Object Source { get; set; }
    }
}