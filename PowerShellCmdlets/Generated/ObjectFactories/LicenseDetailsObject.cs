// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.licenseDetails&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.licenseDetails&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "LicenseDetailsObject", DefaultParameterSetName = @"#microsoft.graph.licenseDetails")]
    [ODataType("microsoft.graph.licenseDetails")]
    public class New_LicenseDetailsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.servicePlanInfo")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseDetails", HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        public System.Object[] servicePlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseDetails", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid skuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseDetails", HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String skuPartNumber { get; set; }
    }
}