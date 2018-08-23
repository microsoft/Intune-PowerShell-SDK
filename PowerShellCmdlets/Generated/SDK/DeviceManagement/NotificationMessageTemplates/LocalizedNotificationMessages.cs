// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.localizedNotificationMessage&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.localizedNotificationMessage&quot; objects in the &quot;localizedNotificationMessages&quot; collection.</para>
    ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.localizedNotificationMessage")]
    [ResourceTypePropertyName("localizedNotificationMessageODataType")]
    [ResourceIdPropertyName("localizedNotificationMessageId")]
    [ResourceReference]
    public class Get_DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.")]
        public System.String localizedNotificationMessageId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Locale for which this message is destined.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String locale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template Subject.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template content.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String messageTemplate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isDefault { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages/{localizedNotificationMessageId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.localizedNotificationMessage&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.localizedNotificationMessage&quot; object to the &quot;localizedNotificationMessages&quot; collection.</para>
    ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.localizedNotificationMessage")]
    [ODataType("microsoft.graph.localizedNotificationMessage")]
    [ResourceTypePropertyName("localizedNotificationMessageODataType")]
    [ResourceIdPropertyName("localizedNotificationMessageId")]
    [ResourceReference]
    public class New_DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String localizedNotificationMessageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Locale for which this message is destined.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String locale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template Subject.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template content.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String messageTemplate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages/{localizedNotificationMessageId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.localizedNotificationMessage&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.</para>
    ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.localizedNotificationMessage")]
    [ODataType("microsoft.graph.localizedNotificationMessage")]
    [ResourceTypePropertyName("localizedNotificationMessageODataType")]
    [ResourceIdPropertyName("localizedNotificationMessageId")]
    public class Update_DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.")]
        public System.String localizedNotificationMessageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Locale for which this message is destined.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String locale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template Subject.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template content.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String messageTemplate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages/{localizedNotificationMessageId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.localizedNotificationMessage&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages/localizedNotificationMessageId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.localizedNotificationMessage&quot; object from the &quot;localizedNotificationMessages&quot; collection.</para>
    ///     <para type="description">The list of localized messages for this Notification Message Template.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.localizedNotificationMessage")]
    [ResourceTypePropertyName("localizedNotificationMessageODataType")]
    [ResourceIdPropertyName("localizedNotificationMessageId")]
    public class Remove_DeviceManagement_NotificationMessageTemplates_LocalizedNotificationMessages : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.localizedNotificationMessage&quot; object in the &quot;localizedNotificationMessages&quot; collection.")]
        public System.String localizedNotificationMessageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notificationMessageTemplate&quot; object in the &quot;notificationMessageTemplates&quot; collection.")]
        public System.String notificationMessageTemplateId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/notificationMessageTemplates/{notificationMessageTemplateId}/localizedNotificationMessages/{localizedNotificationMessageId}";
        }
    }
}