// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.thumbnail&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.thumbnail&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ThumbnailObject", DefaultParameterSetName = @"microsoft.graph.thumbnail")]
    [ODataType("microsoft.graph.thumbnail")]
    public class New_ThumbnailObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.thumbnail", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.thumbnail", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceItemId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.thumbnail", HelpMessage = @"The &quot;sourceItemId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sourceItemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.thumbnail", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.thumbnail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.thumbnail", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 width { get; set; }
    }
}