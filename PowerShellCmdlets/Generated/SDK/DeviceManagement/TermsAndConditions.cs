// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.termsAndConditions&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/termsAndConditions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.termsAndConditions&quot; objects in the &quot;termsAndConditions&quot; collection.</para>
    ///     <para type="description">The terms and conditions associated with device management of the company.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_TermsAndConditions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.termsAndConditions")]
    [ResourceTypePropertyName("termsAndConditionODataType")]
    [ResourceIdPropertyName("termsAndConditionId")]
    [ResourceReference]
    public class Get_DeviceManagement_TermsAndConditions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied name for the T&amp;C policy. </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied description of the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String bodyText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String acceptanceStatement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] acceptanceStatuses { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.termsAndConditions&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/termsAndConditions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.termsAndConditions&quot; object to the &quot;termsAndConditions&quot; collection.</para>
    ///     <para type="description">The terms and conditions associated with device management of the company.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_TermsAndConditions", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.termsAndConditions")]
    [ODataType("microsoft.graph.termsAndConditions")]
    [ResourceTypePropertyName("termsAndConditionODataType")]
    [ResourceIdPropertyName("termsAndConditionId")]
    [ResourceReference]
    public class New_DeviceManagement_TermsAndConditions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied name for the T&amp;C policy. </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied description of the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bodyText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String acceptanceStatement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.")]
        public System.Object[] acceptanceStatuses { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.termsAndConditions&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/termsAndConditions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
    ///     <para type="description">The terms and conditions associated with device management of the company.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_TermsAndConditions", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.termsAndConditions")]
    [ODataType("microsoft.graph.termsAndConditions")]
    [ResourceTypePropertyName("termsAndConditionODataType")]
    [ResourceIdPropertyName("termsAndConditionId")]
    public class Update_DeviceManagement_TermsAndConditions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied name for the T&amp;C policy. </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied description of the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bodyText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String acceptanceStatement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.")]
        public System.Object[] acceptanceStatuses { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.termsAndConditions&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/termsAndConditions/termsAndConditionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.termsAndConditions&quot; object from the &quot;termsAndConditions&quot; collection.</para>
    ///     <para type="description">The terms and conditions associated with device management of the company.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_TermsAndConditions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.termsAndConditions")]
    [ResourceTypePropertyName("termsAndConditionODataType")]
    [ResourceIdPropertyName("termsAndConditionId")]
    public class Remove_DeviceManagement_TermsAndConditions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.termsAndConditions&quot; object in the &quot;termsAndConditions&quot; collection.")]
        public System.String termsAndConditionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/termsAndConditions/{termsAndConditionId}";
        }
    }
}