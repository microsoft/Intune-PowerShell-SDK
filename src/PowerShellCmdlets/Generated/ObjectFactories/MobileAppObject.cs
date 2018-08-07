// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">An abstract class containing the base properties for Intune mobile apps.</para>
    /// </summary>
    [Cmdlet("New", "MobileAppObject", DefaultParameterSetName = @"#microsoft.graph.mobileApp")]
    [ODataType("microsoft.graph.mobileApp")]
    public class New_MobileAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The admin provided or imported title of the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The description of the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The publisher of the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publisher { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The large icon, to be displayed in the app details and used for upload of the icon.</para>
        /// </summary>
        [ODataType("microsoft.graph.mimeContent")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;largeIcon&quot; property, of type &quot;microsoft.graph.mimeContent&quot;.")]
        public System.Object largeIcon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The date and time the app was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The date and time the app was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The value indicating whether the app is marked as featured by the admin.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;isFeatured&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isFeatured { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The privacy statement Url.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;privacyInformationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String privacyInformationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The more information Url.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;informationUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String informationUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The owner of the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;owner&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;developer&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The developer of the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;developer&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String developer { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">Notes for the app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;notes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String notes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The publishing state for the app. The app cannot be assigned unless the app is published.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notPublished&apos;, &apos;processing&apos;, &apos;published&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppPublishingState")]
        [Selectable]
        [ValidateSet(@"notPublished", @"processing", @"published")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;publishingState&quot; property, of type &quot;microsoft.graph.mobileAppPublishingState&quot;.")]
        public System.String publishingState { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The list of categories for this app.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;categories&quot; property, of type &quot;microsoft.graph.mobileAppCategory&quot;.")]
        public System.Object[] categories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileApp&quot; type.</para>
        ///     <para type="description">The list of group assignments for this mobile app.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.mobileAppAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosStoreApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosStoreApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosStoreApp&quot; type.")]
        public System.Management.Automation.SwitchParameter iosStoreApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosStoreApp&quot; type.</para>
        ///     <para type="description">The Identity Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bundleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosStoreApp&quot; type.</para>
        ///     <para type="description">The Apple App Store URL</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appStoreUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosStoreApp&quot; type.</para>
        ///     <para type="description">The iOS architecture for which this app can run on.</para>
        /// </summary>
        [ODataType("microsoft.graph.iosDeviceType")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;applicableDeviceType&quot; property, of type &quot;microsoft.graph.iosDeviceType&quot;.")]
        public System.Object applicableDeviceType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosStoreApp&quot; type.</para>
        ///     <para type="description">The value for the minimum applicable operating system.</para>
        /// </summary>
        [ODataType("microsoft.graph.androidMinimumOperatingSystem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosStoreApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;minimumSupportedOperatingSystem&quot; property, of type &quot;microsoft.graph.iosMinimumOperatingSystem&quot;.")]
        public System.Object minimumSupportedOperatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosVppApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosVppApp&quot; type.")]
        public System.Management.Automation.SwitchParameter iosVppApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;usedLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The number of VPP licenses in use.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;usedLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;usedLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 usedLicenseCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The total number of VPP licenses.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;totalLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;totalLicenseCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalLicenseCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;releaseDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The VPP application release date and time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;releaseDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset releaseDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licensingType&quot; property, of type &quot;microsoft.graph.vppLicensingType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The supported License Type.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppLicensingType")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;licensingType&quot; property, of type &quot;microsoft.graph.vppLicensingType&quot;.")]
        public System.Object licensingType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenOrganizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The organization associated with the Apple Volume Purchase Program Token</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;vppTokenOrganizationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String vppTokenOrganizationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: `business`, `education`.</para>
        ///     <para type="description">
        ///          Valid values: &apos;business&apos;, &apos;education&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenAccountType")]
        [Selectable]
        [ValidateSet(@"business", @"education")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.")]
        public System.String vppTokenAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenAppleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosVppApp&quot; type.</para>
        ///     <para type="description">The Apple Id associated with the given Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosVppApp", HelpMessage = @"The &quot;vppTokenAppleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String vppTokenAppleId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidStoreApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidStoreApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidStoreApp&quot; type.")]
        public System.Management.Automation.SwitchParameter androidStoreApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidStoreApp&quot; type.</para>
        ///     <para type="description">The package identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidStoreApp", HelpMessage = @"The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String packageId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.webApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.webApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.webApp&quot; type.")]
        public System.Management.Automation.SwitchParameter webApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.webApp&quot; type.</para>
        ///     <para type="description">The web app URL.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;appUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;useManagedBrowser&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.webApp&quot; type.</para>
        ///     <para type="description">Whether or not to use managed browser. This property is only applicable for Android and IOS.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.webApp", HelpMessage = @"The &quot;useManagedBrowser&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean useManagedBrowser { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.microsoftStoreForBusinessApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.microsoftStoreForBusinessApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.microsoftStoreForBusinessApp&quot; type.")]
        public System.Management.Automation.SwitchParameter microsoftStoreForBusinessApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;productKey&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.microsoftStoreForBusinessApp&quot; type.</para>
        ///     <para type="description">The app product key</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;productKey&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String productKey { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licenseType&quot; property, of type &quot;microsoft.graph.microsoftStoreForBusinessLicenseType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.microsoftStoreForBusinessApp&quot; type.</para>
        ///     <para type="description">The app license type</para>
        ///     <para type="description">
        ///          Valid values: &apos;offline&apos;, &apos;online&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.microsoftStoreForBusinessLicenseType")]
        [Selectable]
        [ValidateSet(@"offline", @"online")]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;licenseType&quot; property, of type &quot;microsoft.graph.microsoftStoreForBusinessLicenseType&quot;.")]
        public System.String licenseType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;packageIdentityName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.microsoftStoreForBusinessApp&quot; type.</para>
        ///     <para type="description">The app package identifier</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.microsoftStoreForBusinessApp", HelpMessage = @"The &quot;packageIdentityName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String packageIdentityName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileLobApp&quot; type.</para>
        ///     <para type="description">The internal committed content version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;committedContentVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String committedContentVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileLobApp&quot; type.</para>
        ///     <para type="description">The name of the main Lob application file.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileLobApp&quot; type.</para>
        ///     <para type="description">The total size, including all uploaded files.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileLobApp&quot; type.</para>
        ///     <para type="description">The list of content versions for this app.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContent")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.mobileLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;contentVersions&quot; property, of type &quot;microsoft.graph.mobileAppContent&quot;.")]
        public System.Object[] contentVersions { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosLobApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iosLobApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosLobApp&quot; type.")]
        public System.Management.Automation.SwitchParameter iosLobApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosLobApp&quot; type.</para>
        ///     <para type="description">The expiration time.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versionNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosLobApp&quot; type.</para>
        ///     <para type="description">The version number of iOS Line of Business (LoB) app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;versionNumber&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;versionNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String versionNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;buildNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosLobApp&quot; type.</para>
        ///     <para type="description">The build number of iOS Line of Business (LoB) app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosLobApp", HelpMessage = @"The &quot;buildNumber&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;buildNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String buildNumber { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidLobApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.androidLobApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidLobApp&quot; type.")]
        public System.Management.Automation.SwitchParameter androidLobApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidLobApp&quot; type.</para>
        ///     <para type="description">The version name of Android Line of Business (LoB) app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;versionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;versionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String versionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;versionCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidLobApp&quot; type.</para>
        ///     <para type="description">The version code of Android Line of Business (LoB) app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.androidLobApp", HelpMessage = @"The &quot;versionCode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;versionCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String versionCode { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsUniversalAppX")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsUniversalAppX&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsUniversalAppX { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicableArchitectures&quot; property, of type &quot;microsoft.graph.windowsArchitecture&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The Windows architecture(s) for which this app can run on.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;x86&apos;, &apos;x64&apos;, &apos;arm&apos;, &apos;neutral&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsArchitecture")]
        [Selectable]
        [ValidateSet(@"none", @"x86", @"x64", @"arm", @"neutral")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;applicableArchitectures&quot; property, of type &quot;microsoft.graph.windowsArchitecture&quot;.")]
        public System.String applicableArchitectures { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicableDeviceTypes&quot; property, of type &quot;microsoft.graph.windowsDeviceType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The Windows device type(s) for which this app can run on.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;desktop&apos;, &apos;mobile&apos;, &apos;holographic&apos;, &apos;team&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.windowsDeviceType")]
        [Selectable]
        [ValidateSet(@"none", @"desktop", @"mobile", @"holographic", @"team")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;applicableDeviceTypes&quot; property, of type &quot;microsoft.graph.windowsDeviceType&quot;.")]
        public System.String applicableDeviceTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;identityName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The Identity Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;identityName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String identityName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;identityPublisherHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The Identity Publisher Hash.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;identityPublisherHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String identityPublisherHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;identityResourceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The Identity Resource Identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;identityResourceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String identityResourceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isBundle&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">Whether or not the app is a bundle.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;isBundle&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isBundle { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;identityVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsUniversalAppX&quot; type.</para>
        ///     <para type="description">The identity version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsUniversalAppX", HelpMessage = @"The &quot;identityVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String identityVersion { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsMobileMSI&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsMobileMSI")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsMobileMSI&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsMobileMSI { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;commandLine&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMobileMSI&quot; type.</para>
        ///     <para type="description">The command line.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;commandLine&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String commandLine { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;productCode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMobileMSI&quot; type.</para>
        ///     <para type="description">The product code.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;productCode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String productCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;productVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMobileMSI&quot; type.</para>
        ///     <para type="description">The product version of Windows Mobile MSI Line of Business (LoB) app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;productVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String productVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ignoreVersionDetection&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsMobileMSI&quot; type.</para>
        ///     <para type="description">A boolean to control whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsMobileMSI", HelpMessage = @"The &quot;ignoreVersionDetection&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ignoreVersionDetection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedApp&quot; type.</para>
        ///     <para type="description">The Application&apos;s availability.</para>
        ///     <para type="description">
        ///          Valid values: &apos;global&apos;, &apos;lineOfBusiness&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.managedAppAvailability")]
        [Selectable]
        [ValidateSet(@"global", @"lineOfBusiness")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;appAvailability&quot; property, of type &quot;microsoft.graph.managedAppAvailability&quot;.")]
        public System.String appAvailability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedApp&quot; type.</para>
        ///     <para type="description">The Application&apos;s version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileLobApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedIOSLobApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedIOSLobApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSLobApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedIOSLobApp&quot; type.")]
        public System.Management.Automation.SwitchParameter managedIOSLobApp { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAndroidLobApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedAndroidLobApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidLobApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAndroidLobApp&quot; type.")]
        public System.Management.Automation.SwitchParameter managedAndroidLobApp { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedIOSStoreApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedIOSStoreApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedIOSStoreApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedIOSStoreApp&quot; type.")]
        public System.Management.Automation.SwitchParameter managedIOSStoreApp { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAndroidStoreApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedAndroidStoreApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAndroidStoreApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAndroidStoreApp&quot; type.")]
        public System.Management.Automation.SwitchParameter managedAndroidStoreApp { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSOfficeSuiteApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.macOSOfficeSuiteApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.macOSOfficeSuiteApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.macOSOfficeSuiteApp&quot; type.")]
        public System.Management.Automation.SwitchParameter macOSOfficeSuiteApp { get; set; }
    }
}