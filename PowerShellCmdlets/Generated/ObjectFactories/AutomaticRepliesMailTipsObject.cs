// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.automaticRepliesMailTips&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.automaticRepliesMailTips&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AutomaticRepliesMailTipsObject", DefaultParameterSetName = @"microsoft.graph.automaticRepliesMailTips")]
    [ODataType("microsoft.graph.automaticRepliesMailTips")]
    public class New_AutomaticRepliesMailTipsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;message&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesMailTips&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.automaticRepliesMailTips", HelpMessage = @"The &quot;message&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String message { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageLanguage&quot; property, of type &quot;microsoft.graph.localeInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesMailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.localeInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.automaticRepliesMailTips", HelpMessage = @"The &quot;messageLanguage&quot; property, of type &quot;microsoft.graph.localeInfo&quot;.")]
        public System.Object messageLanguage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledStartTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesMailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.automaticRepliesMailTips", HelpMessage = @"The &quot;scheduledStartTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object scheduledStartTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduledEndTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.automaticRepliesMailTips&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.automaticRepliesMailTips", HelpMessage = @"The &quot;scheduledEndTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object scheduledEndTime { get; set; }
    }
}