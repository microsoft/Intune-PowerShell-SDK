// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsDeviceAccount&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsDeviceAccount&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsDeviceAccountObject", DefaultParameterSetName = @"microsoft.graph.windowsDeviceAccount")]
    [ODataType("microsoft.graph.windowsDeviceAccount")]
    public class New_WindowsDeviceAccountObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceAccount&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsDeviceAccount")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceAccount", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceAccount&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsDeviceAccount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;password&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsDeviceAccount&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceAccount", HelpMessage = @"The &quot;password&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceAzureADAccount", HelpMessage = @"The &quot;password&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceADAccount", HelpMessage = @"The &quot;password&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String password { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceAzureADAccount&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsDeviceAzureADAccount")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceAzureADAccount", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceAzureADAccount&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsDeviceAzureADAccount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsDeviceAzureADAccount&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceAzureADAccount", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceADAccount&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.windowsDeviceADAccount")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceADAccount", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.windowsDeviceADAccount&quot; type.")]
        public System.Management.Automation.SwitchParameter windowsDeviceADAccount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;domainName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsDeviceADAccount&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceADAccount", HelpMessage = @"The &quot;domainName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String domainName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsDeviceADAccount&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsDeviceADAccount", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }
    }
}