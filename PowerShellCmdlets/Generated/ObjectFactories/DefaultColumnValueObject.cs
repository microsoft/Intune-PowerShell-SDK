// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.defaultColumnValue&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.defaultColumnValue&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DefaultColumnValueObject", DefaultParameterSetName = @"microsoft.graph.defaultColumnValue")]
    [ODataType("microsoft.graph.defaultColumnValue")]
    public class New_DefaultColumnValueObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;formula&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultColumnValue&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.defaultColumnValue", HelpMessage = @"The &quot;formula&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String formula { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.defaultColumnValue&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.defaultColumnValue", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }
    }
}