// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationOrganization&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationOrganization&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationOrganizationObject", DefaultParameterSetName = @"microsoft.graph.educationOrganization")]
    [ODataType("microsoft.graph.educationOrganization")]
    public class New_EducationOrganizationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationOrganization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationOrganization", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationOrganization&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationOrganization", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationOrganization&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sis&apos;, &apos;manual&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationExternalSource")]
        [Selectable]
        [ValidateSet(@"sis", @"manual", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.educationOrganization", HelpMessage = @"The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.")]
        public System.String externalSource { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.educationSchool")]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.educationSchool&quot; type.")]
        public System.Management.Automation.SwitchParameter educationSchool { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;principalEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;principalEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String principalEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;principalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;principalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String principalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalPrincipalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;externalPrincipalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String externalPrincipalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lowestGrade&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;lowestGrade&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String lowestGrade { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;highestGrade&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;highestGrade&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String highestGrade { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schoolNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;schoolNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String schoolNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String externalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;phone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;phone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String phone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fax&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;fax&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fax { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;address&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationClass")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;classes&quot; property, of type &quot;microsoft.graph.educationClass&quot;.")]
        public System.Object[] classes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;users&quot; property, of type &quot;microsoft.graph.educationUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationSchool&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationUser")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.educationSchool", HelpMessage = @"The &quot;users&quot; property, of type &quot;microsoft.graph.educationUser&quot;.")]
        public System.Object[] users { get; set; }
    }
}