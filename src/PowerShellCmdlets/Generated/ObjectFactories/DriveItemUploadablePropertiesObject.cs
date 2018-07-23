// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.driveItemUploadableProperties&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.driveItemUploadableProperties&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "DriveItemUploadablePropertiesObject", DefaultParameterSetName = @"#microsoft.graph.driveItemUploadableProperties")]
    [ODataType("microsoft.graph.driveItemUploadableProperties")]
    public class New_DriveItemUploadablePropertiesObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItemUploadableProperties&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemUploadableProperties", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItemUploadableProperties&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemUploadableProperties", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.driveItemUploadableProperties&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.driveItemUploadableProperties", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }
    }
}