// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.controlScore&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.controlScore&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ControlScoreObject", DefaultParameterSetName = @"microsoft.graph.controlScore")]
    [ODataType("microsoft.graph.controlScore")]
    public class New_ControlScoreObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;controlCategory&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.controlScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.controlScore", HelpMessage = @"The &quot;controlCategory&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String controlCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;controlName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.controlScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.controlScore", HelpMessage = @"The &quot;controlName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String controlName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.controlScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.controlScore", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;score&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.controlScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.controlScore", HelpMessage = @"The &quot;score&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double score { get; set; }
    }
}