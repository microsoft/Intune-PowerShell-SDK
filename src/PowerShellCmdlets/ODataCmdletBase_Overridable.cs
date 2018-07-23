// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Newtonsoft.Json.Linq;

    public abstract partial class ODataCmdletBase
    {
        /// <summary>
        /// Returns the HTTP method to be used for the network call.  This method should never return null.
        /// </summary>
        /// <remarks>
        /// This method returns "GET" if it is not overridden.
        /// </remarks>
        /// <returns>The HTTP method.</returns>
        internal virtual string GetHttpMethod()
        {
            return "GET";
        }

        /// <summary>
        /// Returns the path to the resource.  This may be either a relative or absolute URL.  This method should never return null.
        /// </summary>
        /// <returns>The path to the resource.</returns>
        internal abstract string GetResourcePath();

        /// <summary>
        /// Returns a mapping of query options to their values.  This method should never return null.
        /// Implementations of this method should first call <code>base.GetUrlQueryOptions()</code> and then
        /// add additional query options to the result.
        /// </summary>
        /// <remarks>
        /// The keys should be the full query option name (i.e. WITH the "$" prefix for "$select", "$expand", etc.).
        /// </remarks>
        /// <returns>The mapping of query options to their values.</returns>
        internal virtual IDictionary<string, string> GetUrlQueryOptions()
        {
            return new Dictionary<string, string>();
        }

        /// <summary>
        /// Returns the content to be sent in the network call.  This method may return null if there is no content to send.
        /// </summary>
        /// <remarks>
        /// This method returns null if it is not overridden.
        /// </remarks>
        /// <returns>The request content.</returns>
        internal virtual object GetContent()
        {
            return null;
        }

        /// <summary>
        /// Returns the content (MIME) type for the HTTP request.
        /// </summary>
        /// <remarks>
        /// This method returns "application/json" if it is not overridden.
        /// </remarks>
        /// <returns>The request's content type.</returns>
        internal virtual string GetContentType()
        {
            return "application/json";
        }

        /// <summary>
        /// Returns a mapping of header names to their values.  This method should never return null.
        /// Implementations of this method should first call <code>base.GetHeaders()</code> and then
        /// add additional headers to the result.
        /// </summary>
        /// <returns></returns>
        internal virtual HttpRequestHeaders GetHeaders()
        {
            // Create the headers and add the auth token
            HttpRequestHeaders headers = new HttpClient().DefaultRequestHeaders;
            AuthResult authResult = this.Auth();
            headers.Authorization = authResult.AuthenticationHeaderValue;

            return headers;
        }

        /// <summary>
        /// A confirmation step that the call should proceed to be made.  This method allows for derived types to have an opportunity to
        /// stop execution without throwing an exception.
        /// </summary>
        /// <param name="httpMethod">The evaluated HTTP method</param>
        /// <param name="resourcePath">The evaluated OData resource path</param>
        /// <param name="queryOptions">The evaluated query options</param>
        /// <param name="content">The evaluated content</param>
        /// <param name="contentType">The evaluated MIME type</param>
        /// <returns>True if the cmdlet should proceed with making the HTTP call, otherwise false.</returns>
        internal virtual bool ProceedWithCall(
            string httpMethod,
            string resourcePath,
            IDictionary<string, string> queryOptions,
            object content,
            string contentType)
        {
            return true;
        }

        /// <summary>
        /// Converts the content obtained from the <see cref="GetContent"/> method into an <see cref="HttpContent"/> object.
        /// </summary>
        /// <remarks>
        /// This method defaults to converting the object to a JSON string and then wrapping it in a <see cref="StringContent"/> object.
        /// </remarks>
        /// <param name="content">The content to be converted</param>
        /// <returns>The converted HttpContent object.</returns>
        internal virtual HttpContent WriteContent(object content)
        {
            string contentString = JsonUtils.WriteJson(content);
            HttpContent result = new StringContent(contentString);
            return result;
        }

        /// <summary>
        /// Converts the body of an HTTP response to a C# object.
        /// </summary>
        /// <remarks>
        /// This method defaults to assuming a JSON response body, and then converting it to a <see cref="System.Management.Automation.PSObject"/> instance.
        /// If the response body is a primitive value, it is returned without wrapping it in a <see cref="System.Management.Automation.PSObject"/> instance.
        /// </remarks>
        /// <param name="content">The HTTP response body</param>
        /// <returns>The converted object.</returns>
        internal virtual object ReadResponse(string content)
        {
            JToken jsonToken = JsonUtils.ReadJson(content);
            return JsonUtils.ToPowerShellObject(jsonToken);
        }

        /// <summary>
        /// The parameters that are added at runtime.
        /// </summary>
        /// <returns>A <see cref="System.Management.Automation.RuntimeDefinedParameterDictionary"/>.</returns>
        public object GetDynamicParameters()
        {
            return this.DynamicParameters;
        }
    }
}
