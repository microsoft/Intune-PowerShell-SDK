// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.rgbColor&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.rgbColor&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RgbColorObject", DefaultParameterSetName = @"microsoft.graph.rgbColor")]
    [ODataType("microsoft.graph.rgbColor")]
    public class New_RgbColorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;r&quot; property, of type &quot;Edm.Byte&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.rgbColor&quot; type.</para>
        ///     <para type="description">Red value</para>
        /// </summary>
        [ODataType("Edm.Byte")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.rgbColor", HelpMessage = @"The &quot;r&quot; property, of type &quot;Edm.Byte&quot;.")]
        public System.Byte r { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;g&quot; property, of type &quot;Edm.Byte&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.rgbColor&quot; type.</para>
        ///     <para type="description">Green value</para>
        /// </summary>
        [ODataType("Edm.Byte")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.rgbColor", HelpMessage = @"The &quot;g&quot; property, of type &quot;Edm.Byte&quot;.")]
        public System.Byte g { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;b&quot; property, of type &quot;Edm.Byte&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.rgbColor&quot; type.</para>
        ///     <para type="description">Blue value</para>
        /// </summary>
        [ODataType("Edm.Byte")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.rgbColor", HelpMessage = @"The &quot;b&quot; property, of type &quot;Edm.Byte&quot;.")]
        public System.Byte b { get; set; }
    }
}