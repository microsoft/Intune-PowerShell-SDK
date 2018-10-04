// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sizeRange&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sizeRange&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SizeRangeObject", DefaultParameterSetName = @"microsoft.graph.sizeRange")]
    [ODataType("microsoft.graph.sizeRange")]
    public class New_SizeRangeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;minimumSize&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sizeRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sizeRange", HelpMessage = @"The &quot;minimumSize&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 minimumSize { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximumSize&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sizeRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sizeRange", HelpMessage = @"The &quot;maximumSize&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 maximumSize { get; set; }
    }
}