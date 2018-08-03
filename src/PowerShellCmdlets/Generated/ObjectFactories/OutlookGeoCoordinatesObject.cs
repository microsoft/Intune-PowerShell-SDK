// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.outlookGeoCoordinates&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.outlookGeoCoordinates&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OutlookGeoCoordinatesObject", DefaultParameterSetName = @"#microsoft.graph.outlookGeoCoordinates")]
    [ODataType("microsoft.graph.outlookGeoCoordinates")]
    public class New_OutlookGeoCoordinatesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookGeoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookGeoCoordinates", HelpMessage = @"The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double Altitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookGeoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookGeoCoordinates", HelpMessage = @"The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double Latitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookGeoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookGeoCoordinates", HelpMessage = @"The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double Longitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accuracy&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookGeoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookGeoCoordinates", HelpMessage = @"The &quot;accuracy&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double Accuracy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;altitudeAccuracy&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookGeoCoordinates&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookGeoCoordinates", HelpMessage = @"The &quot;altitudeAccuracy&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double AltitudeAccuracy { get; set; }
    }
}