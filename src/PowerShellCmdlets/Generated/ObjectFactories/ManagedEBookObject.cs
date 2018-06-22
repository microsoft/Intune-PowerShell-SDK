// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedEBook&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedEBook&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">An abstract class containing the base properties for Managed eBook.</para>
    /// </summary>
    [Cmdlet("New", "ManagedEBookObject", DefaultParameterSetName = @"#microsoft.graph.iosVppEBook")]
    [ODataType("microsoft.graph.managedEBook")]
    public class New_ManagedEBookObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">Name of the eBook.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">Publisher.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publisher { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publishedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The date and time when the eBook was published.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;publishedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;publishedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset publishedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;largeCover&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">Book cover.</para>
        /// </summary>
        [ODataType("microsoft.graph.mimeContent")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;largeCover&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;largeCover&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        public System.Object largeCover { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The date and time when the eBook file was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The date and time when the eBook was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The more information Url.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String informationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The privacy statement Url.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String privacyInformationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedEBookAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The list of assignments for this eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedEBookAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedEBookAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedEBookAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installSummary&quot; property, of type &quot;microsoft.graph.eBookInstallSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">Mobile App Install Summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.eBookInstallSummary")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;installSummary&quot; property, of type &quot;microsoft.graph.eBookInstallSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;installSummary&quot; property, of type &quot;microsoft.graph.eBookInstallSummary&quot;.")]
        public System.Object installSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The list of installation states for this eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceInstallState")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;deviceStates&quot; property, of type &quot;microsoft.graph.deviceInstallState&quot;.")]
        public System.Object[] deviceStates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStateSummary&quot; property, of type &quot;microsoft.graph.userInstallStateSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedEBook&quot; type.</para>
        ///     <para type="description">The list of installation states for this eBook.</para>
        /// </summary>
        [ODataType("microsoft.graph.userInstallStateSummary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedEBook", HelpMessage = @"The &quot;userStateSummary&quot; property, of type &quot;microsoft.graph.userInstallStateSummary&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;userStateSummary&quot; property, of type &quot;microsoft.graph.userInstallStateSummary&quot;.")]
        public System.Object[] userStateSummary { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosVppEBook")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppEBook&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppEBook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">The Vpp token ID.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;vppTokenId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid vppTokenId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">The Apple ID associated with Vpp token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppOrganizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">The Vpp token&apos;s organization name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;vppOrganizationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String vppOrganizationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;genres&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">Genres.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;genres&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] genres { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;language&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">Language.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;language&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String language { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;seller&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">Seller.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;seller&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String seller { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">Total license count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;totalLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalLicenseCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usedLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppEBook&quot; type.</para>
        ///     <para type="description">Used license count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppEBook", HelpMessage = @"The &quot;usedLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 usedLicenseCount { get; set; }
    }
}