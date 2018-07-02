// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;onenote&quot; object.</para>
    ///     <para type="description">GET ~/me/onenote</para>
    ///     <para type="description">Retrieves the &quot;onenote&quot; object (which is of type &quot;microsoft.graph.onenote&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.onenote")]
    [ResourceReference]
    public class Get_Me_Onenote : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        public System.Object[] notebooks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [Expandable]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteResource")]
        [Selectable]
        [Expandable]
        public System.Object[] resources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperation")]
        [Selectable]
        [Expandable]
        public System.Object[] operations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onenote&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote</para>
    ///     <para type="description">Creates the &quot;onenote&quot; object (which is of type &quot;microsoft.graph.onenote&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.onenote")]
    [ODataType("microsoft.graph.onenote")]
    [ResourceReference]
    public class New_Me_Onenote : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object[] notebooks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteResource")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.")]
        public System.Object[] resources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.")]
        public System.Object[] operations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onenote&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote</para>
    ///     <para type="description">Updates the &quot;onenote&quot; object (which is of type &quot;microsoft.graph.onenote&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.onenote")]
    [ODataType("microsoft.graph.onenote")]
    public class Update_Me_Onenote : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object[] notebooks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteResource")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.")]
        public System.Object[] resources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperation")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenote", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.")]
        public System.Object[] operations { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onenote&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote</para>
    ///     <para type="description">Removes the &quot;onenote&quot; object (which is of type &quot;microsoft.graph.onenote&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenote")]
    public class Remove_Me_Onenote : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/onenote";
        }
    }
}