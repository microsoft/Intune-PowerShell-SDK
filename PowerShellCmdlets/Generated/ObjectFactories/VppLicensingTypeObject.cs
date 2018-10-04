// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.vppLicensingType&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.vppLicensingType&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "VppLicensingTypeObject", DefaultParameterSetName = @"microsoft.graph.vppLicensingType")]
    [ODataType("microsoft.graph.vppLicensingType")]
    public class New_VppLicensingTypeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;supportsUserLicensing&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppLicensingType&quot; type.</para>
        ///     <para type="description">Whether the program supports the user licensing type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.vppLicensingType", HelpMessage = @"The &quot;supportsUserLicensing&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean supportsUserLicensing { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;supportsDeviceLicensing&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppLicensingType&quot; type.</para>
        ///     <para type="description">Whether the program supports the device licensing type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.vppLicensingType", HelpMessage = @"The &quot;supportsDeviceLicensing&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean supportsDeviceLicensing { get; set; }
    }
}