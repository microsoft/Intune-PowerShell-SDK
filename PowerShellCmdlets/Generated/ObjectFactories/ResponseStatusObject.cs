// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.responseStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.responseStatus&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ResponseStatusObject", DefaultParameterSetName = @"microsoft.graph.responseStatus")]
    [ODataType("microsoft.graph.responseStatus")]
    public class New_ResponseStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;response&quot; property, of type &quot;microsoft.graph.responseType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.responseStatus&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;organizer&apos;, &apos;tentativelyAccepted&apos;, &apos;accepted&apos;, &apos;declined&apos;, &apos;notResponded&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.responseType")]
        [Selectable]
        [ValidateSet(@"none", @"organizer", @"tentativelyAccepted", @"accepted", @"declined", @"notResponded")]
        [Parameter(ParameterSetName = @"microsoft.graph.responseStatus", HelpMessage = @"The &quot;response&quot; property, of type &quot;microsoft.graph.responseType&quot;.")]
        public System.String response { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;time&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.responseStatus&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.responseStatus", HelpMessage = @"The &quot;time&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset time { get; set; }
    }
}