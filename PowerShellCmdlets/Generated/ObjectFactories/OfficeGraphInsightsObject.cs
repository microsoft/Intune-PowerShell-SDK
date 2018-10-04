// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.officeGraphInsights&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.officeGraphInsights&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "OfficeGraphInsightsObject", DefaultParameterSetName = @"microsoft.graph.officeGraphInsights")]
    [ODataType("microsoft.graph.officeGraphInsights")]
    public class New_OfficeGraphInsightsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;trending&quot; property, of type &quot;microsoft.graph.trending&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.officeGraphInsights&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.trending")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.officeGraphInsights", HelpMessage = @"The &quot;trending&quot; property, of type &quot;microsoft.graph.trending&quot;.")]
        public System.Object[] trending { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.sharedInsight&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.officeGraphInsights&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharedInsight")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.officeGraphInsights", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.sharedInsight&quot;.")]
        public System.Object[] shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;used&quot; property, of type &quot;microsoft.graph.usedInsight&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.officeGraphInsights&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.usedInsight")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.officeGraphInsights", HelpMessage = @"The &quot;used&quot; property, of type &quot;microsoft.graph.usedInsight&quot;.")]
        public System.Object[] used { get; set; }
    }
}