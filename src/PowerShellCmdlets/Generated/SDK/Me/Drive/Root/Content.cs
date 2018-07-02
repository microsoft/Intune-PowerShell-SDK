// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;content&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/drive/root/content</para>
    ///     <para type="description">Retrieves the data stream from the &quot;content&quot; object.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Root_Content")]
    [ODataType("Edm.Stream")]
    public class Get_Me_Drive_Root_Content : GetStreamCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/content";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;content&quot; property on a &quot;microsoft.graph.driveItem&quot; object.</para>
    ///     <para type="description">PUT ~/me/drive/root/content</para>
    ///     <para type="description">Sets the data for the &quot;content&quot; property on a &quot;microsoft.graph.driveItem&quot; object.</para>
    /// </summary>
    [Cmdlet("Set", "Me_Drive_Root_Content", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("Edm.Stream")]
    public class Set_Me_Drive_Root_Content : UpdateStreamCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/content";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;content&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/root/content/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;content&quot; resource (which is of type &quot;Edm.Stream&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Root_ContentData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("Edm.Stream")]
    public class Remove_Me_Drive_Root_ContentData : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/content";
        }
    }
}