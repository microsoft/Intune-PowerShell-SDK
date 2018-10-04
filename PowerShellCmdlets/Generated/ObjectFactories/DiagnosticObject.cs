// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.diagnostic&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.diagnostic&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DiagnosticObject", DefaultParameterSetName = @"microsoft.graph.diagnostic")]
    [ODataType("microsoft.graph.diagnostic")]
    public class New_DiagnosticObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;message&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.diagnostic&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.diagnostic", HelpMessage = @"The &quot;message&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.diagnostic&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.diagnostic", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }
    }
}