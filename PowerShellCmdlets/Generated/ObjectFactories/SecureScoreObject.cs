// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.secureScore&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.secureScore&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SecureScoreObject", DefaultParameterSetName = @"microsoft.graph.secureScore")]
    [ODataType("microsoft.graph.secureScore")]
    public class New_SecureScoreObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;activeUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;activeUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 activeUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;averageComparativeScores&quot; property, of type &quot;microsoft.graph.averageComparativeScore&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.averageComparativeScore")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;averageComparativeScores&quot; property, of type &quot;microsoft.graph.averageComparativeScore&quot;.")]
        public System.Object[] averageComparativeScores { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;azureTenantId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String azureTenantId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;controlScores&quot; property, of type &quot;microsoft.graph.controlScore&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.controlScore")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;controlScores&quot; property, of type &quot;microsoft.graph.controlScore&quot;.")]
        public System.Object[] controlScores { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;currentScore&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;currentScore&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double currentScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabledServices&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;enabledServices&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] enabledServices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;licensedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;licensedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 licensedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maxScore&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;maxScore&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double maxScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScore&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.securityVendorInformation")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScore", HelpMessage = @"The &quot;vendorInformation&quot; property, of type &quot;microsoft.graph.securityVendorInformation&quot;.")]
        public System.Object vendorInformation { get; set; }
    }
}