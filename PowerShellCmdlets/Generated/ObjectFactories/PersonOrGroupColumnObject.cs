// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.personOrGroupColumn&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.personOrGroupColumn&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PersonOrGroupColumnObject", DefaultParameterSetName = @"microsoft.graph.personOrGroupColumn")]
    [ODataType("microsoft.graph.personOrGroupColumn")]
    public class New_PersonOrGroupColumnObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;allowMultipleSelection&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.personOrGroupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.personOrGroupColumn", HelpMessage = @"The &quot;allowMultipleSelection&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean allowMultipleSelection { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;chooseFromType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.personOrGroupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.personOrGroupColumn", HelpMessage = @"The &quot;chooseFromType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String chooseFromType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.personOrGroupColumn&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.personOrGroupColumn", HelpMessage = @"The &quot;displayAs&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayAs { get; set; }
    }
}