// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.geoCoordinates&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.geoCoordinates&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "GeoCoordinatesObject", DefaultParameterSetName = @"#microsoft.graph.geoCoordinates")]
    [ODataType("microsoft.graph.geoCoordinates")]
    public class New_GeoCoordinatesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.geoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.geoCoordinates", HelpMessage = @"The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double altitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.geoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.geoCoordinates", HelpMessage = @"The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double latitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.geoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.geoCoordinates", HelpMessage = @"The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double longitude { get; set; }
    }
}