// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.extension&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.extension&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ExtensionObject", DefaultParameterSetName = @"#microsoft.graph.extension")]
    [ODataType("microsoft.graph.extension")]
    public class New_ExtensionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.openTypeExtension")]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.")]
        public System.Management.Automation.SwitchParameter openTypeExtension { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.openTypeExtension", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String extensionName { get; set; }
    }
}