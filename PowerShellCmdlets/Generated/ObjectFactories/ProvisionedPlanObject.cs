// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.provisionedPlan&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.provisionedPlan&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ProvisionedPlanObject", DefaultParameterSetName = @"microsoft.graph.provisionedPlan")]
    [ODataType("microsoft.graph.provisionedPlan")]
    public class New_ProvisionedPlanObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.provisionedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.provisionedPlan", HelpMessage = @"The &quot;capabilityStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String capabilityStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;provisioningStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.provisionedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.provisionedPlan", HelpMessage = @"The &quot;provisioningStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String provisioningStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;service&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.provisionedPlan&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.provisionedPlan", HelpMessage = @"The &quot;service&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String service { get; set; }
    }
}