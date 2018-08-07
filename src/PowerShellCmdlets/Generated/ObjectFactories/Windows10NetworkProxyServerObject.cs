// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windows10NetworkProxyServer&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windows10NetworkProxyServer&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "Windows10NetworkProxyServerObject", DefaultParameterSetName = @"#microsoft.graph.windows10NetworkProxyServer")]
    [ODataType("microsoft.graph.windows10NetworkProxyServer")]
    public class New_Windows10NetworkProxyServerObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10NetworkProxyServer&quot; type.</para>
        ///     <para type="description">Address to the proxy server. Specify an address in the format &lt;server&gt;[“:”&lt;port&gt;]</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windows10NetworkProxyServer", HelpMessage = @"The &quot;address&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exceptions&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10NetworkProxyServer&quot; type.</para>
        ///     <para type="description">Addresses that should not use the proxy server. The system will not use the proxy server for addresses beginning with what is specified in this node.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.windows10NetworkProxyServer", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] exceptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;useForLocalAddresses&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windows10NetworkProxyServer&quot; type.</para>
        ///     <para type="description">Specifies whether the proxy server should be used for local (intranet) addresses.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windows10NetworkProxyServer", HelpMessage = @"The &quot;useForLocalAddresses&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean useForLocalAddresses { get; set; }
    }
}