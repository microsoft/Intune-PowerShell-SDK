// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.resourceOperation&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.resourceOperation&quot; (or one of its derived types).</para>
    ///     <para type="description">This defines an operation or action that can be performed on an Intune resource (or entity).  Common operations are Read, Delete, Update or Create.  These operations provide basic management of the underlying Intune resource itself.  In some cases, an Intune resource can have operations that are used by the resource to take action in combination with other resources.  For example, the Assign operation is used to assign a MobileApp resource to an AAD security group.  Resource operations cannot be modified for built-in roles.This defines an operation or action that can be performed on an Intune resource (or entity).  Common operations are Get, List, Delete, Update or Create.  These operations provide basic management of the underlying Intune resource itself.  In some cases, an Intune resource can have operations that are used by the resource to take action in combination with other resources.  For example, the &quot;Assign&quot; operation is used to assign a MobileApp resource to an AAD security group.  Resource operations cannot be modified for built-in roles.</para>
    /// </summary>
    [Cmdlet("New", "ResourceOperationObject", DefaultParameterSetName = @"microsoft.graph.resourceOperation")]
    [ODataType("microsoft.graph.resourceOperation")]
    public class New_ResourceOperationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Name of the Resource this operation is performed on.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }
    }
}