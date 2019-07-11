// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.dataPolicyOperation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.dataPolicyOperation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DataPolicyOperationObject", DefaultParameterSetName = @"microsoft.graph.dataPolicyOperation")]
    [ODataType("microsoft.graph.dataPolicyOperation")]
    public class New_DataPolicyOperationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;completedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset completedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.dataPolicyOperationStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notStarted&apos;, &apos;running&apos;, &apos;complete&apos;, &apos;failed&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.dataPolicyOperationStatus")]
        [Selectable]
        [ValidateSet(@"notStarted", @"running", @"complete", @"failed", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.dataPolicyOperationStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;storageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;storageLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String storageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;submittedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;submittedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset submittedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;progress&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dataPolicyOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.dataPolicyOperation", HelpMessage = @"The &quot;progress&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double progress { get; set; }
    }
}