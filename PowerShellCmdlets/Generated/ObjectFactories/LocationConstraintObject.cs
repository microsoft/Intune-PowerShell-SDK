// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.locationConstraint&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.locationConstraint&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "LocationConstraintObject", DefaultParameterSetName = @"microsoft.graph.locationConstraint")]
    [ODataType("microsoft.graph.locationConstraint")]
    public class New_LocationConstraintObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;locations&quot; property, of type &quot;microsoft.graph.locationConstraintItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.locationConstraint&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.locationConstraintItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.locationConstraint", HelpMessage = @"The &quot;locations&quot; property, of type &quot;microsoft.graph.locationConstraintItem&quot;.")]
        public System.Object[] locations { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRequired&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.locationConstraint&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.locationConstraint", HelpMessage = @"The &quot;isRequired&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isRequired { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;suggestLocation&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.locationConstraint&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.locationConstraint", HelpMessage = @"The &quot;suggestLocation&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean suggestLocation { get; set; }
    }
}