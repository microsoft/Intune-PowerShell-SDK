// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mailboxSettings&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mailboxSettings&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MailboxSettingsObject", DefaultParameterSetName = @"#microsoft.graph.mailboxSettings")]
    [ODataType("microsoft.graph.mailboxSettings")]
    public class New_MailboxSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;automaticRepliesSetting&quot; property, of type &quot;microsoft.graph.automaticRepliesSetting&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailboxSettings&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.automaticRepliesSetting")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailboxSettings", HelpMessage = @"The &quot;automaticRepliesSetting&quot; property, of type &quot;microsoft.graph.automaticRepliesSetting&quot;.")]
        public System.Object automaticRepliesSetting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;archiveFolder&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailboxSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailboxSettings", HelpMessage = @"The &quot;archiveFolder&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String archiveFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;timeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailboxSettings&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailboxSettings", HelpMessage = @"The &quot;timeZone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String timeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;language&quot; property, of type &quot;microsoft.graph.localeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailboxSettings&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.localeInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailboxSettings", HelpMessage = @"The &quot;language&quot; property, of type &quot;microsoft.graph.localeInfo&quot;.")]
        public System.Object language { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workingHours&quot; property, of type &quot;microsoft.graph.workingHours&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailboxSettings&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workingHours")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.mailboxSettings", HelpMessage = @"The &quot;workingHours&quot; property, of type &quot;microsoft.graph.workingHours&quot;.")]
        public System.Object workingHours { get; set; }
    }
}