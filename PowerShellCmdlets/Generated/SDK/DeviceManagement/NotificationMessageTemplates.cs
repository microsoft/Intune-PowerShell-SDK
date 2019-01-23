// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.notificationMessageTemplate&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.notificationMessageTemplate&quot; objects in the &quot;notificationMessageTemplates&quot; collection.</para>
    ///     <para type="description">The Notification Message Templates.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/notificationMessageTemplates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneNotificationMessageTemplate", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    [ResourceTypePropertyName("notificationMessageTemplateODataType")]
    [ResourceReference]
    public class Get_IntuneNotificationMessageTemplate : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">Display name for the Notification Message Template.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The default locale to fallback onto when the requested locale is not available.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String defaultLocale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The Message Template Branding Options. Branding is defined in the Intune Admin Console.</para>
        /// </summary>
        [ODataType("microsoft.graph.notificationTemplateBrandingOptions")]
        [Selectable]
        [Sortable]
        public System.String brandingOptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
        /// </summary>
        [ODataType("microsoft.graph.localizedNotificationMessage")]
        [Selectable]
        [Expandable]
        public System.Object[] localizedNotificationMessages { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.notificationMessageTemplate&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.notificationMessageTemplate&quot; object to the &quot;notificationMessageTemplates&quot; collection.</para>
    ///     <para type="description">The Notification Message Templates.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/notificationMessageTemplates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneNotificationMessageTemplate", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.notificationMessageTemplate")]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    [ResourceTypePropertyName("notificationMessageTemplateODataType")]
    [ResourceReference]
    public class New_IntuneNotificationMessageTemplate : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">Display name for the Notification Message Template.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The default locale to fallback onto when the requested locale is not available.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.")]
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
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.")]
        public System.String brandingOptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
        /// </summary>
        [ODataType("microsoft.graph.localizedNotificationMessage")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.")]
        public System.Object[] localizedNotificationMessages { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.notificationMessageTemplate&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
    ///     <para type="description">The Notification Message Templates.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/notificationMessageTemplates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneNotificationMessageTemplate", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.notificationMessageTemplate")]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    [ResourceTypePropertyName("notificationMessageTemplateODataType")]
    public class Update_IntuneNotificationMessageTemplate : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">Display name for the Notification Message Template.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The default locale to fallback onto when the requested locale is not available.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;defaultLocale&quot; property, of type &quot;Edm.String&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;brandingOptions&quot; property, of type &quot;microsoft.graph.notificationTemplateBrandingOptions&quot;.")]
        public System.String brandingOptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.notificationMessageTemplate&quot; type.</para>
        ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
        /// </summary>
        [ODataType("microsoft.graph.localizedNotificationMessage")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.notificationMessageTemplate", HelpMessage = @"The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;localizedNotificationMessages&quot; property, of type &quot;microsoft.graph.localizedNotificationMessage&quot;.")]
        public System.Object[] localizedNotificationMessages { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.notificationMessageTemplate&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.notificationMessageTemplate&quot; object from the &quot;notificationMessageTemplates&quot; collection.</para>
    ///     <para type="description">The Notification Message Templates.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/notificationMessageTemplates/notificationMessageTemplateId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneNotificationMessageTemplate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    [ResourceTypePropertyName("notificationMessageTemplateODataType")]
    public class Remove_IntuneNotificationMessageTemplate : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}";
        }
    }

    /// <summary>
    ///     <para type="description">The action &quot;microsoft.graph.sendTestMessage&quot;, which exists on the type &quot;microsoft.graph.notificationMessageTemplate&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    ///     <para type="description">Graph Call: POST ~/deviceManagement/notificationMessageTemplates/sendTestMessage</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "IntuneSendTestMessage", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.notificationMessageTemplate")]
    [ResourceTypePropertyName("notificationMessageTemplateODataType")]
    public class Invoke_IntuneSendTestMessage : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/sendTestMessage";
        }
    }
}