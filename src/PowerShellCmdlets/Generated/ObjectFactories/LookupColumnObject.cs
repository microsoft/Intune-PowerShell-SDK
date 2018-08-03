// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.lookupColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.lookupColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "LookupColumnObject", DefaultParameterSetName = @"#microsoft.graph.lookupColumn")]
    [ODataType("microsoft.graph.lookupColumn")]
    public class New_LookupColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowMultipleValues&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.lookupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.lookupColumn", HelpMessage = @"The &quot;allowMultipleValues&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AllowMultipleValues { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowUnlimitedLength&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.lookupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.lookupColumn", HelpMessage = @"The &quot;allowUnlimitedLength&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AllowUnlimitedLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.lookupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.lookupColumn", HelpMessage = @"The &quot;columnName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ColumnName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.lookupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.lookupColumn", HelpMessage = @"The &quot;listId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ListId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;primaryLookupColumnId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.lookupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.lookupColumn", HelpMessage = @"The &quot;primaryLookupColumnId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PrimaryLookupColumnId { get; set; }
    }
}