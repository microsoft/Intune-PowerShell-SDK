// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.phone&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.phone&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PhoneObject", DefaultParameterSetName = @"#microsoft.graph.phone")]
    [ODataType("microsoft.graph.phone")]
    public class New_PhoneObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.phoneType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.phone&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;home&apos;, &apos;business&apos;, &apos;mobile&apos;, &apos;other&apos;, &apos;assistant&apos;, &apos;homeFax&apos;, &apos;businessFax&apos;, &apos;otherFax&apos;, &apos;pager&apos;, &apos;radio&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.phoneType")]
        [Selectable]
        [ValidateSet(@"home", @"business", @"mobile", @"other", @"assistant", @"homeFax", @"businessFax", @"otherFax", @"pager", @"radio")]
        [Parameter(ParameterSetName = @"#microsoft.graph.phone", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.phoneType&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.phone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.phone", HelpMessage = @"The &quot;number&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;region&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.phone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.phone", HelpMessage = @"The &quot;region&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String region { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;language&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.phone&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.phone", HelpMessage = @"The &quot;language&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String language { get; set; }
    }
}