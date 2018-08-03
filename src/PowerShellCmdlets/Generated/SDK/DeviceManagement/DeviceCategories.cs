// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceCategory&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/deviceCategories</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceCategory&quot; objects in the &quot;deviceCategories&quot; collection.</para>
    ///     <para type="description">The list of device categories with the tenant.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_DeviceCategories", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceIdPropertyName("DeviceCategoryId")]
    [ResourceReference]
    public class Get_DeviceManagement_DeviceCategories : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.")]
        public System.String DeviceCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCategories/{DeviceCategoryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCategory&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/deviceCategories</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceCategory&quot; object to the &quot;deviceCategories&quot; collection.</para>
    ///     <para type="description">The list of device categories with the tenant.</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_DeviceCategories", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceCategory")]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceReference]
    public class New_DeviceManagement_DeviceCategories : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCategories";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCategory&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/deviceCategories</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.</para>
    ///     <para type="description">The list of device categories with the tenant.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_DeviceCategories", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceCategory")]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceIdPropertyName("DeviceCategoryId")]
    public class Update_DeviceManagement_DeviceCategories : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.")]
        public System.String DeviceCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCategories/{DeviceCategoryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCategory&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/deviceCategories/DeviceCategoryId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceCategory&quot; object from the &quot;deviceCategories&quot; collection.</para>
    ///     <para type="description">The list of device categories with the tenant.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_DeviceCategories", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceIdPropertyName("DeviceCategoryId")]
    public class Remove_DeviceManagement_DeviceCategories : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceCategory&quot; object in the &quot;deviceCategories&quot; collection.")]
        public System.String DeviceCategoryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCategories/{DeviceCategoryId}";
        }
    }
}