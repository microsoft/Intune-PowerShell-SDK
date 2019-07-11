// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.alertHistoryState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.alertHistoryState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AlertHistoryStateObject", DefaultParameterSetName = @"microsoft.graph.alertHistoryState")]
    [ODataType("microsoft.graph.alertHistoryState")]
    public class New_AlertHistoryStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;appId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;appId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String assignedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comments&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;comments&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] comments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;feedback&quot; property, of type &quot;microsoft.graph.alertFeedback&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;truePositive&apos;, &apos;falsePositive&apos;, &apos;benignPositive&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.alertFeedback")]
        [Selectable]
        [ValidateSet(@"unknown", @"truePositive", @"falsePositive", @"benignPositive", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;feedback&quot; property, of type &quot;microsoft.graph.alertFeedback&quot;.")]
        public System.String feedback { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.alertStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;newAlert&apos;, &apos;inProgress&apos;, &apos;resolved&apos;, &apos;dismissed&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.alertStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"newAlert", @"inProgress", @"resolved", @"dismissed", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.alertStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;updatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;updatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset updatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;user&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alertHistoryState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alertHistoryState", HelpMessage = @"The &quot;user&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String user { get; set; }
    }
}