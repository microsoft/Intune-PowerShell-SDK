// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookRangeBorder&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookRangeBorder&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookRangeBorderObject", DefaultParameterSetName = @"#microsoft.graph.workbookRangeBorder")]
    [ODataType("microsoft.graph.workbookRangeBorder")]
    public class New_WorkbookRangeBorderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeBorder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeBorder", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sideIndex&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeBorder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeBorder", HelpMessage = @"The &quot;sideIndex&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sideIndex { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;style&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeBorder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeBorder", HelpMessage = @"The &quot;style&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String style { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;weight&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookRangeBorder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookRangeBorder", HelpMessage = @"The &quot;weight&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String weight { get; set; }
    }
}