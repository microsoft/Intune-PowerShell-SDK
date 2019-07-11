// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemPreviewInfo&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemPreviewInfo&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemPreviewInfoObject", DefaultParameterSetName = @"microsoft.graph.itemPreviewInfo")]
    [ODataType("microsoft.graph.itemPreviewInfo")]
    public class New_ItemPreviewInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;getUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemPreviewInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemPreviewInfo", HelpMessage = @"The &quot;getUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String getUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postParameters&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemPreviewInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemPreviewInfo", HelpMessage = @"The &quot;postParameters&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String postParameters { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemPreviewInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemPreviewInfo", HelpMessage = @"The &quot;postUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String postUrl { get; set; }
    }
}