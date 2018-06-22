// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.dateTimeTimeZone&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.dateTimeTimeZone&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DateTimeTimeZoneObject", DefaultParameterSetName = @"#microsoft.graph.dateTimeTimeZone")]
    [ODataType("microsoft.graph.dateTimeTimeZone")]
    public class New_DateTimeTimeZoneObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;dateTime&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dateTimeTimeZone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.dateTimeTimeZone", HelpMessage = @"The &quot;dateTime&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String dateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;timeZone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.dateTimeTimeZone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.dateTimeTimeZone", HelpMessage = @"The &quot;timeZone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String timeZone { get; set; }
    }
}