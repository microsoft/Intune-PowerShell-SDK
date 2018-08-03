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
        public System.Management.Automation.SwitchParameter DirectoryObject { get; set; }

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
        public System.DateTimeOffset DeletedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.administrativeUnit&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.administrativeUnit")]
        [Parameter(ParameterSetName = @"#microsoft.graph.administrativeUnit", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.administrativeUnit&quot; type.")]
        public System.Management.Automation.SwitchParameter AdministrativeUnit { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.groupSettingTemplate")]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.groupSettingTemplate&quot; type.")]
        public System.Management.Automation.SwitchParameter GroupSettingTemplate { get; set; }

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
        public System.String DisplayName { get; set; }

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
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingTemplateValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupSettingTemplate", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.")]
        public System.Object[] Values { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.user")]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.user&quot; type.")]
        public System.Management.Automation.SwitchParameter User { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AccountEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AgeGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedLicense")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.")]
        public System.Object[] AssignedLicenses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.")]
        public System.Object[] AssignedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] BusinessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;city&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;city&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;city&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String City { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CompanyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ConsentProvidedForMinor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;country&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;country&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;country&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Country { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String GivenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] ImAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String JobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String LegalAgeGroupClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OnPremisesImmutableId { get; set; }

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
        public System.DateTimeOffset OnPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OnPremisesSecurityIdentifier { get; set; }

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
        public System.Boolean OnPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PasswordPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.passwordProfile")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.")]
        public System.Object PasswordProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OfficeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PostalCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PreferredLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.provisionedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.")]
        public System.Object[] ProvisionedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] ProxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String StreetAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UsageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;userType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailboxSettings")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.")]
        public System.Object MailboxSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AboutMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset Birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset HireDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;interests&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;interests&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Interests { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MySite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] PastProjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PreferredName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Responsibilities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;schools&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skills&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;skills&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Skills { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeviceEnrollmentLimit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] OwnedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] RegisteredDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object Manager { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] DirectReports { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] MemberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] CreatedObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] OwnedObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.licenseDetails")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.")]
        public System.Object[] LicenseDetails { get; set; }

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
        public System.Object[] Extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookUser")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.")]
        public System.Object Outlook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] Messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] MailFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object Calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.")]
        public System.Object[] Calendars { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendarGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.")]
        public System.Object[] CalendarGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] CalendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.")]
        public System.Object[] Events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.person")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.")]
        public System.Object[] People { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        public System.Object[] Contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        public System.Object[] ContactFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassification")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.")]
        public System.Object InferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object Photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.")]
        public System.Object[] Photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object Drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.")]
        public System.Object[] Drives { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.")]
        public System.Object Planner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenote")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.")]
        public System.Object Onenote { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The managed devices associated with the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] ManagedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.")]
        public System.Object[] ManagedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for this user.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.")]
        public System.Object[] DeviceManagementTroubleshootingEvents { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.user", HelpMessage = @"The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.")]
        public System.Object[] Activities { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.organization")]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.organization&quot; type.")]
        public System.Management.Automation.SwitchParameter Organization { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CountryLetterCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] MarketingNotificationEmails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.privacyProfile")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.")]
        public System.Object PrivacyProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] SecurityComplianceNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] SecurityComplianceNotificationPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;street&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;street&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Street { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] TechnicalNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.verifiedDomain")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.organization", HelpMessage = @"The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.")]
        public System.Object[] VerifiedDomains { get; set; }

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
        public System.String MobileDeviceManagementAuthority { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.contract")]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.contract&quot; type.")]
        public System.Management.Automation.SwitchParameter Contract { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContractType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid CustomerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contract", HelpMessage = @"The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DefaultDomainName { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.group")]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.group&quot; type.")]
        public System.Management.Automation.SwitchParameter Group { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;classification&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] GroupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean MailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset RenewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean SecurityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AllowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AutoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] Members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object CreatedOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] Owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.")]
        public System.Object[] Settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversationThread")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.")]
        public System.Object[] Threads { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.")]
        public System.Object[] Conversations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] AcceptedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] RejectedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.site")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.")]
        public System.Object[] Sites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.group", HelpMessage = @"The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.")]
        public System.Object[] GroupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRoleTemplate&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.directoryRoleTemplate")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRoleTemplate", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRoleTemplate&quot; type.")]
        public System.Management.Automation.SwitchParameter DirectoryRoleTemplate { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.directoryRole")]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.directoryRole&quot; type.")]
        public System.Management.Automation.SwitchParameter DirectoryRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.directoryRole", HelpMessage = @"The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String RoleTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.device")]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.device&quot; type.")]
        public System.Management.Automation.SwitchParameter Device { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alternativeSecurityId")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.")]
        public System.Object[] AlternativeSecurityIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ApproximateLastSignInDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DeviceMetadata { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeviceVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsCompliant { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OperatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OperatingSystemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] PhysicalIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String TrustType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] RegisteredOwners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.device", HelpMessage = @"The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] RegisteredUsers { get; set; }
    }
}