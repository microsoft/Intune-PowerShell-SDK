// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.securityVendorInformation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.securityVendorInformation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SecurityVendorInformationObject", DefaultParameterSetName = @"microsoft.graph.securityVendorInformation")]
    [ODataType("microsoft.graph.securityVendorInformation")]
    public class New_SecurityVendorInformationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;provider&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.securityVendorInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.securityVendorInformation", HelpMessage = @"The &quot;provider&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String provider { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;providerVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.securityVendorInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.securityVendorInformation", HelpMessage = @"The &quot;providerVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String providerVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subProvider&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.securityVendorInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.securityVendorInformation", HelpMessage = @"The &quot;subProvider&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String subProvider { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vendor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.securityVendorInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.securityVendorInformation", HelpMessage = @"The &quot;vendor&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String vendor { get; set; }
    }
}