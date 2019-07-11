// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.secureScoreControlStateUpdate&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.secureScoreControlStateUpdate&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SecureScoreControlStateUpdateObject", DefaultParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate")]
    [ODataType("microsoft.graph.secureScoreControlStateUpdate")]
    public class New_SecureScoreControlStateUpdateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlStateUpdate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate", HelpMessage = @"The &quot;assignedTo&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String assignedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;comment&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlStateUpdate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate", HelpMessage = @"The &quot;comment&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String comment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlStateUpdate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;updatedBy&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlStateUpdate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate", HelpMessage = @"The &quot;updatedBy&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String updatedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;updatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.secureScoreControlStateUpdate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.secureScoreControlStateUpdate", HelpMessage = @"The &quot;updatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset updatedDateTime { get; set; }
    }
}