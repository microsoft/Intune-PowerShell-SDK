// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.website&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.website&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WebsiteObject", DefaultParameterSetName = @"#microsoft.graph.website")]
    [ODataType("microsoft.graph.website")]
    public class New_WebsiteObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;microsoft.graph.websiteType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.website&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;other&apos;, &apos;home&apos;, &apos;work&apos;, &apos;blog&apos;, &apos;profile&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.websiteType")]
        [Selectable]
        [ValidateSet(@"other", @"home", @"work", @"blog", @"profile")]
        [Parameter(ParameterSetName = @"#microsoft.graph.website", HelpMessage = @"The &quot;type&quot; property, of type &quot;microsoft.graph.websiteType&quot;.")]
        public System.String type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;address&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.website&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.website", HelpMessage = @"The &quot;address&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String address { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.website&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.website", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }
    }
}