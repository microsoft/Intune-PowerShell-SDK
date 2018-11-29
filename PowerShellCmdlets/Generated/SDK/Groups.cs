// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.group&quot; objects.</para>
    ///     <para type="description">GET ~/groups</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.group&quot; objects in the &quot;groups&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "Groups", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Get_Groups : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onPremisesProvisioningError")]
        [Selectable]
        public System.Object[] onPremisesProvisioningErrors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [Expandable]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [Expandable]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset deletedDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.group&quot; object.</para>
    ///     <para type="description">POST ~/groups</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.group&quot; object to the &quot;groups&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "Groups", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.group")]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class New_Groups : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onPremisesProvisioningError")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.")]
        public System.Object[] onPremisesProvisioningErrors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset deletedDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">PATCH ~/groups</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "Groups", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.group")]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Update_Groups : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onPremisesProvisioningError")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onPremisesProvisioningErrors&quot; property, of type &quot;microsoft.graph.onPremisesProvisioningError&quot;.")]
        public System.Object[] onPremisesProvisioningErrors { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject", "microsoft.graph.administrativeUnit", "microsoft.graph.groupSettingTemplate", "microsoft.graph.user", "microsoft.graph.organization", "microsoft.graph.contract", "microsoft.graph.group", "microsoft.graph.directoryRoleTemplate", "microsoft.graph.directoryRole", "microsoft.graph.device")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.group", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset deletedDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.group&quot; object.</para>
    ///     <para type="description">DELETE ~/groups/groupId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.group&quot; object from the &quot;groups&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "Groups", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Remove_Groups : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/subscribeByMail</para>
    ///     <para type="description">The action &quot;microsoft.graph.subscribeByMail&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupSubscribeByMail", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupSubscribeByMail : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/subscribeByMail";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/unsubscribeByMail</para>
    ///     <para type="description">The action &quot;microsoft.graph.unsubscribeByMail&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupUnsubscribeByMail", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupUnsubscribeByMail : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/unsubscribeByMail";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/addFavorite</para>
    ///     <para type="description">The action &quot;microsoft.graph.addFavorite&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupAddFavorite", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupAddFavorite : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/addFavorite";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/removeFavorite</para>
    ///     <para type="description">The action &quot;microsoft.graph.removeFavorite&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupRemoveFavorite", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupRemoveFavorite : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/removeFavorite";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/resetUnseenCount</para>
    ///     <para type="description">The action &quot;microsoft.graph.resetUnseenCount&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupResetUnseenCount", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupResetUnseenCount : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/resetUnseenCount";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/renew</para>
    ///     <para type="description">The action &quot;microsoft.graph.renew&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupRenew", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupRenew : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/renew";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/groups/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.group&quot; objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupDelta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupDelta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/delta({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/getByIds</para>
    ///     <para type="description">The action &quot;microsoft.graph.getByIds&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;microsoft.graph.directoryObject&quot; objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupGetByIds", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupGetByIds : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;ids&quot; action parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Expandable]
        [ValidateNotNull]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;ids&quot; action parameter of type &quot;Edm.String&quot;.")]
        public System.String[] ids { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;types&quot; action parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;types&quot; action parameter of type &quot;Edm.String&quot;.")]
        public System.String[] types { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/getByIds";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/checkMemberGroups</para>
    ///     <para type="description">The action &quot;microsoft.graph.checkMemberGroups&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;Edm.String&quot; objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupCheckMemberGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupCheckMemberGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;groupIds&quot; action parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Expandable]
        [ValidateNotNull]
        [AllowEmptyCollection]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupIds&quot; action parameter of type &quot;Edm.String&quot;.")]
        public System.String[] groupIds { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/checkMemberGroups";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/getMemberGroups</para>
    ///     <para type="description">The action &quot;microsoft.graph.getMemberGroups&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;Edm.String&quot; objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupGetMemberGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupGetMemberGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;securityEnabledOnly&quot; action parameter of type &quot;Edm.Boolean&quot;.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Expandable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;securityEnabledOnly&quot; action parameter of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityEnabledOnly { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/getMemberGroups";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/getMemberObjects</para>
    ///     <para type="description">The action &quot;microsoft.graph.getMemberObjects&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action returns a collection of &quot;Edm.String&quot; objects.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupGetMemberObject", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupGetMemberObject : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;securityEnabledOnly&quot; action parameter of type &quot;Edm.Boolean&quot;.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Expandable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;securityEnabledOnly&quot; action parameter of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityEnabledOnly { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/getMemberObjects";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/groups/restore</para>
    ///     <para type="description">The action &quot;microsoft.graph.restore&quot;, which exists on the type &quot;microsoft.graph.group&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.directoryObject&quot; object.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "GroupRestore", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.group")]
    [ResourceTypePropertyName("groupODataType")]
    public class Invoke_GroupRestore : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/restore";
        }
    }
}