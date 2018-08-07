// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;installSummary&quot; object.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedEBooks/{managedEBookId}/installSummary</para>
    ///     <para type="description">Retrieves the &quot;installSummary&quot; object (which is of type &quot;microsoft.graph.eBookInstallSummary&quot;).</para>
    ///     <para type="description">Mobile App Install Summary.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedEBooks_InstallSummary", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.eBookInstallSummary")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedEBooks_InstallSummary : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have successfully installed this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that does not have this book installed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users whose devices have all succeeded to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 installedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that have 1 or more device that failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 failedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that did not install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 notInstalledUserCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/installSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.eBookInstallSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedEBooks/{managedEBookId}/installSummary</para>
    ///     <para type="description">Creates the &quot;installSummary&quot; object (which is of type &quot;microsoft.graph.eBookInstallSummary&quot;).</para>
    ///     <para type="description">Mobile App Install Summary.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedEBooks_InstallSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.eBookInstallSummary")]
    [ODataType("microsoft.graph.eBookInstallSummary")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedEBooks_InstallSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have successfully installed this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that does not have this book installed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users whose devices have all succeeded to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that have 1 or more device that failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that did not install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledUserCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/installSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.eBookInstallSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedEBooks/{managedEBookId}/installSummary</para>
    ///     <para type="description">Updates the &quot;installSummary&quot; object (which is of type &quot;microsoft.graph.eBookInstallSummary&quot;).</para>
    ///     <para type="description">Mobile App Install Summary.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedEBooks_InstallSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.eBookInstallSummary")]
    [ODataType("microsoft.graph.eBookInstallSummary")]
    public class Update_DeviceAppManagement_ManagedEBooks_InstallSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have successfully installed this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that does not have this book installed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users whose devices have all succeeded to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 installedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that have 1 or more device that failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 failedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that did not install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 notInstalledUserCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/installSummary";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.eBookInstallSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedEBooks/{managedEBookId}/installSummary</para>
    ///     <para type="description">Removes the &quot;installSummary&quot; object (which is of type &quot;microsoft.graph.eBookInstallSummary&quot;).</para>
    ///     <para type="description">Mobile App Install Summary.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedEBooks_InstallSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.eBookInstallSummary")]
    public class Remove_DeviceAppManagement_ManagedEBooks_InstallSummary : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedEBook&quot; object in the &quot;managedEBooks&quot; collection.")]
        public System.String managedEBookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedEBooks/{managedEBookId}/installSummary";
        }
    }
}