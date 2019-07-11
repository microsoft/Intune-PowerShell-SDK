// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.licenseAssignmentState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.licenseAssignmentState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "LicenseAssignmentStateObject", DefaultParameterSetName = @"microsoft.graph.licenseAssignmentState")]
    [ODataType("microsoft.graph.licenseAssignmentState")]
    public class New_LicenseAssignmentStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseAssignmentState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseAssignmentState", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid skuId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disabledPlans&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseAssignmentState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseAssignmentState", HelpMessage = @"The &quot;disabledPlans&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] disabledPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignedByGroup&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseAssignmentState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseAssignmentState", HelpMessage = @"The &quot;assignedByGroup&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String assignedByGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseAssignmentState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseAssignmentState", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseAssignmentState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.licenseAssignmentState", HelpMessage = @"The &quot;error&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String error { get; set; }
    }
}