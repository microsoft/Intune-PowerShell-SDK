// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AppliedConditionalAccessPolicyObject", DefaultParameterSetName = @"microsoft.graph.appliedConditionalAccessPolicy")]
    [ODataType("microsoft.graph.appliedConditionalAccessPolicy")]
    public class New_AppliedConditionalAccessPolicyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appliedConditionalAccessPolicy", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcedGrantControls&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.appliedConditionalAccessPolicy", HelpMessage = @"The &quot;enforcedGrantControls&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] enforcedGrantControls { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enforcedSessionControls&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.appliedConditionalAccessPolicy", HelpMessage = @"The &quot;enforcedSessionControls&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] enforcedSessionControls { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;result&quot; property, of type &quot;microsoft.graph.appliedConditionalAccessPolicyResult&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appliedConditionalAccessPolicy&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;success&apos;, &apos;failure&apos;, &apos;notApplied&apos;, &apos;notEnabled&apos;, &apos;unknown&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.appliedConditionalAccessPolicyResult")]
        [Selectable]
        [ValidateSet(@"success", @"failure", @"notApplied", @"notEnabled", @"unknown", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.appliedConditionalAccessPolicy", HelpMessage = @"The &quot;result&quot; property, of type &quot;microsoft.graph.appliedConditionalAccessPolicyResult&quot;.")]
        public System.String result { get; set; }
    }
}