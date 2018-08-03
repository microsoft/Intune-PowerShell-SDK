// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.video&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.video&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "VideoObject", DefaultParameterSetName = @"#microsoft.graph.video")]
    [ODataType("microsoft.graph.video")]
    public class New_VideoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;audioBitsPerSample&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;audioBitsPerSample&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 AudioBitsPerSample { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audioChannels&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;audioChannels&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 AudioChannels { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audioFormat&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;audioFormat&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AudioFormat { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;audioSamplesPerSecond&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;audioSamplesPerSecond&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 AudioSamplesPerSecond { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitrate&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;bitrate&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Bitrate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 Duration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fourCC&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;fourCC&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String FourCC { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frameRate&quot; property, of type &quot;Edm.Double&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Double")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;frameRate&quot; property, of type &quot;Edm.Double&quot;.")]
        public System.Double FrameRate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.video&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.video", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Width { get; set; }
    }
}