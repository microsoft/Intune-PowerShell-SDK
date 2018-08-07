// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.automaticRepliesSetting&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.automaticRepliesSetting&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AutomaticRepliesSettingObject", DefaultParameterSetName = @"#microsoft.graph.automaticRepliesSetting")]
    [ODataType("microsoft.graph.automaticRepliesSetting")]
    public class New_AutomaticRepliesSettingObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;status&quot; property, of type &quot;microsoft.graph.automaticRepliesStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;disabled&apos;, &apos;alwaysEnabled&apos;, &apos;scheduled&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.automaticRepliesStatus")]
        [Selectable]
        [ValidateSet(@"disabled", @"alwaysEnabled", @"scheduled")]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;status&quot; property, of type &quot;microsoft.graph.automaticRepliesStatus&quot;.")]
        public System.String status { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalAudience&quot; property, of type &quot;microsoft.graph.externalAudienceScope&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;contactsOnly&apos;, &apos;all&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.externalAudienceScope")]
        [Selectable]
        [ValidateSet(@"none", @"contactsOnly", @"all")]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;externalAudience&quot; property, of type &quot;microsoft.graph.externalAudienceScope&quot;.")]
        public System.String externalAudience { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledStartDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;scheduledStartDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object scheduledStartDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledEndDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;scheduledEndDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object scheduledEndDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;internalReplyMessage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;internalReplyMessage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String internalReplyMessage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalReplyMessage&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.automaticRepliesSetting", HelpMessage = @"The &quot;externalReplyMessage&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String externalReplyMessage { get; set; }
    }
}