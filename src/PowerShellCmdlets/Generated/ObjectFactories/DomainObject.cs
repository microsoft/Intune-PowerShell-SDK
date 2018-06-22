// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.domain&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.domain&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DomainObject", DefaultParameterSetName = @"#microsoft.graph.domain")]
    [ODataType("microsoft.graph.domain")]
    public class New_DomainObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;authenticationType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;authenticationType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String authenticationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;availabilityStatus&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;availabilityStatus&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String availabilityStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isAdminManaged&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;isAdminManaged&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isAdminManaged { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isInitial&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;isInitial&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isInitial { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isRoot&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;isRoot&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isRoot { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isVerified&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;isVerified&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isVerified { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;supportedServices&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;supportedServices&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] supportedServices { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.domainState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.domainState")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.domainState&quot;.")]
        public System.Object state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;serviceConfigurationRecords&quot; property, of type &quot;microsoft.graph.domainDnsRecord&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.domainDnsRecord")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;serviceConfigurationRecords&quot; property, of type &quot;microsoft.graph.domainDnsRecord&quot;.")]
        public System.Object[] serviceConfigurationRecords { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;verificationDnsRecords&quot; property, of type &quot;microsoft.graph.domainDnsRecord&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.domainDnsRecord")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;verificationDnsRecords&quot; property, of type &quot;microsoft.graph.domainDnsRecord&quot;.")]
        public System.Object[] verificationDnsRecords { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;domainNameReferences&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domain&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.directoryObject")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.domain", HelpMessage = @"The &quot;domainNameReferences&quot; property, of type &quot;microsoft.graph.directoryObject&quot;.")]
        public System.Object[] domainNameReferences { get; set; }
    }
}