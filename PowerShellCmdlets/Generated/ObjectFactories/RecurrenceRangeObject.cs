// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.recurrenceRange&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.recurrenceRange&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RecurrenceRangeObject", DefaultParameterSetName = @"#microsoft.graph.recurrenceRange")]
    [ODataType("microsoft.graph.recurrenceRange")]
    public class New_RecurrenceRangeObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.recurrenceRangeType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrenceRange&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;endDate&apos;, &apos;noEnd&apos;, &apos;numbered&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.recurrenceRangeType")]
        [Selectable]
        [ValidateSet(@"endDate", @"noEnd", @"numbered")]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrenceRange", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.recurrenceRangeType&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; property, of type &quot;Edm.Date&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrenceRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrenceRange", HelpMessage = @"The &quot;startDate&quot; property, of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; property, of type &quot;Edm.Date&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrenceRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrenceRange", HelpMessage = @"The &quot;endDate&quot; property, of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;recurrenceTimeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrenceRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrenceRange", HelpMessage = @"The &quot;recurrenceTimeZone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String recurrenceTimeZone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberOfOccurrences&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.recurrenceRange&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.recurrenceRange", HelpMessage = @"The &quot;numberOfOccurrences&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 numberOfOccurrences { get; set; }
    }
}