// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.privacyProfile&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.privacyProfile&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PrivacyProfileObject", DefaultParameterSetName = @"#microsoft.graph.privacyProfile")]
    [ODataType("microsoft.graph.privacyProfile")]
    public class New_PrivacyProfileObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;contactEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.privacyProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.privacyProfile", HelpMessage = @"The &quot;contactEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ContactEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;statementUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.privacyProfile&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.privacyProfile", HelpMessage = @"The &quot;statementUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String StatementUrl { get; set; }
    }
}