// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.attachment&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.attachment&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AttachmentObject", DefaultParameterSetName = @"#microsoft.graph.attachment")]
    [ODataType("microsoft.graph.attachment")]
    public class New_AttachmentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.attachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.attachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;isInline&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isInline { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.referenceAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.referenceAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.referenceAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.referenceAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter referenceAttachment { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.itemAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.itemAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.itemAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter itemAttachment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemAttachment&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookItem")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.itemAttachment", HelpMessage = @"The &quot;item&quot; property, of type &quot;microsoft.graph.outlookItem&quot;.")]
        public System.Object item { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.fileAttachment")]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.fileAttachment&quot; type.")]
        public System.Management.Automation.SwitchParameter fileAttachment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentLocation&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.fileAttachment&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.fileAttachment", HelpMessage = @"The &quot;contentBytes&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] contentBytes { get; set; }
    }
}