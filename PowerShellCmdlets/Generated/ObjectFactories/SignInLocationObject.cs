// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.signInLocation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.signInLocation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SignInLocationObject", DefaultParameterSetName = @"microsoft.graph.signInLocation")]
    [ODataType("microsoft.graph.signInLocation")]
    public class New_SignInLocationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;city&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInLocation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInLocation", HelpMessage = @"The &quot;city&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String city { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInLocation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInLocation", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInLocation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInLocation", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String countryOrRegion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;geoCoordinates&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInLocation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.geoCoordinates")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInLocation", HelpMessage = @"The &quot;geoCoordinates&quot; property, of type &quot;microsoft.graph.geoCoordinates&quot;.")]
        public System.Object geoCoordinates { get; set; }
    }
}