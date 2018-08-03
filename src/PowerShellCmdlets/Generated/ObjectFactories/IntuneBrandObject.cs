// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.intuneBrand&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.intuneBrand&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IntuneBrandObject", DefaultParameterSetName = @"#microsoft.graph.intuneBrand")]
    [ODataType("microsoft.graph.intuneBrand")]
    public class New_IntuneBrandObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Company/organization name that is displayed to end users.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactITName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Name of the person/organization responsible for IT support.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;contactITName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContactITName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactITPhoneNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Phone number of the person/organization responsible for IT support.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;contactITPhoneNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContactITPhoneNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactITEmailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Email address of the person/organization responsible for IT support.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;contactITEmailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContactITEmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contactITNotes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Text comments regarding the person/organization responsible for IT support.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;contactITNotes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContactITNotes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">URL to the company/organization’s privacy policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;privacyUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PrivacyUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onlineSupportSiteUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">URL to the company/organization’s IT helpdesk site.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;onlineSupportSiteUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OnlineSupportSiteUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onlineSupportSiteName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Display name of the company/organization’s IT helpdesk site.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;onlineSupportSiteName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OnlineSupportSiteName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;themeColor&quot; property, of type &quot;microsoft.graph.rgbColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Primary theme color used in the Company Portal applications and web portal.</para>
        /// </summary>
        [ODataType("microsoft.graph.rgbColor")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;themeColor&quot; property, of type &quot;microsoft.graph.rgbColor&quot;.")]
        public System.Object ThemeColor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showLogo&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Boolean that represents whether the administrator-supplied logo images are shown or not shown.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;showLogo&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ShowLogo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lightBackgroundLogo&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Logo image displayed in Company Portal apps which have a light background behind the logo.</para>
        /// </summary>
        [ODataType("microsoft.graph.mimeContent")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;lightBackgroundLogo&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        public System.Object LightBackgroundLogo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;darkBackgroundLogo&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Logo image displayed in Company Portal apps which have a dark background behind the logo.</para>
        /// </summary>
        [ODataType("microsoft.graph.mimeContent")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;darkBackgroundLogo&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        public System.Object DarkBackgroundLogo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showNameNextToLogo&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;showNameNextToLogo&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ShowNameNextToLogo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showDisplayNameNextToLogo&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.intuneBrand&quot; type.</para>
        ///     <para type="description">Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.intuneBrand", HelpMessage = @"The &quot;showDisplayNameNextToLogo&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ShowDisplayNameNextToLogo { get; set; }
    }
}