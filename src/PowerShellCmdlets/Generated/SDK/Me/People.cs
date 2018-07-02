// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.person&quot; objects.</para>
    ///     <para type="description">GET ~/me/people</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.person&quot; objects in the &quot;people&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_People", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.person")]
    [ResourceIdPropertyName("personId")]
    [ResourceReference]
    public class Get_Me_People : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.person&quot; object in the &quot;people&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.person&quot; object in the &quot;people&quot; collection.")]
        public System.String personId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;givenName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String givenName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;surname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String surname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthday&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String birthday { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personNotes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String personNotes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isFavorite&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isFavorite { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scoredEmailAddresses&quot; property, of type &quot;microsoft.graph.scoredEmailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.scoredEmailAddress")]
        [Selectable]
        public System.Object[] scoredEmailAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phones&quot; property, of type &quot;microsoft.graph.phone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.phone")]
        [Selectable]
        public System.Object[] phones { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;postalAddresses&quot; property, of type &quot;microsoft.graph.location&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.location")]
        [Selectable]
        public System.Object[] postalAddresses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;websites&quot; property, of type &quot;microsoft.graph.website&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.website")]
        [Selectable]
        public System.Object[] websites { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;jobTitle&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String jobTitle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;companyName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String companyName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yomiCompany&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String yomiCompany { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;department&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String department { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;officeLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String officeLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;profession&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String profession { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;personType&quot; property, of type &quot;microsoft.graph.personType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.personType")]
        [Selectable]
        [Sortable]
        public System.Object personType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;imAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.person&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String imAddress { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/people/{personId ?? string.Empty}";
        }
    }
}