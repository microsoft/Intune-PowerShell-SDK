// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.bitLockerRemovableDrivePolicy&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.bitLockerRemovableDrivePolicy&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "BitLockerRemovableDrivePolicyObject", DefaultParameterSetName = @"microsoft.graph.bitLockerRemovableDrivePolicy")]
    [ODataType("microsoft.graph.bitLockerRemovableDrivePolicy")]
    public class New_BitLockerRemovableDrivePolicyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;encryptionMethod&quot; property, of type &quot;microsoft.graph.bitLockerEncryptionMethod&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.bitLockerRemovableDrivePolicy&quot; type.</para>
        ///     <para type="description">Select the encryption method for removable  drives.</para>
        ///     <para type="description">
        ///          Valid values: &apos;aesCbc128&apos;, &apos;aesCbc256&apos;, &apos;xtsAes128&apos;, &apos;xtsAes256&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.bitLockerEncryptionMethod")]
        [Selectable]
        [ValidateSet(@"aesCbc128", @"aesCbc256", @"xtsAes128", @"xtsAes256")]
        [Parameter(ParameterSetName = @"microsoft.graph.bitLockerRemovableDrivePolicy", HelpMessage = @"The &quot;encryptionMethod&quot; property, of type &quot;microsoft.graph.bitLockerEncryptionMethod&quot;.")]
        public System.String encryptionMethod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;requireEncryptionForWriteAccess&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.bitLockerRemovableDrivePolicy&quot; type.</para>
        ///     <para type="description">Indicates whether to block write access to devices configured in another organization.  If requireEncryptionForWriteAccess is false, this value does not affect.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.bitLockerRemovableDrivePolicy", HelpMessage = @"The &quot;requireEncryptionForWriteAccess&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean requireEncryptionForWriteAccess { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;blockCrossOrganizationWriteAccess&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.bitLockerRemovableDrivePolicy&quot; type.</para>
        ///     <para type="description">This policy setting determines whether BitLocker protection is required for removable data drives to be writable on a computer.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.bitLockerRemovableDrivePolicy", HelpMessage = @"The &quot;blockCrossOrganizationWriteAccess&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean blockCrossOrganizationWriteAccess { get; set; }
    }
}