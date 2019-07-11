// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.teamsAsyncOperation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.teamsAsyncOperation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TeamsAsyncOperationObject", DefaultParameterSetName = @"microsoft.graph.teamsAsyncOperation")]
    [ODataType("microsoft.graph.teamsAsyncOperation")]
    public class New_TeamsAsyncOperationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;operationType&quot; property, of type &quot;microsoft.graph.teamsAsyncOperationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;invalid&apos;, &apos;cloneTeam&apos;, &apos;archiveTeam&apos;, &apos;unarchiveTeam&apos;, &apos;createTeam&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAsyncOperationType")]
        [Selectable]
        [ValidateSet(@"invalid", @"cloneTeam", @"archiveTeam", @"unarchiveTeam", @"createTeam", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;operationType&quot; property, of type &quot;microsoft.graph.teamsAsyncOperationType&quot;.")]
        public System.String operationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.teamsAsyncOperationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;invalid&apos;, &apos;notStarted&apos;, &apos;inProgress&apos;, &apos;succeeded&apos;, &apos;failed&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.teamsAsyncOperationStatus")]
        [Selectable]
        [ValidateSet(@"invalid", @"notStarted", @"inProgress", @"succeeded", @"failed", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.teamsAsyncOperationStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActionDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;attemptsCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;attemptsCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 attemptsCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetResourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;targetResourceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String targetResourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetResourceLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;targetResourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String targetResourceLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.operationError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.teamsAsyncOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.operationError")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.teamsAsyncOperation", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.operationError&quot;.")]
        public System.Object error { get; set; }
    }
}