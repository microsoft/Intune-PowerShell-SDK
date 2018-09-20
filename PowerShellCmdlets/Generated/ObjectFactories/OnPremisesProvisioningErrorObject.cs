// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onPremisesProvisioningError&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onPremisesProvisioningError&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnPremisesProvisioningErrorObject", DefaultParameterSetName = @"microsoft.graph.onPremisesProvisioningError")]
    [ODataType("microsoft.graph.onPremisesProvisioningError")]
    public class New_OnPremisesProvisioningErrorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesProvisioningError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesProvisioningError", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesProvisioningError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesProvisioningError", HelpMessage = @"The &quot;category&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;propertyCausingError&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesProvisioningError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesProvisioningError", HelpMessage = @"The &quot;propertyCausingError&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String propertyCausingError { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;occurredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesProvisioningError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesProvisioningError", HelpMessage = @"The &quot;occurredDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset occurredDateTime { get; set; }
    }
}