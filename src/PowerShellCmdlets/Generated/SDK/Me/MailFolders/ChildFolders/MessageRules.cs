// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.messageRule&quot; objects.</para>
    ///     <para type="description">GET ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.messageRule&quot; objects in the &quot;messageRules&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_MailFolders_ChildFolders_MessageRules", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.messageRule")]
    [ResourceIdPropertyName("messageRuleId")]
    [ResourceReference]
    public class Get_Me_MailFolders_ChildFolders_MessageRules : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.")]
        public System.String messageRuleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 sequence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Sortable]
        public System.Object conditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRuleActions")]
        [Selectable]
        [Sortable]
        public System.Object actions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Sortable]
        public System.Object exceptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean hasError { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isReadOnly { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules/{messageRuleId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.messageRule&quot; object.</para>
    ///     <para type="description">POST ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.messageRule&quot; object to the &quot;messageRules&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_MailFolders_ChildFolders_MessageRules", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.messageRule")]
    [ODataType("microsoft.graph.messageRule")]
    [ResourceReference]
    public class New_Me_MailFolders_ChildFolders_MessageRules : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 sequence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object conditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRuleActions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.")]
        public System.Object actions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object exceptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasError { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadOnly { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.messageRule&quot;.</para>
    ///     <para type="description">PATCH ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_MailFolders_ChildFolders_MessageRules", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.messageRule")]
    [ODataType("microsoft.graph.messageRule")]
    [ResourceIdPropertyName("messageRuleId")]
    public class Update_Me_MailFolders_ChildFolders_MessageRules : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.")]
        public System.String messageRuleId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sequence&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 sequence { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;conditions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object conditions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRuleActions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;actions&quot; property, of type &quot;microsoft.graph.messageRuleActions&quot;.")]
        public System.Object actions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRulePredicates")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;exceptions&quot; property, of type &quot;microsoft.graph.messageRulePredicates&quot;.")]
        public System.Object exceptions { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;hasError&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean hasError { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.messageRule&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.messageRule", HelpMessage = @"The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isReadOnly&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isReadOnly { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules/{messageRuleId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.messageRule&quot; object.</para>
    ///     <para type="description">DELETE ~/me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules/messageRuleId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.messageRule&quot; object from the &quot;messageRules&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_MailFolders_ChildFolders_MessageRules", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.messageRule")]
    [ResourceIdPropertyName("messageRuleId")]
    public class Remove_Me_MailFolders_ChildFolders_MessageRules : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.messageRule&quot; object in the &quot;messageRules&quot; collection.")]
        public System.String messageRuleId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mailFolder&quot; object in the &quot;mailFolders&quot; collection.")]
        public System.String mailFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/mailFolders/{mailFolderId}/childFolders/{childFolderId}/messageRules/{messageRuleId}";
        }
    }
}