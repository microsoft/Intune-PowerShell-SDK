// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.resourceAction&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.resourceAction&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ResourceActionObject", DefaultParameterSetName = @"#microsoft.graph.resourceAction")]
    [ODataType("microsoft.graph.resourceAction")]
    public class New_ResourceActionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowedResourceActions&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceAction&quot; type.</para>
        ///     <para type="description">Allowed Actions</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.resourceAction", HelpMessage = @"The &quot;allowedResourceActions&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] allowedResourceActions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notAllowedResourceActions&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceAction&quot; type.</para>
        ///     <para type="description">Not Allowed Actions</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.resourceAction", HelpMessage = @"The &quot;notAllowedResourceActions&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] notAllowedResourceActions { get; set; }
    }
}