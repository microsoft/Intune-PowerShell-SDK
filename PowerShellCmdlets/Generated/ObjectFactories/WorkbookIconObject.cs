// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookIcon&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookIcon&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookIconObject", DefaultParameterSetName = @"microsoft.graph.workbookIcon")]
    [ODataType("microsoft.graph.workbookIcon")]
    public class New_WorkbookIconObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookIcon&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookIcon", HelpMessage = @"The &quot;index&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 index { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;set&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookIcon&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookIcon", HelpMessage = @"The &quot;set&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String set { get; set; }
    }
}