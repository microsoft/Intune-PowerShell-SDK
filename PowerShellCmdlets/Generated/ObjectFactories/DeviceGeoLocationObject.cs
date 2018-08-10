// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.deviceGeoLocation&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.deviceGeoLocation&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DeviceGeoLocationObject", DefaultParameterSetName = @"#microsoft.graph.deviceGeoLocation")]
    [ODataType("microsoft.graph.deviceGeoLocation")]
    public class New_DeviceGeoLocationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastCollectedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Time at which location was recorded, relative to UTC</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;lastCollectedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastCollectedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Longitude coordinate of the device&apos;s location</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;longitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double longitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Latitude coordinate of the device&apos;s location</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;latitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double latitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Altitude, given in meters above sea level</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;altitude&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double altitude { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;horizontalAccuracy&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Accuracy of longitude and latitude in meters</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;horizontalAccuracy&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double horizontalAccuracy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verticalAccuracy&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Accuracy of altitude in meters</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;verticalAccuracy&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double verticalAccuracy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;heading&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Heading in degrees from true north</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;heading&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double heading { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;speed&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceGeoLocation&quot; type.</para>
        ///     <para type="description">Speed the device is traveling in meters per second</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceGeoLocation", HelpMessage = @"The &quot;speed&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double speed { get; set; }
    }
}