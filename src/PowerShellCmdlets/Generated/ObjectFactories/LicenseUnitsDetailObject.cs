// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.licenseUnitsDetail&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.licenseUnitsDetail&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "LicenseUnitsDetailObject", DefaultParameterSetName = @"#microsoft.graph.licenseUnitsDetail")]
    [ODataType("microsoft.graph.licenseUnitsDetail")]
    public class New_LicenseUnitsDetailObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseUnitsDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseUnitsDetail", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;suspended&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseUnitsDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseUnitsDetail", HelpMessage = @"The &quot;suspended&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 suspended { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;warning&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.licenseUnitsDetail&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.licenseUnitsDetail", HelpMessage = @"The &quot;warning&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 warning { get; set; }
    }
}