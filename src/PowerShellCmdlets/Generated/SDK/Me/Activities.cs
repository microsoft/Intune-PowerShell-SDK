// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.userActivity&quot; objects.</para>
    ///     <para type="description">GET ~/me/activities</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.userActivity&quot; objects in the &quot;activities&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Activities", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.userActivity")]
    [ResourceIdPropertyName("activityId")]
    [ResourceReference]
    public class Get_Me_Activities : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Sortable]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        public System.Object contentInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.status")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [Expandable]
        public System.Object[] historyItems { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.userActivity&quot; object.</para>
    ///     <para type="description">POST ~/me/activities</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.userActivity&quot; object to the &quot;activities&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Activities", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.userActivity")]
    [ODataType("microsoft.graph.userActivity")]
    [ResourceReference]
    public class New_Me_Activities : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.")]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
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
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.")]
        public System.Object[] historyItems { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.userActivity&quot;.</para>
    ///     <para type="description">PATCH ~/me/activities</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Activities", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.userActivity")]
    [ODataType("microsoft.graph.userActivity")]
    [ResourceIdPropertyName("activityId")]
    public class Update_Me_Activities : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.visualInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visualElements&quot; property, of type &quot;microsoft.graph.visualInfo&quot;.")]
        public System.Object visualElements { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activitySourceHost&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activitySourceHost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;activationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String activationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appActivityId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appActivityId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fallbackUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fallbackUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userTimezone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userTimezone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentInfo&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
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
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.status&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.activityHistoryItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.userActivity", HelpMessage = @"The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;historyItems&quot; property, of type &quot;microsoft.graph.activityHistoryItem&quot;.")]
        public System.Object[] historyItems { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.userActivity&quot; object.</para>
    ///     <para type="description">DELETE ~/me/activities/activityId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.userActivity&quot; object from the &quot;activities&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Activities", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.userActivity")]
    [ResourceIdPropertyName("activityId")]
    public class Remove_Me_Activities : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.userActivity&quot; object in the &quot;activities&quot; collection.")]
        public System.String activityId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/activities/{activityId}";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/activities/recent</para>
    ///     <para type="description">The function &quot;microsoft.graph.recent&quot;, which exists on the type &quot;microsoft.graph.userActivity&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.userActivity&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Activities_Recent", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.userActivity")]
    public class Invoke_Me_Activities_Recent : FunctionReturningCollectionCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/activities/recent({this.GetFunctionUrlSegment()})";
        }
    }
}