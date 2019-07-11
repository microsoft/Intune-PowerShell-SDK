// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.appIdentity&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.appIdentity&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AppIdentityObject", DefaultParameterSetName = @"microsoft.graph.appIdentity")]
    [ODataType("microsoft.graph.appIdentity")]
    public class New_AppIdentityObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;appId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appIdentity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appIdentity", HelpMessage = @"The &quot;appId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appIdentity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appIdentity", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePrincipalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appIdentity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appIdentity", HelpMessage = @"The &quot;servicePrincipalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String servicePrincipalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appIdentity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appIdentity", HelpMessage = @"The &quot;servicePrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String servicePrincipalName { get; set; }
    }
}