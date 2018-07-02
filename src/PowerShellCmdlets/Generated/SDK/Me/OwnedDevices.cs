// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.directoryObject&quot; objects.</para>
    ///     <para type="description">GET ~/me/ownedDevices</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.directoryObject&quot; objects in the &quot;ownedDevices&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_OwnedDevices", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.directoryObject")]
    [ResourceIdPropertyName("ownedDeviceId")]
    public class Get_Me_OwnedDevices : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.")]
        public System.String ownedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryObject&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset deletedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingTemplateValue")]
        [Selectable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.Object[] values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Boolean accountEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String ageGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedLicense")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] assignedLicenses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedPlan")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] assignedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] businessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;city&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String city { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String companyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String consentProvidedForMinor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;country&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String country { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String givenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] imAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String jobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String legalAgeGroupClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String onPremisesImmutableId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String passwordPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.passwordProfile")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object passwordProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String officeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String postalCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String preferredLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.provisionedPlan")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] provisionedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String streetAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String usageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String userType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailboxSettings")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object mailboxSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String aboutMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset hireDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;interests&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] interests { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mySite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] pastProjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String preferredName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] responsibilities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skills&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] skills { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Int32 deviceEnrollmentLimit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] ownedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] registeredDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object manager { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] directReports { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] createdObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] ownedObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.licenseDetails")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] licenseDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookUser")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object outlook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] mailFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendars { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendarGroup")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendarGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.person")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] people { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] contactFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassification")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] drives { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerGroup")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object planner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenote")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object onenote { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The managed devices associated with the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] managedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for this user.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] deviceManagementTroubleshootingEvents { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] activities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String countryLetterCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] marketingNotificationEmails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.privacyProfile")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.Object privacyProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] securityComplianceNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] securityComplianceNotificationPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;street&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String street { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] technicalNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.verifiedDomain")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.Object[] verifiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileDeviceManagementAuthority&quot; property, of type &quot;microsoft.graph.mdmAuthority&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        ///     <para type="description">Mobile device management authority.</para>
        /// </summary>
        [ODataType("microsoft.graph.mdmAuthority")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String mobileDeviceManagementAuthority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.String contractType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.Guid customerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.String defaultDomainName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.group")]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversationThread")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] threads { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversation")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] conversations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] acceptedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] rejectedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.site")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] sites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.directoryRole")]
        public System.String roleTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alternativeSecurityId")]
        [Selectable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] alternativeSecurityIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.DateTimeOffset approximateLastSignInDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String deviceMetadata { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Int32 deviceVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Boolean isCompliant { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Boolean isManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String operatingSystemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.device")]
        public System.String[] physicalIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String trustType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] registeredOwners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] registeredUsers { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/ownedDevices/{ownedDeviceId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.directoryObject&quot; object references.</para>
    ///     <para type="description">GET ~/me/ownedDevices/$ref</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.directoryObject&quot; object references in the &quot;ownedDevices&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_OwnedDevicesReferences", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.directoryObject")]
    [ResourceIdPropertyName("ownedDeviceId")]
    public class Get_Me_OwnedDevicesReferences : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.")]
        public System.String ownedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deletedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryObject&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset deletedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingTemplateValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSettingTemplate&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingTemplateValue")]
        [Selectable]
        [DerivedType("microsoft.graph.groupSettingTemplate")]
        public System.Object[] values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Boolean accountEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ageGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String ageGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedLicense")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] assignedLicenses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedPlan")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] assignedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] businessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;city&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String city { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String companyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;consentProvidedForMinor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String consentProvidedForMinor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;country&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String country { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String givenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] imAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String jobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;legalAgeGroupClassification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String legalAgeGroupClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesImmutableId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String onPremisesImmutableId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesLastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset onPremisesLastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSyncEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Boolean onPremisesSyncEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String passwordPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.passwordProfile")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object passwordProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String officeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String postalCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String preferredLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.provisionedPlan")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] provisionedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;proxyAddresses&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] proxyAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;streetAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String streetAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String usageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String userType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailboxSettings&quot; property, of type &quot;microsoft.graph.mailboxSettings&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailboxSettings")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object mailboxSettings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;aboutMe&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String aboutMe { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hireDate&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.DateTimeOffset hireDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;interests&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] interests { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mySite&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String mySite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pastProjects&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] pastProjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.String preferredName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;responsibilities&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] responsibilities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skills&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.user")]
        public System.String[] skills { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceEnrollmentLimit&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Int32 deviceEnrollmentLimit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] ownedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredDevices&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] registeredDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;manager&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object manager { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;directReports&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] directReports { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;memberOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] memberOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] createdObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ownedObjects&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] ownedObjects { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licenseDetails&quot; property, of type &quot;microsoft.graph.licenseDetails&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.licenseDetails")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] licenseDetails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensions&quot; property, of type &quot;microsoft.graph.extension&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.extension")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] extensions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;outlook&quot; property, of type &quot;microsoft.graph.outlookUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookUser")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object outlook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] mailFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendar&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object calendar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendars&quot; property, of type &quot;microsoft.graph.calendar&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendar")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendars { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarGroups&quot; property, of type &quot;microsoft.graph.calendarGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.calendarGroup")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendarGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calendarView&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] calendarView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;events&quot; property, of type &quot;microsoft.graph.event&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.event")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] events { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;people&quot; property, of type &quot;microsoft.graph.person&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.person")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] people { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] contactFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inferenceClassification&quot; property, of type &quot;microsoft.graph.inferenceClassification&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassification")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object inferenceClassification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photo&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object photo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;photos&quot; property, of type &quot;microsoft.graph.profilePhoto&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.profilePhoto")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] photos { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drive&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object drive { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;drives&quot; property, of type &quot;microsoft.graph.drive&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.drive")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] drives { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;planner&quot; property, of type &quot;microsoft.graph.plannerUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerGroup")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object planner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onenote&quot; property, of type &quot;microsoft.graph.onenote&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenote")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.user")]
        public System.Object onenote { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The managed devices associated with the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] managedDevices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedAppRegistrations&quot; property, of type &quot;microsoft.graph.managedAppRegistration&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">Zero or more managed app registrations that belong to the user.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppRegistration")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] managedAppRegistrations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceManagementTroubleshootingEvents&quot; property, of type &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        ///     <para type="description">The list of troubleshooting events for this user.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] deviceManagementTroubleshootingEvents { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activities&quot; property, of type &quot;microsoft.graph.userActivity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.user&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.userActivity")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.user")]
        public System.Object[] activities { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryLetterCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String countryLetterCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;marketingNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] marketingNotificationEmails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyProfile&quot; property, of type &quot;microsoft.graph.privacyProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.privacyProfile")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.Object privacyProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] securityComplianceNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityComplianceNotificationPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] securityComplianceNotificationPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;street&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String street { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;technicalNotificationMails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.String[] technicalNotificationMails { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verifiedDomains&quot; property, of type &quot;microsoft.graph.verifiedDomain&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.verifiedDomain")]
        [Selectable]
        [DerivedType("microsoft.graph.organization")]
        public System.Object[] verifiedDomains { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileDeviceManagementAuthority&quot; property, of type &quot;microsoft.graph.mdmAuthority&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.organization&quot; type.</para>
        ///     <para type="description">Mobile device management authority.</para>
        /// </summary>
        [ODataType("microsoft.graph.mdmAuthority")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.organization")]
        public System.String mobileDeviceManagementAuthority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contractType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.String contractType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;customerId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.Guid customerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultDomainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contract&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.contract")]
        public System.String defaultDomainName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classification&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.String classification { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.group")]
        public System.String[] groupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean mailEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renewedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.DateTimeOffset renewedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;securityEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean securityEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;visibility&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.String visibility { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;allowExternalSenders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean allowExternalSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;autoSubscribeNewMembers&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean autoSubscribeNewMembers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSubscribedByMail&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Boolean isSubscribedByMail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unseenCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Int32 unseenCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdOnBehalfOf&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [Sortable]
        [DerivedType("microsoft.graph.group")]
        public System.Object createdOnBehalfOf { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] owners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.groupSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupSetting")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] settings { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threads&quot; property, of type &quot;microsoft.graph.conversationThread&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversationThread")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] threads { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conversations&quot; property, of type &quot;microsoft.graph.conversation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.conversation")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] conversations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] acceptedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rejectedSenders&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] rejectedSenders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sites&quot; property, of type &quot;microsoft.graph.site&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.site")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] sites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupLifecyclePolicies&quot; property, of type &quot;microsoft.graph.groupLifecyclePolicy&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.group&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.groupLifecyclePolicy")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.group")]
        public System.Object[] groupLifecyclePolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roleTemplateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.directoryRole&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.directoryRole")]
        public System.String roleTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternativeSecurityIds&quot; property, of type &quot;microsoft.graph.alternativeSecurityId&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alternativeSecurityId")]
        [Selectable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] alternativeSecurityIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;approximateLastSignInDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.DateTimeOffset approximateLastSignInDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceMetadata&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String deviceMetadata { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Int32 deviceVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Boolean isCompliant { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.Boolean isManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystemVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String operatingSystemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;physicalIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [DerivedType("microsoft.graph.device")]
        public System.String[] physicalIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.device")]
        public System.String trustType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredOwners&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] registeredOwners { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;registeredUsers&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.device&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [Expandable]
        [DerivedType("microsoft.graph.device")]
        public System.Object[] registeredUsers { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/ownedDevices/{ownedDeviceId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;me&quot; to a &quot;microsoft.graph.directoryObject&quot; object.</para>
    ///     <para type="description">POST ~/me/ownedDevices/$ref</para>
    ///     <para type="description">Creates a reference from the specified &quot;me&quot; object to a &quot;ownedDevice&quot;.</para>
    /// </summary>
    [Cmdlet("New", "Me_OwnedDevicesReferences", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.directoryObject")]
    [ResourceIdPropertyName("directoryObjectReferenceUrl")]
    public class New_Me_OwnedDevicesReferences : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.directoryObject&quot; object.</para>
        /// </summary>
        [Selectable]
        [Alias("deviceReferenceUrl", "directoryRoleReferenceUrl", "directoryRoleTemplateReferenceUrl", "groupReferenceUrl", "contractReferenceUrl", "organizationReferenceUrl", "userReferenceUrl", "groupSettingTemplateReferenceUrl", "administrativeUnitReferenceUrl")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.directoryObject&quot; object.")]
        public System.String directoryObjectReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/ownedDevices/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(directoryObjectReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;me&quot; to a &quot;microsoft.graph.directoryObject&quot; object.</para>
    ///     <para type="description">DELETE ~/me/ownedDevices/ownedDeviceId/$ref</para>
    ///     <para type="description">Removes a reference from the specified &quot;me&quot; object to a &quot;ownedDevice&quot;.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_OwnedDevicesReferences", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.directoryObject")]
    [ResourceIdPropertyName("ownedDeviceId")]
    public class Remove_Me_OwnedDevicesReferences : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.directoryObject&quot; object in the &quot;ownedDevices&quot; collection.")]
        public System.String ownedDeviceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/ownedDevices/{ownedDeviceId}/$ref";
        }
    }
}