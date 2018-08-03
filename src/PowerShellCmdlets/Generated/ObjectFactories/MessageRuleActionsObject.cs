// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.messageRuleActions&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.messageRuleActions&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MessageRuleActionsObject", DefaultParameterSetName = @"#microsoft.graph.messageRuleActions")]
    [ODataType("microsoft.graph.messageRuleActions")]
    public class New_MessageRuleActionsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;moveToFolder&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;moveToFolder&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MoveToFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;copyToFolder&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;copyToFolder&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CopyToFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;delete&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;delete&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean Delete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;permanentDelete&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;permanentDelete&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean PermanentDelete { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;markAsRead&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;markAsRead&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean MarkAsRead { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;markImportance&quot; property, of type &quot;microsoft.graph.importance&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;low&apos;, &apos;normal&apos;, &apos;high&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.importance")]
        [Selectable]
        [ValidateSet(@"low", @"normal", @"high")]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;markImportance&quot; property, of type &quot;microsoft.graph.importance&quot;.")]
        public System.String MarkImportance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;forwardTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;forwardTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ForwardTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;forwardAsAttachmentTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;forwardAsAttachmentTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] ForwardAsAttachmentTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redirectTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recipient")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;redirectTo&quot; property, of type &quot;microsoft.graph.recipient&quot;.")]
        public System.Object[] RedirectTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignCategories&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;assignCategories&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] AssignCategories { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;stopProcessingRules&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRuleActions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRuleActions", HelpMessage = @"The &quot;stopProcessingRules&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean StopProcessingRules { get; set; }
    }
}