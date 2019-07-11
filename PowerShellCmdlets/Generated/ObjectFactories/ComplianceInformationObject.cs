// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.complianceInformation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.complianceInformation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ComplianceInformationObject", DefaultParameterSetName = @"microsoft.graph.complianceInformation")]
    [ODataType("microsoft.graph.complianceInformation")]
    public class New_ComplianceInformationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;certificationControls&quot; property, of type &quot;microsoft.graph.certificationControl&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.complianceInformation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.certificationControl")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.complianceInformation", HelpMessage = @"The &quot;certificationControls&quot; property, of type &quot;microsoft.graph.certificationControl&quot;.")]
        public System.Object[] certificationControls { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.complianceInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.complianceInformation", HelpMessage = @"The &quot;certificationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String certificationName { get; set; }
    }
}