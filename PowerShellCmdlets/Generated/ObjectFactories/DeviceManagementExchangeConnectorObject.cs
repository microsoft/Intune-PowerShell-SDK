// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceManagementExchangeConnector&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Entity which represents a connection to an Exchange environment.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagementExchangeConnectorObject", DefaultParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector")]
    [ODataType("microsoft.graph.deviceManagementExchangeConnector")]
    public class New_DeviceManagementExchangeConnectorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Last sync time for the Exchange Connector</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
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
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Email address used to configure the Service To Service Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;primarySmtpAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String primarySmtpAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The name of the server hosting the Exchange Connector.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;serverName&quot; property, of type &quot;Edm.String&quot;.")]
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
        public System.String exchangeConnectorType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">The version of the ExchangeConnectorAgent</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">An alias assigned to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeAlias&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeAlias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementExchangeConnector&quot; type.</para>
        ///     <para type="description">Exchange Organization to the Exchange server</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementExchangeConnector", HelpMessage = @"The &quot;exchangeOrganization&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String exchangeOrganization { get; set; }
    }
}