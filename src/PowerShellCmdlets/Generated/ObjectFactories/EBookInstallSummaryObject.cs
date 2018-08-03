// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.eBookInstallSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.eBookInstallSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Contains properties for the installation summary of a book for a device.</para>
    /// </summary>
    [Cmdlet("New", "EBookInstallSummaryObject", DefaultParameterSetName = @"#microsoft.graph.eBookInstallSummary")]
    [ODataType("microsoft.graph.eBookInstallSummary")]
    public class New_EBookInstallSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have successfully installed this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 InstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that have failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Devices that does not have this book installed.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotInstalledDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users whose devices have all succeeded to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;installedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 InstalledUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that have 1 or more device that failed to install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;failedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 FailedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.eBookInstallSummary&quot; type.</para>
        ///     <para type="description">Number of Users that did not install this book.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.eBookInstallSummary", HelpMessage = @"The &quot;notInstalledUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotInstalledUserCount { get; set; }
    }
}