// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.detectedApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.detectedApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">A managed or unmanaged app that is installed on a managed device. Unmanaged apps will only appear for devices marked as corporate owned.</para>
    /// </summary>
    [Cmdlet("New", "DetectedAppObject", DefaultParameterSetName = @"#microsoft.graph.detectedApp")]
    [ODataType("microsoft.graph.detectedApp")]
    public class New_DetectedAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Name of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.detectedApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Version of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.detectedApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Discovered application size in bytes. Read-only</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.detectedApp", HelpMessage = @"The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 SizeInByte { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The number of devices that have installed this application</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.detectedApp", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 DeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The devices that have the discovered application installed</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.detectedApp", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] ManagedDevices { get; set; }
    }
}