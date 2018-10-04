// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.alternativeSecurityId&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.alternativeSecurityId&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AlternativeSecurityIdObject", DefaultParameterSetName = @"microsoft.graph.alternativeSecurityId")]
    [ODataType("microsoft.graph.alternativeSecurityId")]
    public class New_AlternativeSecurityIdObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alternativeSecurityId&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alternativeSecurityId", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;identityProvider&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alternativeSecurityId&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.alternativeSecurityId", HelpMessage = @"The &quot;identityProvider&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String identityProvider { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;key&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.alternativeSecurityId&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.alternativeSecurityId", HelpMessage = @"The &quot;key&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] key { get; set; }
    }
}