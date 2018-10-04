// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.resourceVisualization&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.resourceVisualization&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ResourceVisualizationObject", DefaultParameterSetName = @"microsoft.graph.resourceVisualization")]
    [ODataType("microsoft.graph.resourceVisualization")]
    public class New_ResourceVisualizationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mediaType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;mediaType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mediaType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewImageUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;previewImageUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String previewImageUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;previewText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String previewText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;containerWebUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;containerWebUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String containerWebUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;containerDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;containerDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String containerDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;containerType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceVisualization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceVisualization", HelpMessage = @"The &quot;containerType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String containerType { get; set; }
    }
}