// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.currencyColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.currencyColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "CurrencyColumnObject", DefaultParameterSetName = @"microsoft.graph.currencyColumn")]
    [ODataType("microsoft.graph.currencyColumn")]
    public class New_CurrencyColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;locale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.currencyColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.currencyColumn", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String locale { get; set; }
    }
}