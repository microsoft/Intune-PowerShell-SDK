// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.location&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.location&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "LocationObject", DefaultParameterSetName = @"#microsoft.graph.location")]
    [ODataType("microsoft.graph.location")]
    public class New_LocationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.location")]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.location&quot; type.")]
        public System.Management.Automation.SwitchParameter Location { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locationEmailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;locationEmailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;locationEmailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String LocationEmailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.physicalAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;address&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;address&quot; property, of type &quot;microsoft.graph.physicalAddress&quot;.")]
        public System.Object Address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;coordinates&quot; property, of type &quot;microsoft.graph.outlookGeoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookGeoCoordinates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;coordinates&quot; property, of type &quot;microsoft.graph.outlookGeoCoordinates&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;coordinates&quot; property, of type &quot;microsoft.graph.outlookGeoCoordinates&quot;.")]
        public System.Object Coordinates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locationUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;locationUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;locationUri&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String LocationUri { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locationType&quot; property, of type &quot;microsoft.graph.locationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;default&apos;, &apos;conferenceRoom&apos;, &apos;homeAddress&apos;, &apos;businessAddress&apos;, &apos;geoCoordinates&apos;, &apos;streetAddress&apos;, &apos;hotel&apos;, &apos;restaurant&apos;, &apos;localBusiness&apos;, &apos;postalAddress&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.locationType")]
        [Selectable]
        [ValidateSet(@"default", @"conferenceRoom", @"homeAddress", @"businessAddress", @"geoCoordinates", @"streetAddress", @"hotel", @"restaurant", @"localBusiness", @"postalAddress")]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;locationType&quot; property, of type &quot;microsoft.graph.locationType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;locationType&quot; property, of type &quot;microsoft.graph.locationType&quot;.")]
        public System.String LocationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;uniqueId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;uniqueId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String UniqueId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;uniqueIdType&quot; property, of type &quot;microsoft.graph.locationUniqueIdType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.location&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;locationStore&apos;, &apos;directory&apos;, &apos;private&apos;, &apos;bing&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.locationUniqueIdType")]
        [Selectable]
        [ValidateSet(@"unknown", @"locationStore", @"directory", @"private", @"bing")]
        [Parameter(ParameterSetName = @"#microsoft.graph.location", HelpMessage = @"The &quot;uniqueIdType&quot; property, of type &quot;microsoft.graph.locationUniqueIdType&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;uniqueIdType&quot; property, of type &quot;microsoft.graph.locationUniqueIdType&quot;.")]
        public System.String UniqueIdType { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.locationConstraintItem&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.locationConstraintItem")]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.locationConstraintItem&quot; type.")]
        public System.Management.Automation.SwitchParameter LocationConstraintItem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resolveAvailability&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.locationConstraintItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.locationConstraintItem", HelpMessage = @"The &quot;resolveAvailability&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean ResolveAvailability { get; set; }
    }
}