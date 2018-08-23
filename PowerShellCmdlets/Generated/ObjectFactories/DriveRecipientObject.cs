// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.driveRecipient&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.driveRecipient&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DriveRecipientObject", DefaultParameterSetName = @"microsoft.graph.driveRecipient")]
    [ODataType("microsoft.graph.driveRecipient")]
    public class New_DriveRecipientObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;alias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveRecipient&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.driveRecipient", HelpMessage = @"The &quot;alias&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String alias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;email&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveRecipient&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.driveRecipient", HelpMessage = @"The &quot;email&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String email { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;objectId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveRecipient&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.driveRecipient", HelpMessage = @"The &quot;objectId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String objectId { get; set; }
    }
}