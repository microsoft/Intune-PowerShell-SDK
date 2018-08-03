// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.softwareUpdateStatusSummary&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SoftwareUpdateStatusSummaryObject", DefaultParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary")]
    [ODataType("microsoft.graph.softwareUpdateStatusSummary")]
    public class New_SoftwareUpdateStatusSummaryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">The name of the policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;compliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;nonCompliantDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NonCompliantDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;remediatedDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RemediatedDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of devices had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;errorDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;unknownDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnknownDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;conflictDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConflictDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable devices.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;notApplicableDeviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableDeviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;compliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;compliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 CompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nonCompliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of non compliant users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;nonCompliantUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NonCompliantUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;remediatedUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of remediated users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;remediatedUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 RemediatedUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;errorUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of users had error.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;errorUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ErrorUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unknownUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of unknown users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;unknownUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 UnknownUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conflictUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of conflict users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;conflictUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 ConflictUserCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;notApplicableUserCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.softwareUpdateStatusSummary&quot; type.</para>
        ///     <para type="description">Number of not applicable users.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.softwareUpdateStatusSummary", HelpMessage = @"The &quot;notApplicableUserCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 NotApplicableUserCount { get; set; }
    }
}