// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.calculatedColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.calculatedColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "CalculatedColumnObject", DefaultParameterSetName = @"#microsoft.graph.calculatedColumn")]
    [ODataType("microsoft.graph.calculatedColumn")]
    public class New_CalculatedColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;format&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calculatedColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calculatedColumn", HelpMessage = @"The &quot;format&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Format { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formula&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calculatedColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calculatedColumn", HelpMessage = @"The &quot;formula&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Formula { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outputType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.calculatedColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.calculatedColumn", HelpMessage = @"The &quot;outputType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OutputType { get; set; }
    }
}