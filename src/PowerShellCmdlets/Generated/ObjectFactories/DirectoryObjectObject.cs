// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.directoryObject&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.directoryObject&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DirectoryObjectObject", DefaultParameterSetName = @"#microsoft.graph.directoryObject")]
    [ODataType("microsoft.graph.directoryObject")]
    public class New_DirectoryObjectObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryObject&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.directoryObject")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryObject", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryObject&quot; type.")]
        public System.Management.Automation.SwitchParameter directoryObject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryObject&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryObject", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.administrativeUnit", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRoleTemplate", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset deletedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.administrativeUnit&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.administrativeUnit")]
        [Parameter(ParameterSetName = @"#microsoft.graph.administrativeUnit", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.administrativeUnit&quot; type.")]
        public System.Management.Automation.SwitchParameter administrativeUnit { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.groupSettingTemplate")]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupSettingTemplate&quot; type.")]
        public System.Management.Automation.SwitchParameter groupSettingTemplate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRoleTemplate", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRoleTemplate", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingTemplateValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.")]
        public System.Object[] values { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.user")]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.user&quot; type.")]
        public System.Management.Automation.SwitchParameter user { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean accountEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ageGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedLicense")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.")]
        public System.Object[] assignedLicenses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.")]
        public System.Object[] assignedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] businessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;city&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;city&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;city&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String city { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String companyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String consentProvidedForMinor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;country&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;country&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;country&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String country { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String givenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] imAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String jobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String legalAgeGroupClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onPremisesImmutableId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String passwordPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.passwordProfile")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.")]
        public System.Object passwordProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String officeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String postalCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String preferredLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.provisionedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.")]
        public System.Object[] provisionedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String streetAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String usageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;userType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailboxSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.")]
        public System.Object mailboxSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String aboutMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset hireDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;interests&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;interests&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] interests { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mySite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] pastProjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String preferredName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] responsibilities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;schools&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skills&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;skills&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] skills { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceEnrollmentLimit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] ownedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] registeredDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object manager { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] directReports { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] createdObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] ownedObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.licenseDetails")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.")]
        public System.Object[] licenseDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.")]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookUser")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.")]
        public System.Object outlook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] mailFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object[] calendars { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendarGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.")]
        public System.Object[] calendarGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.person")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.")]
        public System.Object[] people { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        public System.Object[] contactFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassification")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.")]
        public System.Object inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object[] drives { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.")]
        public System.Object planner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenote")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.")]
        public System.Object onenote { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The managed devices associated with the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] managedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for this user.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.")]
        public System.Object[] deviceManagementTroubleshootingEvents { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        public System.Object[] activities { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.organization")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.organization&quot; type.")]
        public System.Management.Automation.SwitchParameter organization { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String countryLetterCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] marketingNotificationEmails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.privacyProfile")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.")]
        public System.Object privacyProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] securityComplianceNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] securityComplianceNotificationPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;street&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;street&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String street { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] technicalNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.verifiedDomain")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.")]
        public System.Object[] verifiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileDeviceManagementAuthority&quot; property, of type &quot;microsoft.graph.mdmAuthority&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        ///     <para type="description">Mobile device management authority.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;intune&apos;, &apos;sccm&apos;, &apos;office365&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mdmAuthority")]
        [Selectable]
        [ValidateSet(@"unknown", @"intune", @"sccm", @"office365")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;mobileDeviceManagementAuthority&quot; property, of type &quot;microsoft.graph.mdmAuthority&quot;.")]
        public System.String mobileDeviceManagementAuthority { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.contract")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contract&quot; type.")]
        public System.Management.Automation.SwitchParameter contract { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contractType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid customerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String defaultDomainName { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.group")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.group&quot; type.")]
        public System.Management.Automation.SwitchParameter group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversationThread")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.")]
        public System.Object[] threads { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.")]
        public System.Object[] conversations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] acceptedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] rejectedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.site")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.")]
        public System.Object[] sites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRoleTemplate&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.directoryRoleTemplate")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRoleTemplate", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRoleTemplate&quot; type.")]
        public System.Management.Automation.SwitchParameter directoryRoleTemplate { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.directoryRole")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRole&quot; type.")]
        public System.Management.Automation.SwitchParameter directoryRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String roleTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.device")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.device&quot; type.")]
        public System.Management.Automation.SwitchParameter device { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alternativeSecurityId")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.")]
        public System.Object[] alternativeSecurityIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset approximateLastSignInDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceMetadata { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isCompliant { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] physicalIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String trustType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] registeredOwners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] registeredUsers { get; set; }
    }
}