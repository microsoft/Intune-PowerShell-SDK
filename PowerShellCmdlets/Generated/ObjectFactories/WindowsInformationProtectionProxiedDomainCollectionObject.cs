// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionProxiedDomainCollectionObject", DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
    [ODataType("microsoft.graph.windowsInformationProtectionProxiedDomainCollection")]
    public class New_WindowsInformationProtectionProxiedDomainCollectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot; type.</para>
        ///     <para type="description">Display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionProxiedDomainCollection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxiedDomains&quot; property, of type &quot;microsoft.graph.proxiedDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionProxiedDomainCollection&quot; type.</para>
        ///     <para type="description">Collection of proxied domains</para>
        /// </summary>
        [ODataType("microsoft.graph.proxiedDomain")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionProxiedDomainCollection", HelpMessage = @"The &quot;proxiedDomains&quot; property, of type &quot;microsoft.graph.proxiedDomain&quot;.")]
        public System.Object[] proxiedDomains { get; set; }
    }
}