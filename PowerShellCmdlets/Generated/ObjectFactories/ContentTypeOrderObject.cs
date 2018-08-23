// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.contentTypeOrder&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.contentTypeOrder&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ContentTypeOrderObject", DefaultParameterSetName = @"microsoft.graph.contentTypeOrder")]
    [ODataType("microsoft.graph.contentTypeOrder")]
    public class New_ContentTypeOrderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;default&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentTypeOrder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.contentTypeOrder", HelpMessage = @"The &quot;default&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean @default { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contentTypeOrder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.contentTypeOrder", HelpMessage = @"The &quot;position&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 position { get; set; }
    }
}