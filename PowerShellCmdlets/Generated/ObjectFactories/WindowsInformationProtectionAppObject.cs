// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionApp&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionAppObject", DefaultParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp")]
    [ODataType("microsoft.graph.windowsInformationProtectionApp")]
    public class New_WindowsInformationProtectionAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionApp&quot; type.</para>
        ///     <para type="description">App display name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionApp&quot; type.</para>
        ///     <para type="description">The app&apos;s description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publisherName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionApp&quot; type.</para>
        ///     <para type="description">The publisher name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp", HelpMessage = @"The &quot;publisherName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;publisherName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", HelpMessage = @"The &quot;publisherName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publisherName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;productName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionApp&quot; type.</para>
        ///     <para type="description">The product name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp", HelpMessage = @"The &quot;productName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;productName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", HelpMessage = @"The &quot;productName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String productName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;denied&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionApp&quot; type.</para>
        ///     <para type="description">If true, app is denied protection or exemption.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionApp", HelpMessage = @"The &quot;denied&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;denied&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", HelpMessage = @"The &quot;denied&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean denied { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionDesktopApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsInformationProtectionDesktopApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionDesktopApp&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsInformationProtectionDesktopApp { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;binaryName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDesktopApp&quot; type.</para>
        ///     <para type="description">The binary name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;binaryName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String binaryName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;binaryVersionLow&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDesktopApp&quot; type.</para>
        ///     <para type="description">The lower binary version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;binaryVersionLow&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String binaryVersionLow { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;binaryVersionHigh&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionDesktopApp&quot; type.</para>
        ///     <para type="description">The high binary version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionDesktopApp", HelpMessage = @"The &quot;binaryVersionHigh&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String binaryVersionHigh { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionStoreApp&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.windowsInformationProtectionStoreApp")]
        [Parameter(ParameterSetName = @"#microsoft.graph.windowsInformationProtectionStoreApp", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsInformationProtectionStoreApp&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsInformationProtectionStoreApp { get; set; }
    }
}