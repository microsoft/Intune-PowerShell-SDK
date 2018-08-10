// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Management.Automation;

    /// <summary>
    /// Checks that a given property's value represents a valid URL string.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal class ValidateUrlAttribute : ValidateEnumeratedArgumentsAttribute
    {
        /// <summary>
        /// The kind of URL (e.g. relative, absolute).
        /// </summary>
        private UriKind UriKind { get; set; }

        /// <summary>
        /// Creates a new <see cref="ValidateUrlAttribute"/>.
        /// </summary>
        /// <param name="uriKind">The kind or URL</param>
        public ValidateUrlAttribute(UriKind uriKind = UriKind.Absolute)
        {
            this.UriKind = uriKind;
        }

        /// <summary>
        /// Validates that the given object represents a valid URL string.
        /// </summary>
        /// <param name="url">The URL to validate</param>
        protected override void ValidateElement(object url)
        {
            if (url == null)
            {
                throw new ValidationMetadataException("The provided URL cannot be null");
            }

            string stringUrl = url as string;
            if (stringUrl == null)
            {
                throw new ValidationMetadataException("The provided URL must be a string");
            }

            if (!Uri.IsWellFormedUriString(stringUrl, UriKind))
            {
                string errorMessage = "The provided URL is not valid";
                if (UriKind == UriKind.Absolute)
                {
                    errorMessage += " - the URL must be an absolute URL";
                }
                else
                {
                    errorMessage += " - the URL may be a relative URL";
                }
                
                throw new ValidationMetadataException(errorMessage);
            }
        }
    }
}
