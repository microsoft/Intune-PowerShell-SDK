// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookFormatProtection&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookFormatProtection&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookFormatProtectionObject", DefaultParameterSetName = @"microsoft.graph.workbookFormatProtection")]
    [ODataType("microsoft.graph.workbookFormatProtection")]
    public class New_WorkbookFormatProtectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;formulaHidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFormatProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookFormatProtection", HelpMessage = @"The &quot;formulaHidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean formulaHidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locked&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFormatProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookFormatProtection", HelpMessage = @"The &quot;locked&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean locked { get; set; }
    }
}