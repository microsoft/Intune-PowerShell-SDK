// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.person&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.person&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PersonObject", DefaultParameterSetName = @"#microsoft.graph.person")]
    [ODataType("microsoft.graph.person")]
    public class New_PersonObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String GivenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;birthday&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personNotes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;personNotes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PersonNotes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isFavorite&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;isFavorite&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsFavorite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scoredEmailAddresses&quot; property, of type &quot;microsoft.graph.scoredEmailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.scoredEmailAddress")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;scoredEmailAddresses&quot; property, of type &quot;microsoft.graph.scoredEmailAddress&quot;.")]
        public System.Object[] ScoredEmailAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phones&quot; property, of type &quot;microsoft.graph.phone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.phone")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;phones&quot; property, of type &quot;microsoft.graph.phone&quot;.")]
        public System.Object[] Phones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalAddresses&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;postalAddresses&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object[] PostalAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;websites&quot; property, of type &quot;microsoft.graph.website&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.website")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;websites&quot; property, of type &quot;microsoft.graph.website&quot;.")]
        public System.Object[] Websites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String JobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CompanyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiCompany&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;yomiCompany&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String YomiCompany { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OfficeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;profession&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;profession&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Profession { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personType&quot; property, of type &quot;microsoft.graph.personType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.personType")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;personType&quot; property, of type &quot;microsoft.graph.personType&quot;.")]
        public System.Object PersonType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UserPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.person", HelpMessage = @"The &quot;imAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ImAddress { get; set; }
    }
}