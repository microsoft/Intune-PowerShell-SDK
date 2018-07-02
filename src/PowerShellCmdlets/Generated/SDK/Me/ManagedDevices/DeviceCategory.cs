// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;deviceCategory&quot; object.</para>
    ///     <para type="description">GET ~/me/managedDevices/{managedDeviceId}/deviceCategory</para>
    ///     <para type="description">Retrieves the &quot;deviceCategory&quot; object (which is of type &quot;microsoft.graph.deviceCategory&quot;).</para>
    ///     <para type="description">Device category</para>
    /// </summary>
    [Cmdlet("Get", "Me_ManagedDevices_DeviceCategory", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceReference]
    public class Get_Me_ManagedDevices_DeviceCategory : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedDevices/{managedDeviceId}/deviceCategory";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceCategory&quot; object.</para>
    ///     <para type="description">POST ~/me/managedDevices/{managedDeviceId}/deviceCategory</para>
    ///     <para type="description">Creates the &quot;deviceCategory&quot; object (which is of type &quot;microsoft.graph.deviceCategory&quot;).</para>
    ///     <para type="description">Device category</para>
    /// </summary>
    [Cmdlet("New", "Me_ManagedDevices_DeviceCategory", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.deviceCategory")]
    [ODataType("microsoft.graph.deviceCategory")]
    [ResourceReference]
    public class New_Me_ManagedDevices_DeviceCategory : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedDevices/{managedDeviceId}/deviceCategory";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceCategory&quot;.</para>
    ///     <para type="description">PATCH ~/me/managedDevices/{managedDeviceId}/deviceCategory</para>
    ///     <para type="description">Updates the &quot;deviceCategory&quot; object (which is of type &quot;microsoft.graph.deviceCategory&quot;).</para>
    ///     <para type="description">Device category</para>
    /// </summary>
    [Cmdlet("Update", "Me_ManagedDevices_DeviceCategory", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.deviceCategory")]
    [ODataType("microsoft.graph.deviceCategory")]
    public class Update_Me_ManagedDevices_DeviceCategory : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Display name for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceCategory&quot; type.</para>
        ///     <para type="description">Optional description for the device category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceCategory", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedDevices/{managedDeviceId}/deviceCategory";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceCategory&quot; object.</para>
    ///     <para type="description">DELETE ~/me/managedDevices/{managedDeviceId}/deviceCategory</para>
    ///     <para type="description">Removes the &quot;deviceCategory&quot; object (which is of type &quot;microsoft.graph.deviceCategory&quot;).</para>
    ///     <para type="description">Device category</para>
    /// </summary>
    [Cmdlet("Remove", "Me_ManagedDevices_DeviceCategory", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceCategory")]
    public class Remove_Me_ManagedDevices_DeviceCategory : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedDevice&quot; object in the &quot;managedDevices&quot; collection.")]
        public System.String managedDeviceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/managedDevices/{managedDeviceId}/deviceCategory";
        }
    }
}