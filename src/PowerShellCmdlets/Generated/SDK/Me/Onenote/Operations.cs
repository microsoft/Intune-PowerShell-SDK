// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.onenoteOperation&quot; objects.</para>
    ///     <para type="description">GET ~/me/onenote/operations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.onenoteOperation&quot; objects in the &quot;operations&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_Operations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.onenoteOperation")]
    [ResourceIdPropertyName("operationId")]
    [ResourceReference]
    public class Get_Me_Onenote_Operations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String operationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String resourceLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperationError")]
        [Selectable]
        [Sortable]
        public System.Object error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String percentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.operationStatus")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastActionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/operations/{operationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/operations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.onenoteOperation&quot; object to the &quot;operations&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_Operations", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.onenoteOperation")]
    [ODataType("microsoft.graph.onenoteOperation")]
    [ResourceReference]
    public class New_Me_Onenote_Operations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperationError")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.")]
        public System.Object error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String percentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;NotStarted&apos;, &apos;Running&apos;, &apos;Completed&apos;, &apos;Failed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.operationStatus")]
        [Selectable]
        [ValidateSet(@"NotStarted", @"Running", @"Completed", @"Failed")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/operations";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onenoteOperation&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/operations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_Operations", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.onenoteOperation")]
    [ODataType("microsoft.graph.onenoteOperation")]
    [ResourceIdPropertyName("operationId")]
    public class Update_Me_Onenote_Operations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String operationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperationError")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.")]
        public System.Object error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String percentComplete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;NotStarted&apos;, &apos;Running&apos;, &apos;Completed&apos;, &apos;Failed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.operationStatus")]
        [Selectable]
        [ValidateSet(@"NotStarted", @"Running", @"Completed", @"Failed")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/operations/{operationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/operations/operationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.onenoteOperation&quot; object from the &quot;operations&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_Operations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteOperation")]
    [ResourceIdPropertyName("operationId")]
    public class Remove_Me_Onenote_Operations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String operationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/operations/{operationId}";
        }
    }
}