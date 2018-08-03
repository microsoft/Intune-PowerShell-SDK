// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenoteOperationError&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenoteOperationError&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenoteOperationErrorObject", DefaultParameterSetName = @"#microsoft.graph.onenoteOperationError")]
    [ODataType("microsoft.graph.onenoteOperationError")]
    public class New_OnenoteOperationErrorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;code&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperationError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperationError", HelpMessage = @"The &quot;code&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Code { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;message&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperationError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperationError", HelpMessage = @"The &quot;message&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Message { get; set; }
    }
}