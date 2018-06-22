// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenotePatchContentCommand&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenotePatchContentCommand&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenotePatchContentCommandObject", DefaultParameterSetName = @"#microsoft.graph.onenotePatchContentCommand")]
    [ODataType("microsoft.graph.onenotePatchContentCommand")]
    public class New_OnenotePatchContentCommandObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;action&quot; property, of type &quot;microsoft.graph.onenotePatchActionType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePatchContentCommand&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;Replace&apos;, &apos;Append&apos;, &apos;Delete&apos;, &apos;Insert&apos;, &apos;Prepend&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePatchActionType")]
        [Selectable]
        [ValidateSet(@"Replace", @"Append", @"Delete", @"Insert", @"Prepend")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePatchContentCommand", HelpMessage = @"The &quot;action&quot; property, of type &quot;microsoft.graph.onenotePatchActionType&quot;.")]
        public System.String action { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;target&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePatchContentCommand&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePatchContentCommand", HelpMessage = @"The &quot;target&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String target { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePatchContentCommand&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePatchContentCommand", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;position&quot; property, of type &quot;microsoft.graph.onenotePatchInsertPosition&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenotePatchContentCommand&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;After&apos;, &apos;Before&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePatchInsertPosition")]
        [Selectable]
        [ValidateSet(@"After", @"Before")]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenotePatchContentCommand", HelpMessage = @"The &quot;position&quot; property, of type &quot;microsoft.graph.onenotePatchInsertPosition&quot;.")]
        public System.String position { get; set; }
    }
}