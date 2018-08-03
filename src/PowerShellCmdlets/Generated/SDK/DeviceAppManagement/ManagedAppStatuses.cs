// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedAppStatus&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppStatuses</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedAppStatus&quot; objects in the &quot;managedAppStatuses&quot; collection.</para>
    ///     <para type="description">The managed app statuses.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppStatuses", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedAppStatus")]
    [ResourceIdPropertyName("ManagedAppStatusId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppStatuses : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.")]
        public System.String ManagedAppStatusId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Friendly name of the status report.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        ///     <para type="description">Status report content.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.managedAppStatusRaw")]
        public System.Object Content { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppStatuses/{ManagedAppStatusId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedAppStatus&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppStatuses</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedAppStatus&quot; object to the &quot;managedAppStatuses&quot; collection.</para>
    ///     <para type="description">The managed app statuses.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppStatuses", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedAppStatus")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppStatuses : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Friendly name of the status report.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedAppStatusRaw")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.")]
        public System.Management.Automation.SwitchParameter ManagedAppStatusRaw { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        ///     <para type="description">Status report content.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object Content { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppStatuses";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedAppStatus&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppStatuses</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.</para>
    ///     <para type="description">The managed app statuses.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppStatuses", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.managedAppStatus")]
    [ResourceIdPropertyName("ManagedAppStatusId")]
    public class Update_DeviceAppManagement_ManagedAppStatuses : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.")]
        public System.String ManagedAppStatusId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Friendly name of the status report.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatus&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatus", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.managedAppStatusRaw")]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.managedAppStatusRaw&quot; type.")]
        public System.Management.Automation.SwitchParameter ManagedAppStatusRaw { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppStatusRaw&quot; type.</para>
        ///     <para type="description">Status report content.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppStatusRaw", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object Content { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppStatuses/{ManagedAppStatusId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedAppStatus&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppStatuses/ManagedAppStatusId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedAppStatus&quot; object from the &quot;managedAppStatuses&quot; collection.</para>
    ///     <para type="description">The managed app statuses.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppStatuses", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedAppStatus")]
    [ResourceIdPropertyName("ManagedAppStatusId")]
    public class Remove_DeviceAppManagement_ManagedAppStatuses : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedAppStatus&quot; object in the &quot;managedAppStatuses&quot; collection.")]
        public System.String ManagedAppStatusId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppStatuses/{ManagedAppStatusId}";
        }
    }
}