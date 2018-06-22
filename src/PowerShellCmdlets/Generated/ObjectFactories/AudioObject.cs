// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.audio&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.audio&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AudioObject", DefaultParameterSetName = @"#microsoft.graph.audio")]
    [ODataType("microsoft.graph.audio")]
    public class New_AudioObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;album&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;album&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String album { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;albumArtist&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;albumArtist&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String albumArtist { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;artist&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;artist&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String artist { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitrate&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;bitrate&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 bitrate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;composers&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;composers&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String composers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;copyright&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;copyright&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String copyright { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disc&quot; property, of type &quot;Edm.Int16&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int16")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;disc&quot; property, of type &quot;Edm.Int16&quot;.")]
        public System.Int16 disc { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discCount&quot; property, of type &quot;Edm.Int16&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int16")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;discCount&quot; property, of type &quot;Edm.Int16&quot;.")]
        public System.Int16 discCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 duration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;genre&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;genre&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String genre { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasDrm&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;hasDrm&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasDrm { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isVariableBitrate&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;isVariableBitrate&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isVariableBitrate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;track&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;track&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 track { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trackCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;trackCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 trackCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 year { get; set; }
    }
}