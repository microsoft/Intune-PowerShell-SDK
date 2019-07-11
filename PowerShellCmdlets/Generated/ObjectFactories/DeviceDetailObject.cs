// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceDetail&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceDetail&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceDetailObject", DefaultParameterSetName = @"microsoft.graph.deviceDetail")]
    [ODataType("microsoft.graph.deviceDetail")]
    public class New_DeviceDetailObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;browser&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;browser&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String browser { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;isCompliant&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isCompliant { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;isManaged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceDetail", HelpMessage = @"The &quot;trustType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String trustType { get; set; }
    }
}