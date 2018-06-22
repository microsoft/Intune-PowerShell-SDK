// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.ipRange&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.ipRange&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IpRangeObject", DefaultParameterSetName = @"#microsoft.graph.iPv6Range")]
    [ODataType("microsoft.graph.ipRange")]
    public class New_IpRangeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iPv4Range&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iPv4Range")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv4Range", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iPv4Range&quot; type.")]
        public System.Management.Automation.SwitchParameter iPv4Range { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lowerAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iPv4Range&quot; type.</para>
        ///     <para type="description">Lower IP Address</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv4Range", HelpMessage = @"The &quot;lowerAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv6Range", HelpMessage = @"The &quot;lowerAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String lowerAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;upperAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iPv4Range&quot; type.</para>
        ///     <para type="description">Upper IP Address</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv4Range", HelpMessage = @"The &quot;upperAddress&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv6Range", HelpMessage = @"The &quot;upperAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String upperAddress { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iPv6Range&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.iPv6Range")]
        [Parameter(ParameterSetName = @"#microsoft.graph.iPv6Range", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iPv6Range&quot; type.")]
        public System.Management.Automation.SwitchParameter iPv6Range { get; set; }
    }
}