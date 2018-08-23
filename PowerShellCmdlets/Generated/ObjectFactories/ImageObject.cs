// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.image&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.image&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ImageObject", DefaultParameterSetName = @"microsoft.graph.image")]
    [ODataType("microsoft.graph.image")]
    public class New_ImageObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.image&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.image", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.image&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.image", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 width { get; set; }
    }
}