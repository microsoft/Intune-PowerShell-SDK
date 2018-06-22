// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MultiValueLegacyExtendedPropertyObject", DefaultParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty")]
    [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
    public class New_MultiValueLegacyExtendedPropertyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.multiValueLegacyExtendedProperty", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] value { get; set; }
    }
}