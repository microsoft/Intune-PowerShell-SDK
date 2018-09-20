// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mailTipsError&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mailTipsError&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MailTipsErrorObject", DefaultParameterSetName = @"microsoft.graph.mailTipsError")]
    [ODataType("microsoft.graph.mailTipsError")]
    public class New_MailTipsErrorObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;message&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTipsError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTipsError", HelpMessage = @"The &quot;message&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;code&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailTipsError&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailTipsError", HelpMessage = @"The &quot;code&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String code { get; set; }
    }
}