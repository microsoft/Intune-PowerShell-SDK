// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookCommentReply&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookCommentReply&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookCommentReplyObject", DefaultParameterSetName = @"microsoft.graph.workbookCommentReply")]
    [ODataType("microsoft.graph.workbookCommentReply")]
    public class New_WorkbookCommentReplyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookCommentReply&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookCommentReply", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookCommentReply&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookCommentReply", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentType { get; set; }
    }
}