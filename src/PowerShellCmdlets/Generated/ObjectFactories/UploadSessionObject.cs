// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.uploadSession&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.uploadSession&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "UploadSessionObject", DefaultParameterSetName = @"#microsoft.graph.uploadSession")]
    [ODataType("microsoft.graph.uploadSession")]
    public class New_UploadSessionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.uploadSession&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.uploadSession", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nextExpectedRanges&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.uploadSession&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.uploadSession", HelpMessage = @"The &quot;nextExpectedRanges&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] NextExpectedRanges { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uploadUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.uploadSession&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.uploadSession", HelpMessage = @"The &quot;uploadUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UploadUrl { get; set; }
    }
}