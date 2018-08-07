// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; objects in the &quot;acceptanceStatuses&quot; collection.</para>
    ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_TermsAndConditions_AcceptanceStatuses", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ResourceIdPropertyName("acceptanceStatusId")]
    [ResourceReference]
    public class Get_DeviceManagement_TermsAndConditions_AcceptanceStatuses : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.")]
        public System.String acceptanceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Display name of the user whose acceptance the entity represents.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Most recent version number of the T&amp;C accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 acceptedVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">DateTime when the terms were last accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset acceptedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Navigation link to the terms and conditions that are assigned.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object termsAndConditions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses/{acceptanceStatusId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object to the &quot;acceptanceStatuses&quot; collection.</para>
    ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_TermsAndConditions_AcceptanceStatuses", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ResourceReference]
    public class New_DeviceManagement_TermsAndConditions_AcceptanceStatuses : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Display name of the user whose acceptance the entity represents.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Most recent version number of the T&amp;C accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 acceptedVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">DateTime when the terms were last accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset acceptedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Navigation link to the terms and conditions that are assigned.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        public System.Object termsAndConditions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.</para>
    ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_TermsAndConditions_AcceptanceStatuses", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ResourceIdPropertyName("acceptanceStatusId")]
    public class Update_DeviceManagement_TermsAndConditions_AcceptanceStatuses : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.")]
        public System.String acceptanceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Display name of the user whose acceptance the entity represents.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Most recent version number of the T&amp;C accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 acceptedVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">DateTime when the terms were last accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset acceptedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Navigation link to the terms and conditions that are assigned.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        public System.Object termsAndConditions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses/{acceptanceStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses/acceptanceStatusId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object from the &quot;acceptanceStatuses&quot; collection.</para>
    ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_TermsAndConditions_AcceptanceStatuses", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ResourceIdPropertyName("acceptanceStatusId")]
    public class Remove_DeviceManagement_TermsAndConditions_AcceptanceStatuses : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; object in the &quot;acceptanceStatuses&quot; collection.")]
        public System.String acceptanceStatusId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}/acceptanceStatuses/{acceptanceStatusId}";
        }
    }
}