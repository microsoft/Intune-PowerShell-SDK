// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.textColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.textColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "TextColumnObject", DefaultParameterSetName = @"#microsoft.graph.textColumn")]
    [ODataType("microsoft.graph.textColumn")]
    public class New_TextColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowMultipleLines&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.textColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.textColumn", HelpMessage = @"The &quot;allowMultipleLines&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AllowMultipleLines { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appendChangesToExistingText&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.textColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.textColumn", HelpMessage = @"The &quot;appendChangesToExistingText&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AppendChangesToExistingText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;linesForEditing&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.textColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.textColumn", HelpMessage = @"The &quot;linesForEditing&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 LinesForEditing { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maxLength&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.textColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.textColumn", HelpMessage = @"The &quot;maxLength&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 MaxLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;textType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.textColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.textColumn", HelpMessage = @"The &quot;textType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String TextType { get; set; }
    }
}