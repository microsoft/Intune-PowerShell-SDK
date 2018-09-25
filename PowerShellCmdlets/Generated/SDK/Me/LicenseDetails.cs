// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.licenseDetails&quot; objects.</para>
    ///     <para type="description">GET ~/me/licenseDetails</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.licenseDetails&quot; objects in the &quot;licenseDetails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_LicenseDetails", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.licenseDetails")]
    [ResourceTypePropertyName("licenseDetailODataType")]
    [ResourceReference]
    public class Get_Me_LicenseDetails : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.")]
        public System.String licenseDetailId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.servicePlanInfo")]
        [Selectable]
        public System.Object[] servicePlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Sortable]
        public System.Guid skuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String skuPartNumber { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/licenseDetails/{licenseDetailId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.licenseDetails&quot; object.</para>
    ///     <para type="description">POST ~/me/licenseDetails</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.licenseDetails&quot; object to the &quot;licenseDetails&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_LicenseDetails", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.licenseDetails")]
    [ODataType("microsoft.graph.licenseDetails")]
    [ResourceTypePropertyName("licenseDetailODataType")]
    [ResourceReference]
    public class New_Me_LicenseDetails : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String licenseDetailId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.servicePlanInfo")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        public System.Object[] servicePlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid skuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String skuPartNumber { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/licenseDetails/{licenseDetailId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.licenseDetails&quot;.</para>
    ///     <para type="description">PATCH ~/me/licenseDetails</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_LicenseDetails", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.licenseDetails")]
    [ODataType("microsoft.graph.licenseDetails")]
    [ResourceTypePropertyName("licenseDetailODataType")]
    public class Update_Me_LicenseDetails : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.")]
        public System.String licenseDetailId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.servicePlanInfo")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;servicePlans&quot; property, of type &quot;microsoft.graph.servicePlanInfo&quot;.")]
        public System.Object[] servicePlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid skuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseDetails", HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;skuPartNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String skuPartNumber { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/licenseDetails/{licenseDetailId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.licenseDetails&quot; object.</para>
    ///     <para type="description">DELETE ~/me/licenseDetails/licenseDetailId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.licenseDetails&quot; object from the &quot;licenseDetails&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_LicenseDetails", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.licenseDetails")]
    [ResourceTypePropertyName("licenseDetailODataType")]
    public class Remove_Me_LicenseDetails : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.licenseDetails&quot; object in the &quot;licenseDetails&quot; collection.")]
        public System.String licenseDetailId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/licenseDetails/{licenseDetailId}";
        }
    }
}