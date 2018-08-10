// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.listInfo&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.listInfo&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ListInfoObject", DefaultParameterSetName = @"#microsoft.graph.listInfo")]
    [ODataType("microsoft.graph.listInfo")]
    public class New_ListInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;contentTypesEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listInfo", HelpMessage = @"The &quot;contentTypesEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean contentTypesEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listInfo", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;template&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listInfo", HelpMessage = @"The &quot;template&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String template { get; set; }
    }
}