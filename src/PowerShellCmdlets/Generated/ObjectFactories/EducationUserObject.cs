// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationUser&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationUser&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationUserObject", DefaultParameterSetName = @"#microsoft.graph.educationUser")]
    [ODataType("microsoft.graph.educationUser")]
    public class New_EducationUserObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;primaryRole&quot; property, of type &quot;microsoft.graph.educationUserRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;student&apos;, &apos;teacher&apos;, &apos;none&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationUserRole")]
        [Selectable]
        [ValidateSet(@"student", @"teacher", @"none", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;primaryRole&quot; property, of type &quot;microsoft.graph.educationUserRole&quot;.")]
        public System.String PrimaryRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;middleName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;middleName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MiddleName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sis&apos;, &apos;manual&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationExternalSource")]
        [Selectable]
        [ValidateSet(@"sis", @"manual", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.")]
        public System.String ExternalSource { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;residenceAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;residenceAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object ResidenceAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailingAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;mailingAddress&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object MailingAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;student&quot; property, of type &quot;microsoft.graph.educationStudent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationStudent")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;student&quot; property, of type &quot;microsoft.graph.educationStudent&quot;.")]
        public System.Object Student { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;teacher&quot; property, of type &quot;microsoft.graph.educationTeacher&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationTeacher")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;teacher&quot; property, of type &quot;microsoft.graph.educationTeacher&quot;.")]
        public System.Object Teacher { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object CreatedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;relatedContacts&quot; property, of type &quot;microsoft.graph.educationRelatedContact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationRelatedContact")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;relatedContacts&quot; property, of type &quot;microsoft.graph.educationRelatedContact&quot;.")]
        public System.Object[] RelatedContacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;accountEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AccountEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedLicense")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;assignedLicenses&quot; property, of type &quot;microsoft.graph.assignedLicense&quot;.")]
        public System.Object[] AssignedLicenses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.assignedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;assignedPlans&quot; property, of type &quot;microsoft.graph.assignedPlan&quot;.")]
        public System.Object[] AssignedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;businessPhones&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] BusinessPhones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String GivenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;mail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Mail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;passwordPolicies&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PasswordPolicies { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.passwordProfile")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;passwordProfile&quot; property, of type &quot;microsoft.graph.passwordProfile&quot;.")]
        public System.Object PasswordProfile { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OfficeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;preferredLanguage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PreferredLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.provisionedPlan")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;provisionedPlans&quot; property, of type &quot;microsoft.graph.provisionedPlan&quot;.")]
        public System.Object[] ProvisionedPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;refreshTokensValidFromDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;refreshTokensValidFromDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset RefreshTokensValidFromDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showInAddressList&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;showInAddressList&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ShowInAddressList { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;usageLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UsageLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;userType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationSchool")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.")]
        public System.Object[] Schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationClass")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.")]
        public System.Object[] Classes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;user&quot; property, of type &quot;microsoft.graph.user&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.user")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationUser", HelpMessage = @"The &quot;user&quot; property, of type &quot;microsoft.graph.user&quot;.")]
        public System.Object User { get; set; }
    }
}