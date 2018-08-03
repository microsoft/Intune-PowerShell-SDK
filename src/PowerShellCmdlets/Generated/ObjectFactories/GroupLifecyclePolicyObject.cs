// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.groupLifecyclePolicy&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.groupLifecyclePolicy&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "GroupLifecyclePolicyObject", DefaultParameterSetName = @"#microsoft.graph.groupLifecyclePolicy")]
    [ODataType("microsoft.graph.groupLifecyclePolicy")]
    public class New_GroupLifecyclePolicyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;groupLifetimeInDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 GroupLifetimeInDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;managedGroupTypes&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ManagedGroupTypes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupLifecyclePolicy&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.groupLifecyclePolicy", HelpMessage = @"The &quot;alternateNotificationEmails&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AlternateNotificationEmails { get; set; }
    }
}