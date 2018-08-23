// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.groupSetting&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.groupSetting&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "GroupSettingObject", DefaultParameterSetName = @"microsoft.graph.groupSetting")]
    [ODataType("microsoft.graph.groupSetting")]
    public class New_GroupSettingObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String templateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.")]
        public System.Object[] values { get; set; }
    }
}