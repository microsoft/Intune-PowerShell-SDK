// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.scheduleInformation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.scheduleInformation&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ScheduleInformationObject", DefaultParameterSetName = @"microsoft.graph.scheduleInformation")]
    [ODataType("microsoft.graph.scheduleInformation")]
    public class New_ScheduleInformationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;scheduleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleInformation", HelpMessage = @"The &quot;scheduleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String scheduleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scheduleItems&quot; property, of type &quot;microsoft.graph.scheduleItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleInformation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.scheduleItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleInformation", HelpMessage = @"The &quot;scheduleItems&quot; property, of type &quot;microsoft.graph.scheduleItem&quot;.")]
        public System.Object[] scheduleItems { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;availabilityView&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleInformation&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleInformation", HelpMessage = @"The &quot;availabilityView&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String availabilityView { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;error&quot; property, of type &quot;microsoft.graph.freeBusyError&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleInformation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.freeBusyError")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleInformation", HelpMessage = @"The &quot;error&quot; property, of type &quot;microsoft.graph.freeBusyError&quot;.")]
        public System.Object error { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;workingHours&quot; property, of type &quot;microsoft.graph.workingHours&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.scheduleInformation&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workingHours")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.scheduleInformation", HelpMessage = @"The &quot;workingHours&quot; property, of type &quot;microsoft.graph.workingHours&quot;.")]
        public System.Object workingHours { get; set; }
    }
}