// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.keyValuePair&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.keyValuePair&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "KeyValuePairObject", DefaultParameterSetName = @"microsoft.graph.keyValuePair")]
    [ODataType("microsoft.graph.keyValuePair")]
    public class New_KeyValuePairObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.keyValuePair&quot; type.</para>
        ///     <para type="description">Name for this key-value pair</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.keyValuePair", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.keyValuePair&quot; type.</para>
        ///     <para type="description">Value for this key-value pair</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.keyValuePair", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }
    }
}