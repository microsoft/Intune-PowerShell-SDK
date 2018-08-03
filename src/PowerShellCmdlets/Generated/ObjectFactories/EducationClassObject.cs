// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationClass&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationClass&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationClassObject", DefaultParameterSetName = @"#microsoft.graph.educationClass")]
    [ODataType("microsoft.graph.educationClass")]
    public class New_EducationClassObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;mailNickname&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MailNickname { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object CreatedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;classCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ClassCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;externalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ExternalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ExternalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;sis&apos;, &apos;manual&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationExternalSource")]
        [Selectable]
        [ValidateSet(@"sis", @"manual", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;externalSource&quot; property, of type &quot;microsoft.graph.educationExternalSource&quot;.")]
        public System.String ExternalSource { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;term&quot; property, of type &quot;microsoft.graph.educationTerm&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationTerm")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;term&quot; property, of type &quot;microsoft.graph.educationTerm&quot;.")]
        public System.Object Term { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationSchool")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;schools&quot; property, of type &quot;microsoft.graph.educationSchool&quot;.")]
        public System.Object[] Schools { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;members&quot; property, of type &quot;microsoft.graph.educationUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationUser")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;members&quot; property, of type &quot;microsoft.graph.educationUser&quot;.")]
        public System.Object[] Members { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;teachers&quot; property, of type &quot;microsoft.graph.educationUser&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.educationUser")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;teachers&quot; property, of type &quot;microsoft.graph.educationUser&quot;.")]
        public System.Object[] Teachers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;group&quot; property, of type &quot;microsoft.graph.group&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationClass&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.group")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationClass", HelpMessage = @"The &quot;group&quot; property, of type &quot;microsoft.graph.group&quot;.")]
        public System.Object Group { get; set; }
    }
}