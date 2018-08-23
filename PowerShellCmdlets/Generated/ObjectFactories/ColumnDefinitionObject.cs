// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.columnDefinition&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.columnDefinition&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ColumnDefinitionObject", DefaultParameterSetName = @"microsoft.graph.columnDefinition")]
    [ODataType("microsoft.graph.columnDefinition")]
    public class New_ColumnDefinitionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;boolean&quot; property, of type &quot;microsoft.graph.booleanColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.booleanColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;boolean&quot; property, of type &quot;microsoft.graph.booleanColumn&quot;.")]
        public System.Object boolean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calculated&quot; property, of type &quot;microsoft.graph.calculatedColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calculatedColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;calculated&quot; property, of type &quot;microsoft.graph.calculatedColumn&quot;.")]
        public System.Object calculated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;choice&quot; property, of type &quot;microsoft.graph.choiceColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.choiceColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;choice&quot; property, of type &quot;microsoft.graph.choiceColumn&quot;.")]
        public System.Object choice { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;columnGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;columnGroup&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String columnGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;currency&quot; property, of type &quot;microsoft.graph.currencyColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.currencyColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;currency&quot; property, of type &quot;microsoft.graph.currencyColumn&quot;.")]
        public System.Object currency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dateTime&quot; property, of type &quot;microsoft.graph.dateTimeColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;dateTime&quot; property, of type &quot;microsoft.graph.dateTimeColumn&quot;.")]
        public System.Object dateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultValue&quot; property, of type &quot;microsoft.graph.defaultColumnValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.defaultColumnValue")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;defaultValue&quot; property, of type &quot;microsoft.graph.defaultColumnValue&quot;.")]
        public System.Object defaultValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforceUniqueValues&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;enforceUniqueValues&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enforceUniqueValues { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;hidden&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hidden { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;indexed&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;indexed&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean indexed { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lookup&quot; property, of type &quot;microsoft.graph.lookupColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.lookupColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;lookup&quot; property, of type &quot;microsoft.graph.lookupColumn&quot;.")]
        public System.Object lookup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number&quot; property, of type &quot;microsoft.graph.numberColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.numberColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;number&quot; property, of type &quot;microsoft.graph.numberColumn&quot;.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personOrGroup&quot; property, of type &quot;microsoft.graph.personOrGroupColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.personOrGroupColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;personOrGroup&quot; property, of type &quot;microsoft.graph.personOrGroupColumn&quot;.")]
        public System.Object personOrGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;readOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean readOnly { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;required&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;required&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean required { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text&quot; property, of type &quot;microsoft.graph.textColumn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.columnDefinition&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.textColumn")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.columnDefinition", HelpMessage = @"The &quot;text&quot; property, of type &quot;microsoft.graph.textColumn&quot;.")]
        public System.Object text { get; set; }
    }
}