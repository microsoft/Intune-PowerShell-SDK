// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.fileEncryptionInfo&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.fileEncryptionInfo&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "FileEncryptionInfoObject", DefaultParameterSetName = @"#microsoft.graph.fileEncryptionInfo")]
    [ODataType("microsoft.graph.fileEncryptionInfo")]
    public class New_FileEncryptionInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;encryptionKey&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The key used to encrypt the file content.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;encryptionKey&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] encryptionKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;initializationVector&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The initialization vector used for the encryption algorithm.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;initializationVector&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] initializationVector { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mac&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The hash of the encrypted file content + IV (content hash).</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;mac&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] mac { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macKey&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The key used to get mac.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;macKey&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] macKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;profileIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The the profile identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;profileIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String profileIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileDigest&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The file digest prior to encryption.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;fileDigest&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] fileDigest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileDigestAlgorithm&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileEncryptionInfo&quot; type.</para>
        ///     <para type="description">The file digest algorithm.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileEncryptionInfo", HelpMessage = @"The &quot;fileDigestAlgorithm&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileDigestAlgorithm { get; set; }
    }
}