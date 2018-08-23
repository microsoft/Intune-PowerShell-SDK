// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.patternedRecurrence&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.patternedRecurrence&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PatternedRecurrenceObject", DefaultParameterSetName = @"microsoft.graph.patternedRecurrence")]
    [ODataType("microsoft.graph.patternedRecurrence")]
    public class New_PatternedRecurrenceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;pattern&quot; property, of type &quot;microsoft.graph.recurrencePattern&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.patternedRecurrence&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recurrencePattern")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.patternedRecurrence", HelpMessage = @"The &quot;pattern&quot; property, of type &quot;microsoft.graph.recurrencePattern&quot;.")]
        public System.Object pattern { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;range&quot; property, of type &quot;microsoft.graph.recurrenceRange&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.patternedRecurrence&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.recurrenceRange")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.patternedRecurrence", HelpMessage = @"The &quot;range&quot; property, of type &quot;microsoft.graph.recurrenceRange&quot;.")]
        public System.Object range { get; set; }
    }
}