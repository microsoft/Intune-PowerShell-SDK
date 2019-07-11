// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.secureScoreControlProfile&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.secureScoreControlProfile&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SecureScoreControlProfileObject", DefaultParameterSetName = @"microsoft.graph.secureScoreControlProfile")]
    [ODataType("microsoft.graph.secureScoreControlProfile")]
    public class New_SecureScoreControlProfileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;actionType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;actionType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;actionUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureTenantId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceInformation&quot; property, of type &quot;microsoft.graph.complianceInformation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceInformation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;complianceInformation&quot; property, of type &quot;microsoft.graph.complianceInformation&quot;.")]
        public System.Object[] complianceInformation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;controlCategory&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;controlCategory&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String controlCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;controlStateUpdates&quot; property, of type &quot;microsoft.graph.secureScoreControlStateUpdate&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.secureScoreControlStateUpdate")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;controlStateUpdates&quot; property, of type &quot;microsoft.graph.secureScoreControlStateUpdate&quot;.")]
        public System.Object[] controlStateUpdates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deprecated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;deprecated&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean deprecated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;implementationCost&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;implementationCost&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String implementationCost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maxScore&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;maxScore&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double maxScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rank&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;rank&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 rank { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;remediation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String remediation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediationImpact&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;remediationImpact&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String remediationImpact { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;service&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;service&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String service { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;threats&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;threats&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] threats { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;tier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String tier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userImpact&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;userImpact&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userImpact { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlProfile&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.securityVendorInformation")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlProfile", HelpMessage = @"The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.")]
        public System.Object vendorInformation { get; set; }
    }
}