// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.process&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.process&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ProcessObject", DefaultParameterSetName = @"microsoft.graph.process")]
    [ODataType("microsoft.graph.process")]
    public class New_ProcessObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;accountName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;accountName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String accountName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;commandLine&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;commandLine&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String commandLine { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;microsoft.graph.fileHash&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileHash")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;microsoft.graph.fileHash&quot;.")]
        public System.Object fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;integrityLevel&quot; property, of type &quot;microsoft.graph.processIntegrityLevel&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;untrusted&apos;, &apos;low&apos;, &apos;medium&apos;, &apos;high&apos;, &apos;system&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.processIntegrityLevel")]
        [Selectable]
        [ValidateSet(@"unknown", @"untrusted", @"low", @"medium", @"high", @"system", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;integrityLevel&quot; property, of type &quot;microsoft.graph.processIntegrityLevel&quot;.")]
        public System.String integrityLevel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isElevated&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;isElevated&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isElevated { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentProcessCreatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;parentProcessCreatedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset parentProcessCreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentProcessId&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;parentProcessId&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 parentProcessId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentProcessName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;parentProcessName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentProcessName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;path&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;path&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String path { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;processId&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.process&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.process", HelpMessage = @"The &quot;processId&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 processId { get; set; }
    }
}