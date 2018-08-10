// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.numberColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.numberColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "NumberColumnObject", DefaultParameterSetName = @"#microsoft.graph.numberColumn")]
    [ODataType("microsoft.graph.numberColumn")]
    public class New_NumberColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;decimalPlaces&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.numberColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.numberColumn", HelpMessage = @"The &quot;decimalPlaces&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String decimalPlaces { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.numberColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.numberColumn", HelpMessage = @"The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maximum&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.numberColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.numberColumn", HelpMessage = @"The &quot;maximum&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double maximum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimum&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.numberColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.numberColumn", HelpMessage = @"The &quot;minimum&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double minimum { get; set; }
    }
}