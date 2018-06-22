// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosDeviceType&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosDeviceType&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosDeviceTypeObject", DefaultParameterSetName = @"#microsoft.graph.iosDeviceType")]
    [ODataType("microsoft.graph.iosDeviceType")]
    public class New_IosDeviceTypeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;iPad&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosDeviceType&quot; type.</para>
        ///     <para type="description">Whether the app should run on iPads.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosDeviceType", HelpMessage = @"The &quot;iPad&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iPad { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iPhoneAndIPod&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosDeviceType&quot; type.</para>
        ///     <para type="description">Whether the app should run on iPhones and iPods.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.iosDeviceType", HelpMessage = @"The &quot;iPhoneAndIPod&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean iPhoneAndIPod { get; set; }
    }
}