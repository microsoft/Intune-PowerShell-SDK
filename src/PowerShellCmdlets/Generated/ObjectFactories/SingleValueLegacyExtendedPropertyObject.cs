// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SingleValueLegacyExtendedPropertyObject", DefaultParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
    public class New_SingleValueLegacyExtendedPropertyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.singleValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Value { get; set; }
    }
}