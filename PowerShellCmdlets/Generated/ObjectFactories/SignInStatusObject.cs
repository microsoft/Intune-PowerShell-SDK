// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.signInStatus&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.signInStatus&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SignInStatusObject", DefaultParameterSetName = @"microsoft.graph.signInStatus")]
    [ODataType("microsoft.graph.signInStatus")]
    public class New_SignInStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;errorCode&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInStatus&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInStatus", HelpMessage = @"The &quot;errorCode&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 errorCode { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInStatus&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInStatus", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;additionalDetails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.signInStatus&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.signInStatus", HelpMessage = @"The &quot;additionalDetails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String additionalDetails { get; set; }
    }
}