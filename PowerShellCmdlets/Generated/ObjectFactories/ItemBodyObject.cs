// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemBody&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemBody&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemBodyObject", DefaultParameterSetName = @"#microsoft.graph.itemBody")]
    [ODataType("microsoft.graph.itemBody")]
    public class New_ItemBodyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;microsoft.graph.bodyType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemBody&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;text&apos;, &apos;html&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.bodyType")]
        [Selectable]
        [ValidateSet(@"text", @"html")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemBody", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;microsoft.graph.bodyType&quot;.")]
        public System.String contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemBody&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemBody", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String content { get; set; }
    }
}