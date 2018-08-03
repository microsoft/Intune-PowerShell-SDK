// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
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
        public System.String Album { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;albumArtist&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;albumArtist&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AlbumArtist { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;artist&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;artist&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Artist { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bitrate&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;bitrate&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 Bitrate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;composers&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;composers&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Composers { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;copyright&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;copyright&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Copyright { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;disc&quot; property, of type &quot;Edm.Int16&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int16")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;disc&quot; property, of type &quot;Edm.Int16&quot;.")]
        public System.Int16 Disc { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discCount&quot; property, of type &quot;Edm.Int16&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int16")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;discCount&quot; property, of type &quot;Edm.Int16&quot;.")]
        public System.Int16 DiscCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;duration&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 Duration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;genre&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;genre&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Genre { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasDrm&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;hasDrm&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean HasDrm { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isVariableBitrate&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;isVariableBitrate&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsVariableBitrate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;track&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;track&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Track { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trackCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;trackCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 TrackCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.audio&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.audio", HelpMessage = @"The &quot;year&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Year { get; set; }
    }
}