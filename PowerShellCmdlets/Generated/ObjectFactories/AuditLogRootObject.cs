// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.auditLogRoot&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.auditLogRoot&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AuditLogRootObject", DefaultParameterSetName = @"microsoft.graph.auditLogRoot")]
    [ODataType("microsoft.graph.auditLogRoot")]
    public class New_AuditLogRootObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;signIns&quot; property, of type &quot;microsoft.graph.signIn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.auditLogRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.signIn", "microsoft.graph.restrictedSignIn")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.auditLogRoot", HelpMessage = @"The &quot;signIns&quot; property, of type &quot;microsoft.graph.signIn&quot;.")]
        public System.Object[] signIns { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;directoryAudits&quot; property, of type &quot;microsoft.graph.directoryAudit&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.auditLogRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryAudit")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.auditLogRoot", HelpMessage = @"The &quot;directoryAudits&quot; property, of type &quot;microsoft.graph.directoryAudit&quot;.")]
        public System.Object[] directoryAudits { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;restrictedSignIns&quot; property, of type &quot;microsoft.graph.restrictedSignIn&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.auditLogRoot&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.restrictedSignIn")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.auditLogRoot", HelpMessage = @"The &quot;restrictedSignIns&quot; property, of type &quot;microsoft.graph.restrictedSignIn&quot;.")]
        public System.Object[] restrictedSignIns { get; set; }
    }
}