// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceOperatingSystemSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceOperatingSystemSummary&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceOperatingSystemSummaryObject", DefaultParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary")]
    [ODataType("microsoft.graph.deviceOperatingSystemSummary")]
    public class New_DeviceOperatingSystemSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;androidCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of android device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;androidCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 androidCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iosCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of iOS device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;iosCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 iosCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;macOSCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of Mac OS X device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;macOSCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 macOSCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsMobileCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of Windows mobile device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;windowsMobileCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 windowsMobileCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;windowsCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of Windows device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;windowsCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 windowsCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceOperatingSystemSummary&quot; type.</para>
        ///     <para type="description">Number of unknown device count.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceOperatingSystemSummary", HelpMessage = @"The &quot;unknownCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unknownCount { get; set; }
    }
}