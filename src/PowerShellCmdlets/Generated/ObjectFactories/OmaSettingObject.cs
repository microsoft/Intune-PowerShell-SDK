// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.omaSetting&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.omaSetting&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OmaSettingObject", DefaultParameterSetName = @"#microsoft.graph.omaSetting")]
    [ODataType("microsoft.graph.omaSetting")]
    public class New_OmaSettingObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.omaSetting&quot; type.</para>
        ///     <para type="description">Display Name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSetting", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBoolean", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingDateTime", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingString", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingFloatingPoint", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingInteger", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.omaSetting&quot; type.</para>
        ///     <para type="description">Description.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSetting", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBoolean", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingDateTime", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingString", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingFloatingPoint", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingInteger", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.omaSetting&quot; type.</para>
        ///     <para type="description">OMA.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSetting", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBoolean", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingDateTime", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingString", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingFloatingPoint", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingInteger", HelpMessage = @"The &quot;omaUri&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OmaUri { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingBase64&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingBase64")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingBase64&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingBase64 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.omaSettingBase64&quot; type.</para>
        ///     <para type="description">File name associated with the Value property (*.cer | *.crt ).</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", HelpMessage = @"The &quot;fileName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String FileName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;value&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.omaSettingBase64&quot; type.</para>
        ///     <para type="description">Value. (Base64 encoded string)</para>
        /// </summary>
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBase64", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBoolean", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingDateTime", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingString", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingFloatingPoint", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingInteger", HelpMessage = @"The &quot;value&quot; property, of type &quot;Edm.String&quot;.")]
        public System.Object Value { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingBoolean&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingBoolean")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingBoolean", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingBoolean&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingBoolean { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingStringXml&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingStringXml")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingStringXml", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingStringXml&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingStringXml { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingDateTime&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingDateTime")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingDateTime", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingDateTime&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingDateTime { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingString&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingString")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingString", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingString&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingString { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingFloatingPoint&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingFloatingPoint")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingFloatingPoint", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingFloatingPoint&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingFloatingPoint { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingInteger&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.omaSettingInteger")]
        [Parameter(ParameterSetName = @"#microsoft.graph.omaSettingInteger", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.omaSettingInteger&quot; type.")]
        public System.Management.Automation.SwitchParameter OmaSettingInteger { get; set; }
    }
}