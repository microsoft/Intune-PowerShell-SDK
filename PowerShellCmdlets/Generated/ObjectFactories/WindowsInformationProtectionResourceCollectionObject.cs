// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WindowsInformationProtectionResourceCollectionObject", DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionResourceCollection")]
    [ODataType("microsoft.graph.windowsInformationProtectionResourceCollection")]
    public class New_WindowsInformationProtectionResourceCollectionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot; type.</para>
        ///     <para type="description">Display name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionResourceCollection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resources&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionResourceCollection&quot; type.</para>
        ///     <para type="description">Collection of resources</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionResourceCollection", HelpMessage = @"The &quot;resources&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] resources { get; set; }
    }
}