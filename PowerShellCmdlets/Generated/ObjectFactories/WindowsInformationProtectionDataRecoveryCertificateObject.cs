// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionDataRecoveryCertificateObject", DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
    [ODataType("microsoft.graph.windowsInformationProtectionDataRecoveryCertificate")]
    public class New_WindowsInformationProtectionDataRecoveryCertificateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;subjectName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; type.</para>
        ///     <para type="description">Data recovery Certificate subject name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionDataRecoveryCertificate", HelpMessage = @"The &quot;subjectName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subjectName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; type.</para>
        ///     <para type="description">Data recovery Certificate description</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionDataRecoveryCertificate", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; type.</para>
        ///     <para type="description">Data recovery Certificate expiration datetime</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionDataRecoveryCertificate", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificate&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDataRecoveryCertificate&quot; type.</para>
        ///     <para type="description">Data recovery Certificate</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionDataRecoveryCertificate", HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] certificate { get; set; }
    }
}