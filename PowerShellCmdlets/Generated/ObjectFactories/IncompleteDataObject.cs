// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.incompleteData&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.incompleteData&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "IncompleteDataObject", DefaultParameterSetName = @"microsoft.graph.incompleteData")]
    [ODataType("microsoft.graph.incompleteData")]
    public class New_IncompleteDataObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;missingDataBeforeDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.incompleteData&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.incompleteData", HelpMessage = @"The &quot;missingDataBeforeDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset missingDataBeforeDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;wasThrottled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.incompleteData&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.incompleteData", HelpMessage = @"The &quot;wasThrottled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean wasThrottled { get; set; }
    }
}