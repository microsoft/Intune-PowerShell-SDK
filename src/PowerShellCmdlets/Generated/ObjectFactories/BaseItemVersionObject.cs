// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.baseItemVersion&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.baseItemVersion&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "BaseItemVersionObject", DefaultParameterSetName = @"#microsoft.graph.driveItemVersion")]
    [ODataType("microsoft.graph.baseItemVersion")]
    public class New_BaseItemVersionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItemVersion", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItemVersion", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.baseItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.publicationFacet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.baseItemVersion", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", HelpMessage = @"The &quot;publication&quot; property, of type &quot;microsoft.graph.publicationFacet&quot;.")]
        public System.Object publication { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.listItemVersion")]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.listItemVersion&quot; type.")]
        public System.Management.Automation.SwitchParameter listItemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.listItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fieldValueSet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.listItemVersion", HelpMessage = @"The &quot;fields&quot; property, of type &quot;microsoft.graph.fieldValueSet&quot;.")]
        public System.Object fields { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.driveItemVersion&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.driveItemVersion")]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.driveItemVersion&quot; type.")]
        public System.Management.Automation.SwitchParameter driveItemVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItemVersion&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemVersion", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }
    }
}