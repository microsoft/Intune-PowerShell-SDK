// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.report&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.report&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ReportObject", DefaultParameterSetName = @"#microsoft.graph.report")]
    [ODataType("microsoft.graph.report")]
    public class New_ReportObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.report&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.report", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }
    }
}