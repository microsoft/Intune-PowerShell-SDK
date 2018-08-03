// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.termsAndConditionsAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.termsAndConditionsAssignment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">A termsAndConditionsAssignment entity represents the assignment of a given Terms and Conditions (T&amp;C) policy to a given group. Users in the group will be required to accept the terms in order to have devices enrolled into Intune.</para>
    /// </summary>
    [Cmdlet("New", "TermsAndConditionsAssignmentObject", DefaultParameterSetName = @"#microsoft.graph.termsAndConditionsAssignment")]
    [ODataType("microsoft.graph.termsAndConditionsAssignment")]
    public class New_TermsAndConditionsAssignmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAssignment&quot; type.</para>
        ///     <para type="description">Assignment target that the T&amp;C policy is assigned to.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceAndAppManagementAssignmentTarget")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAssignment", HelpMessage = @"The &quot;target&quot; property, of type &quot;microsoft.graph.deviceAndAppManagementAssignmentTarget&quot;.")]
        public System.Object Target { get; set; }
    }
}