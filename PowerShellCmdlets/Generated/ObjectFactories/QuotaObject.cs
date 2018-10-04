// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.quota&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.quota&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "QuotaObject", DefaultParameterSetName = @"microsoft.graph.quota")]
    [ODataType("microsoft.graph.quota")]
    public class New_QuotaObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;deleted&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.quota&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.quota", HelpMessage = @"The &quot;deleted&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 deleted { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remaining&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.quota&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.quota", HelpMessage = @"The &quot;remaining&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 remaining { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.quota&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.quota", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;total&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.quota&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.quota", HelpMessage = @"The &quot;total&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 total { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;used&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.quota&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.quota", HelpMessage = @"The &quot;used&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 used { get; set; }
    }
}