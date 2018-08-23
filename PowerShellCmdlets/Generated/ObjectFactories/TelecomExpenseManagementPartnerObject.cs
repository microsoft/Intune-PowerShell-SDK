// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.telecomExpenseManagementPartner&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">telecomExpenseManagementPartner resources represent the metadata and status of a given TEM service. Once your organization has onboarded with a partner, the partner can be enabled or disabled to switch TEM functionality on or off.</para>
    /// </summary>
    [Cmdlet("New", "TelecomExpenseManagementPartnerObject", DefaultParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner")]
    [ODataType("microsoft.graph.telecomExpenseManagementPartner")]
    public class New_TelecomExpenseManagementPartnerObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Display name of the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">URL of the TEM partner&apos;s administrative control panel, where an administrator can configure their TEM service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether the partner&apos;s AAD app has been authorized to access Intune.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;appAuthorized&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean appAuthorized { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Whether Intune&apos;s connection to the TEM service is currently enabled or disabled.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.telecomExpenseManagementPartner&quot; type.</para>
        ///     <para type="description">Timestamp of the last request sent to Intune by the TEM partner.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.telecomExpenseManagementPartner", HelpMessage = @"The &quot;lastConnectionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastConnectionDateTime { get; set; }
    }
}