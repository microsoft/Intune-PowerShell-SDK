// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.schemaExtension&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.schemaExtension&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SchemaExtensionObject", DefaultParameterSetName = @"#microsoft.graph.schemaExtension")]
    [ODataType("microsoft.graph.schemaExtension")]
    public class New_SchemaExtensionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.schemaExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.schemaExtension", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.schemaExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.schemaExtension", HelpMessage = @"The &quot;targetTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] TargetTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;properties&quot; property, of type &quot;microsoft.graph.extensionSchemaProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.schemaExtension&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extensionSchemaProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.schemaExtension", HelpMessage = @"The &quot;properties&quot; property, of type &quot;microsoft.graph.extensionSchemaProperty&quot;.")]
        public System.Object[] Properties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.schemaExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.schemaExtension", HelpMessage = @"The &quot;status&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.schemaExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.schemaExtension", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Owner { get; set; }
    }
}