// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookFilterDatetime&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookFilterDatetime&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookFilterDatetimeObject", DefaultParameterSetName = @"#microsoft.graph.workbookFilterDatetime")]
    [ODataType("microsoft.graph.workbookFilterDatetime")]
    public class New_WorkbookFilterDatetimeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterDatetime&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterDatetime", HelpMessage = @"The &quot;date&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specificity&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterDatetime&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterDatetime", HelpMessage = @"The &quot;specificity&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String specificity { get; set; }
    }
}