// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.userSecurityState&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.userSecurityState&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "UserSecurityStateObject", DefaultParameterSetName = @"microsoft.graph.userSecurityState")]
    [ODataType("microsoft.graph.userSecurityState")]
    public class New_UserSecurityStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;aadUserId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;aadUserId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String aadUserId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accountName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;accountName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String accountName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;domainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;domainName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String domainName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailRole&quot; property, of type &quot;microsoft.graph.emailRole&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;sender&apos;, &apos;recipient&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.emailRole")]
        [Selectable]
        [ValidateSet(@"unknown", @"sender", @"recipient", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;emailRole&quot; property, of type &quot;microsoft.graph.emailRole&quot;.")]
        public System.String emailRole { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isVpn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;isVpn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isVpn { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;logonDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;logonDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset logonDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;logonId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;logonId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String logonId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;logonIp&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;logonIp&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String logonIp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;logonLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;logonLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String logonLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;logonType&quot; property, of type &quot;microsoft.graph.logonType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;interactive&apos;, &apos;remoteInteractive&apos;, &apos;network&apos;, &apos;batch&apos;, &apos;service&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.logonType")]
        [Selectable]
        [ValidateSet(@"unknown", @"interactive", @"remoteInteractive", @"network", @"batch", @"service", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;logonType&quot; property, of type &quot;microsoft.graph.logonType&quot;.")]
        public System.String logonType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;onPremisesSecurityIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String onPremisesSecurityIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;riskScore&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String riskScore { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userAccountType&quot; property, of type &quot;microsoft.graph.userAccountSecurityType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;standard&apos;, &apos;power&apos;, &apos;administrator&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.userAccountSecurityType")]
        [Selectable]
        [ValidateSet(@"unknown", @"standard", @"power", @"administrator", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;userAccountType&quot; property, of type &quot;microsoft.graph.userAccountSecurityType&quot;.")]
        public System.String userAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.userSecurityState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.userSecurityState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }
    }
}