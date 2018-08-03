// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.assignedLicense&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.assignedLicense&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AssignedLicenseObject", DefaultParameterSetName = @"#microsoft.graph.assignedLicense")]
    [ODataType("microsoft.graph.assignedLicense")]
    public class New_AssignedLicenseObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;disabledPlans&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedLicense&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedLicense", HelpMessage = @"The &quot;disabledPlans&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] DisabledPlans { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.assignedLicense&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.assignedLicense", HelpMessage = @"The &quot;skuId&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid SkuId { get; set; }
    }
}