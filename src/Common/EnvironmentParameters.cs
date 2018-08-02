// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    /// <summary>
    /// Keeps track of the parameters used by an AAD environment.
    /// </summary>
    internal class EnvironmentParameters
    {
        private const string powerShellClientId = "d1ddf0e4-d672-4dae-b554-9d5bdfd93547"; // PowerShell-Intune
        //private const string powerShellClientId = "ae9acab0-7171-4115-83d9-18b4d80969b8"; // PowerShell
        private const string applicationRedirectLink = "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>
        /// Location of the auth endpoint.
        /// </summary>
        internal string AuthUrl { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        internal string ResourceId { get; set; }

        /// <summary>
        /// The location of the resource.
        /// </summary>
        internal string GraphBaseAddress { get; set; }

        /// <summary>
        /// The client ID to use when authenticating.
        /// </summary>
        internal string AppId { get; set; }

        /// <summary>
        /// The redirect link to use when authenticating.
        /// </summary>
        internal string RedirectLink { get; set; }

        /// <summary>
        /// The schema version to use when making a Graph call.
        /// </summary>
        internal string SchemaVersion { get; set; }

        /// <summary>
        /// Creates a new EnvironmentParameters object.
        /// </summary>
        internal EnvironmentParameters() { }

        /// <summary>
        /// Copies an existing EnvironmentParameters object.
        /// </summary>
        /// <param name="toCopy">The EnvironmentParameters object to copy</param>
        internal EnvironmentParameters(EnvironmentParameters toCopy)
        {
            this.AuthUrl = toCopy.AuthUrl;
            this.ResourceId = toCopy.ResourceId;
            this.GraphBaseAddress = toCopy.GraphBaseAddress;
            this.AppId = toCopy.AppId;
            this.RedirectLink = toCopy.RedirectLink;
            this.SchemaVersion = toCopy.SchemaVersion;
        }

        /// <summary>
        /// Creates a copy of this instance of <see cref="EnvironmentParameters"/>.
        /// </summary>
        /// <returns>The copy of this instance.</returns>
        internal EnvironmentParameters Copy()
        {
            return new EnvironmentParameters(this);
        }

        internal static EnvironmentParameters Prod { get; } = new EnvironmentParameters()
        {
            AuthUrl = "https://login.microsoftonline.com/common",
            ResourceId = "https://graph.microsoft.com",
            GraphBaseAddress = "https://graph.microsoft.com",
            AppId = powerShellClientId,
            RedirectLink = applicationRedirectLink,
            SchemaVersion = "v1.0",
        };

        internal static EnvironmentParameters PPE { get; } = new EnvironmentParameters()
        {
            AuthUrl = "https://login.windows-ppe.net/common",
            ResourceId = "https://graph.microsoft-ppe.com",
            GraphBaseAddress = "https://graph.microsoft-ppe.com",
            AppId = powerShellClientId,
            RedirectLink = applicationRedirectLink,
            SchemaVersion = "v1.0",
        };
    }
}
