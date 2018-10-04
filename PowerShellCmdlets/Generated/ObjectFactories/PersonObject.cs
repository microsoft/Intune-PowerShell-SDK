// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.person&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.person&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "PersonObject", DefaultParameterSetName = @"microsoft.graph.person")]
    [ODataType("microsoft.graph.person")]
    public class New_PersonObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String givenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;surname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;birthday&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personNotes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;personNotes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String personNotes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isFavorite&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;isFavorite&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isFavorite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scoredEmailAddresses&quot; property, of type &quot;microsoft.graph.scoredEmailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.scoredEmailAddress")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;scoredEmailAddresses&quot; property, of type &quot;microsoft.graph.scoredEmailAddress&quot;.")]
        public System.Object[] scoredEmailAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phones&quot; property, of type &quot;microsoft.graph.phone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.phone")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;phones&quot; property, of type &quot;microsoft.graph.phone&quot;.")]
        public System.Object[] phones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalAddresses&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location", "microsoft.graph.locationConstraintItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;postalAddresses&quot; property, of type &quot;microsoft.graph.location&quot;.")]
        public System.Object[] postalAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;websites&quot; property, of type &quot;microsoft.graph.website&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.website")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;websites&quot; property, of type &quot;microsoft.graph.website&quot;.")]
        public System.Object[] websites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String jobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String companyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiCompany&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;yomiCompany&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String yomiCompany { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;department&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String officeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;profession&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;profession&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String profession { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personType&quot; property, of type &quot;microsoft.graph.personType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.personType")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;personType&quot; property, of type &quot;microsoft.graph.personType&quot;.")]
        public System.Object personType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.person", HelpMessage = @"The &quot;imAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String imAddress { get; set; }
    }
}