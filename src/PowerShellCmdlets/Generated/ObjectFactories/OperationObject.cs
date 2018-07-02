// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.operation&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.operation&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OperationObject", DefaultParameterSetName = @"#microsoft.graph.operation")]
    [ODataType("microsoft.graph.operation")]
    public class New_OperationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.operation&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.operation")]
        [Parameter(ParameterSetName = @"#microsoft.graph.operation", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.operation&quot; type.")]
        public System.Management.Automation.SwitchParameter operation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.operation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;NotStarted&apos;, &apos;Running&apos;, &apos;Completed&apos;, &apos;Failed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.operationStatus")]
        [Selectable]
        [ValidateSet(@"NotStarted", @"Running", @"Completed", @"Failed")]
        [Parameter(ParameterSetName = @"#microsoft.graph.operation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.operationStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.operation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.operation", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.operation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.operation", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActionDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.onenoteOperation")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.onenoteOperation&quot; type.")]
        public System.Management.Automation.SwitchParameter onenoteOperation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;resourceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperationError")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.onenoteOperationError&quot;.")]
        public System.Object error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteOperation", HelpMessage = @"The &quot;percentComplete&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String percentComplete { get; set; }
    }
}