// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.fileSecurityState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.fileSecurityState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "FileSecurityStateObject", DefaultParameterSetName = @"microsoft.graph.fileSecurityState")]
    [ODataType("microsoft.graph.fileSecurityState")]
    public class New_FileSecurityStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;microsoft.graph.fileHash&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileHash")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.fileSecurityState", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;microsoft.graph.fileHash&quot;.")]
        public System.Object fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.fileSecurityState", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;path&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.fileSecurityState", HelpMessage = @"The &quot;path&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String path { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.fileSecurityState", HelpMessage = @"The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String riskScore { get; set; }
    }
}