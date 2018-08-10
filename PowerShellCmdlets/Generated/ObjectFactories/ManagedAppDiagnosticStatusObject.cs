// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedAppDiagnosticStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedAppDiagnosticStatus&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ManagedAppDiagnosticStatusObject", DefaultParameterSetName = @"#microsoft.graph.managedAppDiagnosticStatus")]
    [ODataType("microsoft.graph.managedAppDiagnosticStatus")]
    public class New_ManagedAppDiagnosticStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;validationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppDiagnosticStatus&quot; type.</para>
        ///     <para type="description">The validation friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppDiagnosticStatus", HelpMessage = @"The &quot;validationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String validationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppDiagnosticStatus&quot; type.</para>
        ///     <para type="description">The state of the operation</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppDiagnosticStatus", HelpMessage = @"The &quot;state&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mitigationInstruction&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedAppDiagnosticStatus&quot; type.</para>
        ///     <para type="description">Instruction on how to mitigate a failed validation</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedAppDiagnosticStatus", HelpMessage = @"The &quot;mitigationInstruction&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mitigationInstruction { get; set; }
    }
}