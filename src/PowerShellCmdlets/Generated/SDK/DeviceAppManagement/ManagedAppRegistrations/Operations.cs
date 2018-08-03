// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppOperation&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppOperation&quot; objects in the &quot;operations&quot; collection.</para>
    ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppRegistrations_Operations", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppOperation")]
    [ResourceIdPropertyName("OperationId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppRegistrations_Operations : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String OperationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The operation name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The last time the app operation was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The current state of the operation</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations/{OperationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedAppOperation&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedAppOperation&quot; object to the &quot;operations&quot; collection.</para>
    ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppRegistrations_Operations", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.managedAppOperation")]
    [ODataType("microsoft.graph.managedAppOperation")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppRegistrations_Operations : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The operation name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The last time the app operation was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The current state of the operation</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedAppOperation&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.</para>
    ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppRegistrations_Operations", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.managedAppOperation")]
    [ODataType("microsoft.graph.managedAppOperation")]
    [ResourceIdPropertyName("OperationId")]
    public class Update_DeviceAppManagement_ManagedAppRegistrations_Operations : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String OperationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The operation name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The last time the app operation was modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">The current state of the operation</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppOperation&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppOperation", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations/{OperationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedAppOperation&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations/OperationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedAppOperation&quot; object from the &quot;operations&quot; collection.</para>
    ///     <para type="description">Zero or more long running operations triggered on the app registration.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppRegistrations_Operations", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppOperation")]
    [ResourceIdPropertyName("OperationId")]
    public class Remove_DeviceAppManagement_ManagedAppRegistrations_Operations : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppOperation&quot; object in the &quot;operations&quot; collection.")]
        public System.String OperationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String ManagedAppRegistrationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{ManagedAppRegistrationId}/operations/{OperationId}";
        }
    }
}