// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.subscribedSku&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.subscribedSku&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SubscribedSkuObject", DefaultParameterSetName = @"#microsoft.graph.subscribedSku")]
    [ODataType("microsoft.graph.subscribedSku")]
    public class New_SubscribedSkuObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CapabilityStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;consumedUnits&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;consumedUnits&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConsumedUnits { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;prepaidUnits&quot; property, of type &quot;microsoft.graph.licenseUnitsDetail&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.licenseUnitsDetail")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;prepaidUnits&quot; property, of type &quot;microsoft.graph.licenseUnitsDetail&quot;.")]
        public System.Object PrepaidUnits { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.servicePlanInfo")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        public System.Object[] ServicePlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid SkuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String SkuPartNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appliesTo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.subscribedSku&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.subscribedSku", HelpMessage = @"The &quot;appliesTo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppliesTo { get; set; }
    }
}