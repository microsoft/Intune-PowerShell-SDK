// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.messageRule&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.messageRule&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MessageRuleObject", DefaultParameterSetName = @"#microsoft.graph.messageRule")]
    [ODataType("microsoft.graph.messageRule")]
    public class New_MessageRuleObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 sequence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object conditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRuleActions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.")]
        public System.Object actions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object exceptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasError { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadOnly { get; set; }
    }
}