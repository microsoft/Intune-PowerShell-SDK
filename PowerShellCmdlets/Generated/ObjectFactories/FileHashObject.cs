// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.fileHash&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.fileHash&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "FileHashObject", DefaultParameterSetName = @"microsoft.graph.fileHash")]
    [ODataType("microsoft.graph.fileHash")]
    public class New_FileHashObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;hashType&quot; property, of type &quot;microsoft.graph.fileHashType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileHash&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;sha1&apos;, &apos;sha256&apos;, &apos;md5&apos;, &apos;authenticodeHash256&apos;, &apos;lsHash&apos;, &apos;ctph&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.fileHashType")]
        [Selectable]
        [ValidateSet(@"unknown", @"sha1", @"sha256", @"md5", @"authenticodeHash256", @"lsHash", @"ctph", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.fileHash", HelpMessage = @"The &quot;hashType&quot; property, of type &quot;microsoft.graph.fileHashType&quot;.")]
        public System.String hashType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hashValue&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileHash&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.fileHash", HelpMessage = @"The &quot;hashValue&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String hashValue { get; set; }
    }
}