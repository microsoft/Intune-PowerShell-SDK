// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.cloudAppSecurityState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.cloudAppSecurityState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "CloudAppSecurityStateObject", DefaultParameterSetName = @"microsoft.graph.cloudAppSecurityState")]
    [ODataType("microsoft.graph.cloudAppSecurityState")]
    public class New_CloudAppSecurityStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;destinationServiceIp&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.cloudAppSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.cloudAppSecurityState", HelpMessage = @"The &quot;destinationServiceIp&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationServiceIp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;destinationServiceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.cloudAppSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.cloudAppSecurityState", HelpMessage = @"The &quot;destinationServiceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String destinationServiceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.cloudAppSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.cloudAppSecurityState", HelpMessage = @"The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String riskScore { get; set; }
    }
}