// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sharingDetail&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sharingDetail&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharingDetailObject", DefaultParameterSetName = @"microsoft.graph.sharingDetail")]
    [ODataType("microsoft.graph.sharingDetail")]
    public class New_SharingDetailObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;sharedBy&quot; property, of type &quot;microsoft.graph.insightIdentity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingDetail&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.insightIdentity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharingDetail", HelpMessage = @"The &quot;sharedBy&quot; property, of type &quot;microsoft.graph.insightIdentity&quot;.")]
        public System.Object sharedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharingDetail", HelpMessage = @"The &quot;sharedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset sharedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharingSubject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharingDetail", HelpMessage = @"The &quot;sharingSubject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sharingSubject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharingType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharingDetail", HelpMessage = @"The &quot;sharingType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String sharingType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharingReference&quot; property, of type &quot;microsoft.graph.resourceReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingDetail&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.resourceReference")]
        [Selectable]
        public System.Object sharingReference { get; set; }
    }
}