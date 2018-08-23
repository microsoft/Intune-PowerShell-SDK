// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookFilter&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookFilter&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookFilterObject", DefaultParameterSetName = @"microsoft.graph.workbookFilter")]
    [ODataType("microsoft.graph.workbookFilter")]
    public class New_WorkbookFilterObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; property, of type &quot;microsoft.graph.workbookFilterCriteria&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilter&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFilterCriteria")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookFilter", HelpMessage = @"The &quot;criteria&quot; property, of type &quot;microsoft.graph.workbookFilterCriteria&quot;.")]
        public System.Object criteria { get; set; }
    }
}