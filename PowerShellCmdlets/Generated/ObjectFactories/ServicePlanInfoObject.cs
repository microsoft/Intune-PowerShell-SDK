// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.servicePlanInfo&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.servicePlanInfo&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ServicePlanInfoObject", DefaultParameterSetName = @"microsoft.graph.servicePlanInfo")]
    [ODataType("microsoft.graph.servicePlanInfo")]
    public class New_ServicePlanInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;servicePlanId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.servicePlanInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.servicePlanInfo", HelpMessage = @"The &quot;servicePlanId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid servicePlanId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlanName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.servicePlanInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.servicePlanInfo", HelpMessage = @"The &quot;servicePlanName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String servicePlanName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisioningStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.servicePlanInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.servicePlanInfo", HelpMessage = @"The &quot;provisioningStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String provisioningStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliesTo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.servicePlanInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.servicePlanInfo", HelpMessage = @"The &quot;appliesTo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appliesTo { get; set; }
    }
}