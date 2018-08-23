// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.notificationMessageTemplate&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.notificationMessageTemplate&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Notification messages are messages that are sent to end users who are determined to be not-compliant with the compliance policies defined by the administrator. Administrators choose notifications and configure them in the Intune Admin Console using the compliance policy creation page under the “Actions for non-compliance” section. Use the notificationMessageTemplate object to create your own custom notifications for administrators to choose while configuring actions for non-compliance.</para>
    /// </summary>
    [Cmdlet("New", "NotificationMessageTemplateObject", DefaultParameterSetName = @"microsoft.graph.notificationMessageTemplate")]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    public class New_NotificationMessageTemplateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">Display name for the Notification Message Template.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The default locale to fallback onto when the requested locale is not available.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String defaultLocale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The Message Template Branding Options. Branding is defined in the Intune Admin Console.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;includeCompanyLogo&apos;, &apos;includeCompanyName&apos;, &apos;includeContactInformation&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.notificationTemplateBrandingOptions")]
        [Selectable]
        [ValidateSet(@"none", @"includeCompanyLogo", @"includeCompanyName", @"includeContactInformation")]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.")]
        public System.String brandingOptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
        /// </summary>
        [ODataType("microsoft.graph.localizedNotificationMessage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.")]
        public System.Object[] localizedNotificationMessages { get; set; }
    }
}