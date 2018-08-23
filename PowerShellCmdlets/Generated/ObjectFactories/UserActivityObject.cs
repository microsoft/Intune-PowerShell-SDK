// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.userActivity&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.userActivity&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "UserActivityObject", DefaultParameterSetName = @"microsoft.graph.userActivity")]
    [ODataType("microsoft.graph.userActivity")]
    public class New_UserActivityObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.")]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object contentInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;active&apos;, &apos;updated&apos;, &apos;deleted&apos;, &apos;ignored&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [ValidateSet(@"active", @"updated", @"deleted", @"ignored", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.userActivity", HelpMessage = @"The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.")]
        public System.Object[] historyItems { get; set; }
    }
}