// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookFunctionResult&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookFunctionResult&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookFunctionResultObject", DefaultParameterSetName = @"microsoft.graph.workbookFunctionResult")]
    [ODataType("microsoft.graph.workbookFunctionResult")]
    public class New_WorkbookFunctionResultObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFunctionResult&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookFunctionResult", HelpMessage = @"The &quot;error&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFunctionResult&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookFunctionResult", HelpMessage = @"The &quot;value&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object value { get; set; }
    }
}