// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFill&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRangeFill&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeFillObject", DefaultParameterSetName = @"#microsoft.graph.workbookRangeFill")]
    [ODataType("microsoft.graph.workbookRangeFill")]
    public class New_WorkbookRangeFillObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeFill&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeFill", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }
    }
}