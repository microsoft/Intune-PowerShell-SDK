// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;outlook&quot; object.</para>
    ///     <para type="description">GET ~/me/outlook</para>
    ///     <para type="description">Retrieves the &quot;outlook&quot; object (which is of type &quot;microsoft.graph.outlookUser&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Outlook", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.outlookUser")]
    [ResourceReference]
    public class Get_Me_Outlook : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookCategory")]
        [Selectable]
        [Expandable]
        public System.Object[] masterCategories { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.outlookUser&quot; object.</para>
    ///     <para type="description">POST ~/me/outlook</para>
    ///     <para type="description">Creates the &quot;outlook&quot; object (which is of type &quot;microsoft.graph.outlookUser&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Outlook", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.outlookUser")]
    [ODataType("microsoft.graph.outlookUser")]
    [ResourceReference]
    public class New_Me_Outlook : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookUser", HelpMessage = @"The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.")]
        public System.Object[] masterCategories { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.outlookUser&quot;.</para>
    ///     <para type="description">PATCH ~/me/outlook</para>
    ///     <para type="description">Updates the &quot;outlook&quot; object (which is of type &quot;microsoft.graph.outlookUser&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Outlook", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.outlookUser")]
    [ODataType("microsoft.graph.outlookUser")]
    public class Update_Me_Outlook : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookUser", HelpMessage = @"The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.")]
        public System.Object[] masterCategories { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.outlookUser&quot; object.</para>
    ///     <para type="description">DELETE ~/me/outlook</para>
    ///     <para type="description">Removes the &quot;outlook&quot; object (which is of type &quot;microsoft.graph.outlookUser&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Outlook", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.outlookUser")]
    public class Remove_Me_Outlook : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/outlook";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/outlook/supportedLanguages</para>
    ///     <para type="description">The function &quot;microsoft.graph.supportedLanguages&quot;, which exists on the type &quot;microsoft.graph.outlookUser&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.localeInfo&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Outlook_SupportedLanguages", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.outlookUser")]
    public class Invoke_Me_Outlook_SupportedLanguages : FunctionReturningCollectionCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/outlook/supportedLanguages({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/outlook/supportedTimeZones</para>
    ///     <para type="description">The function &quot;microsoft.graph.supportedTimeZones&quot;, which exists on the type &quot;microsoft.graph.outlookUser&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.timeZoneInformation&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Outlook_SupportedTimeZones", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.outlookUser")]
    public class Invoke_Me_Outlook_SupportedTimeZones : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;TimeZoneStandard&quot; parameter, which is accepted by the &quot;microsoft.graph.supportedTimeZones&quot; function.</para>
        ///     <para type="description">
        ///          Valid values: &apos;windows&apos;, &apos;iana&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.timeZoneStandard")]
        [Selectable]
        [ValidateSet(@"windows", @"iana")]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;TimeZoneStandard&quot; parameter, which is accepted by the &quot;microsoft.graph.supportedTimeZones&quot; function.")]
        public System.String TimeZoneStandard { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook/supportedTimeZones({this.GetFunctionUrlSegment()})";
        }
    }
}