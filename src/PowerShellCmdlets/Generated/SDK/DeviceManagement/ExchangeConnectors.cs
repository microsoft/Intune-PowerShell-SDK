// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceManagementExchangeConnector&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/exchangeConnectors</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceManagementExchangeConnector&quot; objects in the &quot;exchangeConnectors&quot; collection.</para>
    ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_ExchangeConnectors", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    [ResourceIdPropertyName("exchangeConnectorId")]
    [ResourceReference]
    public class Get_DeviceManagement_ExchangeConnectors : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.")]
        public System.String exchangeConnectorId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Last sync time for the Exchange Connector</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Connector Status</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorStatus")]
        [Selectable]
        [Sortable]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Email address used to configure the Service To Service Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String primarySmtpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The name of the server hosting the Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String serverName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The type of Exchange Connector Configured.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorType")]
        [Selectable]
        [Sortable]
        public System.String exchangeConnectorType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The version of the ExchangeConnectorAgent</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">An alias assigned to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String exchangeAlias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Organization to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String exchangeOrganization { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/exchangeConnectors/{exchangeConnectorId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/exchangeConnectors</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object to the &quot;exchangeConnectors&quot; collection.</para>
    ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_ExchangeConnectors", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector")]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    [ResourceReference]
    public class New_DeviceManagement_ExchangeConnectors : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Last sync time for the Exchange Connector</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Connector Status</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;connectionPending&apos;, &apos;connected&apos;, &apos;disconnected&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorStatus")]
        [Selectable]
        [ValidateSet(@"none", @"connectionPending", @"connected", @"disconnected")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Email address used to configure the Service To Service Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String primarySmtpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The name of the server hosting the Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String serverName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The type of Exchange Connector Configured.</para>
        ///     <para type="description">
        ///          Valid values: &apos;onPremises&apos;, &apos;hosted&apos;, &apos;serviceToService&apos;, &apos;dedicated&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorType")]
        [Selectable]
        [ValidateSet(@"onPremises", @"hosted", @"serviceToService", @"dedicated")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.")]
        public System.String exchangeConnectorType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The version of the ExchangeConnectorAgent</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">An alias assigned to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeAlias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Organization to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeOrganization { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/exchangeConnectors";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/exchangeConnectors</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.</para>
    ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_ExchangeConnectors", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector")]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    [ResourceIdPropertyName("exchangeConnectorId")]
    public class Update_DeviceManagement_ExchangeConnectors : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.")]
        public System.String exchangeConnectorId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Last sync time for the Exchange Connector</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Connector Status</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;connectionPending&apos;, &apos;connected&apos;, &apos;disconnected&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorStatus")]
        [Selectable]
        [ValidateSet(@"none", @"connectionPending", @"connected", @"disconnected")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Email address used to configure the Service To Service Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String primarySmtpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The name of the server hosting the Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String serverName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The type of Exchange Connector Configured.</para>
        ///     <para type="description">
        ///          Valid values: &apos;onPremises&apos;, &apos;hosted&apos;, &apos;serviceToService&apos;, &apos;dedicated&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorType")]
        [Selectable]
        [ValidateSet(@"onPremises", @"hosted", @"serviceToService", @"dedicated")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeConnectorType&quot; property, of type &quot;microsoft.graph.deviceManagementExchangeConnectorType&quot;.")]
        public System.String exchangeConnectorType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The version of the ExchangeConnectorAgent</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">An alias assigned to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeAlias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Organization to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeOrganization { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/exchangeConnectors/{exchangeConnectorId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/exchangeConnectors/exchangeConnectorId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object from the &quot;exchangeConnectors&quot; collection.</para>
    ///     <para type="description">The list of Exchange Connectors configured by the tenant.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_ExchangeConnectors", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    [ResourceIdPropertyName("exchangeConnectorId")]
    public class Remove_DeviceManagement_ExchangeConnectors : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.")]
        public System.String exchangeConnectorId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/exchangeConnectors/{exchangeConnectorId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceManagement/exchangeConnectors/sync</para>
    ///     <para type="description">The action &quot;microsoft.graph.sync&quot;, which exists on the type &quot;microsoft.graph.deviceManagementExchangeConnector&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceManagement_ExchangeConnectors_Sync", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    [ResourceIdPropertyName("exchangeConnectorId")]
    public class Invoke_DeviceManagement_ExchangeConnectors_Sync : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;syncType&quot; parameter, which is accepted by the &quot;microsoft.graph.sync&quot; action.</para>
        ///     <para type="description">
        ///          Valid values: &apos;fullSync&apos;, &apos;deltaSync&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceManagementExchangeConnectorSyncType")]
        [Selectable]
        [ValidateSet(@"fullSync", @"deltaSync")]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;syncType&quot; parameter, which is accepted by the &quot;microsoft.graph.sync&quot; action.")]
        public System.String syncType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; object in the &quot;exchangeConnectors&quot; collection.")]
        public System.String exchangeConnectorId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/exchangeConnectors/{exchangeConnectorId}/sync";
        }
    }
}