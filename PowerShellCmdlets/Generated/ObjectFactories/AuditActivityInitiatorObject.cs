// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.auditActivityInitiator&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.auditActivityInitiator&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AuditActivityInitiatorObject", DefaultParameterSetName = @"microsoft.graph.auditActivityInitiator")]
    [ODataType("microsoft.graph.auditActivityInitiator")]
    public class New_AuditActivityInitiatorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;user&quot; property, of type &quot;microsoft.graph.userIdentity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.auditActivityInitiator&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userIdentity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.auditActivityInitiator", HelpMessage = @"The &quot;user&quot; property, of type &quot;microsoft.graph.userIdentity&quot;.")]
        public System.Object user { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;app&quot; property, of type &quot;microsoft.graph.appIdentity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.auditActivityInitiator&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.appIdentity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.auditActivityInitiator", HelpMessage = @"The &quot;app&quot; property, of type &quot;microsoft.graph.appIdentity&quot;.")]
        public System.Object app { get; set; }
    }
}