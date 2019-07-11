// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.directoryAudit&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.directoryAudit&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DirectoryAuditObject", DefaultParameterSetName = @"microsoft.graph.directoryAudit")]
    [ODataType("microsoft.graph.directoryAudit")]
    public class New_DirectoryAuditObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;category&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;category&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;result&quot; property, of type &quot;microsoft.graph.operationResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;failure&apos;, &apos;timeout&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.operationResult")]
        [Selectable]
        [ValidateSet(@"success", @"failure", @"timeout", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;result&quot; property, of type &quot;microsoft.graph.operationResult&quot;.")]
        public System.String result { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resultReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;resultReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resultReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activityDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;activityDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activityDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activityDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;activityDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset activityDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;loggedByService&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;loggedByService&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String loggedByService { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operationType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;operationType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;initiatedBy&quot; property, of type &quot;microsoft.graph.auditActivityInitiator&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.auditActivityInitiator")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;initiatedBy&quot; property, of type &quot;microsoft.graph.auditActivityInitiator&quot;.")]
        public System.Object initiatedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetResources&quot; property, of type &quot;microsoft.graph.targetResource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.targetResource")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;targetResources&quot; property, of type &quot;microsoft.graph.targetResource&quot;.")]
        public System.Object[] targetResources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;additionalDetails&quot; property, of type &quot;microsoft.graph.keyValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryAudit&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.keyValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.directoryAudit", HelpMessage = @"The &quot;additionalDetails&quot; property, of type &quot;microsoft.graph.keyValue&quot;.")]
        public System.Object[] additionalDetails { get; set; }
    }
}