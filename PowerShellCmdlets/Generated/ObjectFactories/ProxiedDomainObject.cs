// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.proxiedDomain&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.proxiedDomain&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ProxiedDomainObject", DefaultParameterSetName = @"microsoft.graph.proxiedDomain")]
    [ODataType("microsoft.graph.proxiedDomain")]
    public class New_ProxiedDomainObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;ipAddressOrFQDN&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.proxiedDomain&quot; type.</para>
        ///     <para type="description">The IP address or FQDN</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.proxiedDomain", HelpMessage = @"The &quot;ipAddressOrFQDN&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ipAddressOrFQDN { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.proxiedDomain&quot; type.</para>
        ///     <para type="description">Proxy IP</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.proxiedDomain", HelpMessage = @"The &quot;proxy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String proxy { get; set; }
    }
}