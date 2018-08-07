// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.followupFlag&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.followupFlag&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "FollowupFlagObject", DefaultParameterSetName = @"#microsoft.graph.followupFlag")]
    [ODataType("microsoft.graph.followupFlag")]
    public class New_FollowupFlagObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;completedDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.followupFlag&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.followupFlag", HelpMessage = @"The &quot;completedDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object completedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dueDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.followupFlag&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.followupFlag", HelpMessage = @"The &quot;dueDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object dueDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.followupFlag&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.dateTimeTimeZone")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.followupFlag", HelpMessage = @"The &quot;startDateTime&quot; property, of type &quot;microsoft.graph.dateTimeTimeZone&quot;.")]
        public System.Object startDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;flagStatus&quot; property, of type &quot;microsoft.graph.followupFlagStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.followupFlag&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;notFlagged&apos;, &apos;complete&apos;, &apos;flagged&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.followupFlagStatus")]
        [Selectable]
        [ValidateSet(@"notFlagged", @"complete", @"flagged")]
        [Parameter(ParameterSetName = @"#microsoft.graph.followupFlag", HelpMessage = @"The &quot;flagStatus&quot; property, of type &quot;microsoft.graph.followupFlagStatus&quot;.")]
        public System.String flagStatus { get; set; }
    }
}