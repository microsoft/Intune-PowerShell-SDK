// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.targetResource&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.targetResource&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "TargetResourceObject", DefaultParameterSetName = @"microsoft.graph.targetResource")]
    [ODataType("microsoft.graph.targetResource")]
    public class New_TargetResourceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetResource", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetResource", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.targetResource", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupType&quot; property, of type &quot;microsoft.graph.groupType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetResource&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unifiedGroups&apos;, &apos;azureAD&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.groupType")]
        [Selectable]
        [ValidateSet(@"unifiedGroups", @"azureAD", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.targetResource", HelpMessage = @"The &quot;groupType&quot; property, of type &quot;microsoft.graph.groupType&quot;.")]
        public System.String groupType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;modifiedProperties&quot; property, of type &quot;microsoft.graph.modifiedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.targetResource&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.modifiedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.targetResource", HelpMessage = @"The &quot;modifiedProperties&quot; property, of type &quot;microsoft.graph.modifiedProperty&quot;.")]
        public System.Object[] modifiedProperties { get; set; }
    }
}