// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.photo&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.photo&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PhotoObject", DefaultParameterSetName = @"#microsoft.graph.photo")]
    [ODataType("microsoft.graph.photo")]
    public class New_PhotoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;cameraMake&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;cameraMake&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String cameraMake { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cameraModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;cameraModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String cameraModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exposureDenominator&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;exposureDenominator&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double exposureDenominator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exposureNumerator&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;exposureNumerator&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double exposureNumerator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fNumber&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;fNumber&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double fNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;focalLength&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;focalLength&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double focalLength { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iso&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;iso&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 iso { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;takenDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.photo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.photo", HelpMessage = @"The &quot;takenDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset takenDateTime { get; set; }
    }
}