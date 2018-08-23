// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.siteCollection&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.siteCollection&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SiteCollectionObject", DefaultParameterSetName = @"microsoft.graph.siteCollection")]
    [ODataType("microsoft.graph.siteCollection")]
    public class New_SiteCollectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;hostname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.siteCollection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.siteCollection", HelpMessage = @"The &quot;hostname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String hostname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.siteCollection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.root")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.siteCollection", HelpMessage = @"The &quot;root&quot; property, of type &quot;microsoft.graph.root&quot;.")]
        public System.Object root { get; set; }
    }
}