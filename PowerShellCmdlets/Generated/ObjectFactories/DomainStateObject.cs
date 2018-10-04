// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.domainState&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.domainState&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "DomainStateObject", DefaultParameterSetName = @"microsoft.graph.domainState")]
    [ODataType("microsoft.graph.domainState")]
    public class New_DomainStateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.domainState", HelpMessage = @"The &quot;status&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.domainState", HelpMessage = @"The &quot;operation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.domainState&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.domainState", HelpMessage = @"The &quot;lastActionDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastActionDateTime { get; set; }
    }
}