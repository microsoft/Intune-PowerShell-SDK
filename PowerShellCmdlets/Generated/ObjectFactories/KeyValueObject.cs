// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.keyValue&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.keyValue&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "KeyValueObject", DefaultParameterSetName = @"microsoft.graph.keyValue")]
    [ODataType("microsoft.graph.keyValue")]
    public class New_KeyValueObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;key&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.keyValue&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.keyValue", HelpMessage = @"The &quot;key&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String key { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.keyValue&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.keyValue", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }
    }
}