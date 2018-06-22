// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.hashes&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.hashes&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "HashesObject", DefaultParameterSetName = @"#microsoft.graph.hashes")]
    [ODataType("microsoft.graph.hashes")]
    public class New_HashesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;crc32Hash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hashes&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.hashes", HelpMessage = @"The &quot;crc32Hash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String crc32Hash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quickXorHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hashes&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.hashes", HelpMessage = @"The &quot;quickXorHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String quickXorHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sha1Hash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.hashes&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.hashes", HelpMessage = @"The &quot;sha1Hash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sha1Hash { get; set; }
    }
}