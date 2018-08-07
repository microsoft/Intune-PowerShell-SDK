// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookFilterCriteria&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookFilterCriteria&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookFilterCriteriaObject", DefaultParameterSetName = @"#microsoft.graph.workbookFilterCriteria")]
    [ODataType("microsoft.graph.workbookFilterCriteria")]
    public class New_WorkbookFilterCriteriaObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;color&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String color { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criterion1&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;criterion1&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String criterion1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criterion2&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;criterion2&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String criterion2 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dynamicCriteria&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;dynamicCriteria&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String dynamicCriteria { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filterOn&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;filterOn&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String filterOn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;icon&quot; property, of type &quot;microsoft.graph.workbookIcon&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookIcon")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;icon&quot; property, of type &quot;microsoft.graph.workbookIcon&quot;.")]
        public System.Object icon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operator&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;operator&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String @operator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookFilterCriteria&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookFilterCriteria", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object values { get; set; }
    }
}