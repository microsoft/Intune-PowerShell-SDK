// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheetProtection&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookWorksheetProtection&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookWorksheetProtectionObject", DefaultParameterSetName = @"#microsoft.graph.workbookWorksheetProtection")]
    [ODataType("microsoft.graph.workbookWorksheetProtection")]
    public class New_WorkbookWorksheetProtectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheetProtectionOptions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;options&quot; property, of type &quot;microsoft.graph.workbookWorksheetProtectionOptions&quot;.")]
        public System.Object Options { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookWorksheetProtection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookWorksheetProtection", HelpMessage = @"The &quot;protected&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Protected { get; set; }
    }
}