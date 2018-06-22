// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.choiceColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.choiceColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ChoiceColumnObject", DefaultParameterSetName = @"#microsoft.graph.choiceColumn")]
    [ODataType("microsoft.graph.choiceColumn")]
    public class New_ChoiceColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowTextEntry&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.choiceColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.choiceColumn", HelpMessage = @"The &quot;allowTextEntry&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowTextEntry { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;choices&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.choiceColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.choiceColumn", HelpMessage = @"The &quot;choices&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] choices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.choiceColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.choiceColumn", HelpMessage = @"The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayAs { get; set; }
    }
}