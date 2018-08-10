// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.telecomExpenseManagementPartner&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/telecomExpenseManagementPartners</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.telecomExpenseManagementPartner&quot; objects in the &quot;telecomExpenseManagementPartners&quot; collection.</para>
    ///     <para type="description">The telecom expense management partners.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_TelecomExpenseManagementPartners", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
    [ResourceIdPropertyName("telecomExpenseManagementPartnerId")]
    [ResourceReference]
    public class Get_DeviceManagement_TelecomExpenseManagementPartners : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.")]
        public System.String telecomExpenseManagementPartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Display name of the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">URL of the TEM partner&apos;s administrative control panel, where an administrator can configure their TEM service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether the partner&apos;s AAD app has been authorized to access Intune.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean appAuthorized { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether Intune&apos;s connection to the TEM service is currently enabled or disabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/telecomExpenseManagementPartners/{telecomExpenseManagementPartnerId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/telecomExpenseManagementPartners</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object to the &quot;telecomExpenseManagementPartners&quot; collection.</para>
    ///     <para type="description">The telecom expense management partners.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_TelecomExpenseManagementPartners", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner")]
    [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
    [ResourceReference]
    public class New_DeviceManagement_TelecomExpenseManagementPartners : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Display name of the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">URL of the TEM partner&apos;s administrative control panel, where an administrator can configure their TEM service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether the partner&apos;s AAD app has been authorized to access Intune.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean appAuthorized { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether Intune&apos;s connection to the TEM service is currently enabled or disabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/telecomExpenseManagementPartners";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.telecomExpenseManagementPartner&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/telecomExpenseManagementPartners</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.</para>
    ///     <para type="description">The telecom expense management partners.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_TelecomExpenseManagementPartners", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner")]
    [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
    [ResourceIdPropertyName("telecomExpenseManagementPartnerId")]
    public class Update_DeviceManagement_TelecomExpenseManagementPartners : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.")]
        public System.String telecomExpenseManagementPartnerId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Display name of the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">URL of the TEM partner&apos;s administrative control panel, where an administrator can configure their TEM service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether the partner&apos;s AAD app has been authorized to access Intune.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean appAuthorized { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether Intune&apos;s connection to the TEM service is currently enabled or disabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/telecomExpenseManagementPartners/{telecomExpenseManagementPartnerId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/telecomExpenseManagementPartners/telecomExpenseManagementPartnerId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object from the &quot;telecomExpenseManagementPartners&quot; collection.</para>
    ///     <para type="description">The telecom expense management partners.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_TelecomExpenseManagementPartners", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
    [ResourceIdPropertyName("telecomExpenseManagementPartnerId")]
    public class Remove_DeviceManagement_TelecomExpenseManagementPartners : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; object in the &quot;telecomExpenseManagementPartners&quot; collection.")]
        public System.String telecomExpenseManagementPartnerId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/telecomExpenseManagementPartners/{telecomExpenseManagementPartnerId}";
        }
    }
}