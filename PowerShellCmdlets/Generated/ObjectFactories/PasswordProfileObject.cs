// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.passwordProfile&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.passwordProfile&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PasswordProfileObject", DefaultParameterSetName = @"#microsoft.graph.passwordProfile")]
    [ODataType("microsoft.graph.passwordProfile")]
    public class New_PasswordProfileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;password&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.passwordProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.passwordProfile", HelpMessage = @"The &quot;password&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String password { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;forceChangePasswordNextSignIn&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.passwordProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.passwordProfile", HelpMessage = @"The &quot;forceChangePasswordNextSignIn&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean forceChangePasswordNextSignIn { get; set; }
    }
}