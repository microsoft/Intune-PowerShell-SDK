// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mimeContent&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mimeContent&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MimeContentObject", DefaultParameterSetName = @"#microsoft.graph.mimeContent")]
    [ODataType("microsoft.graph.mimeContent")]
    public class New_MimeContentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mimeContent&quot; type.</para>
        ///     <para type="description">Indicates the content mime type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mimeContent", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mimeContent&quot; type.</para>
        ///     <para type="description">The byte array that contains the actual content.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mimeContent", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] Value { get; set; }
    }
}