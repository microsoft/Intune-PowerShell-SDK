// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.rolePermission&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.rolePermission&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RolePermissionObject", DefaultParameterSetName = @"microsoft.graph.rolePermission")]
    [ODataType("microsoft.graph.rolePermission")]
    public class New_RolePermissionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;resourceActions&quot; property, of type &quot;microsoft.graph.resourceAction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.rolePermission&quot; type.</para>
        ///     <para type="description">Actions</para>
        /// </summary>
        [ODataType("microsoft.graph.resourceAction")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.rolePermission", HelpMessage = @"The &quot;resourceActions&quot; property, of type &quot;microsoft.graph.resourceAction&quot;.")]
        public System.Object[] resourceActions { get; set; }
    }
}