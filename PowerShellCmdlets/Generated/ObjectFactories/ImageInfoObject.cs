// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.imageInfo&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.imageInfo&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ImageInfoObject", DefaultParameterSetName = @"#microsoft.graph.imageInfo")]
    [ODataType("microsoft.graph.imageInfo")]
    public class New_ImageInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;iconUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.imageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.imageInfo", HelpMessage = @"The &quot;iconUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String iconUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternativeText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.imageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.imageInfo", HelpMessage = @"The &quot;alternativeText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String alternativeText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternateText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.imageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.imageInfo", HelpMessage = @"The &quot;alternateText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String alternateText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;addImageQuery&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.imageInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.imageInfo", HelpMessage = @"The &quot;addImageQuery&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean addImageQuery { get; set; }
    }
}