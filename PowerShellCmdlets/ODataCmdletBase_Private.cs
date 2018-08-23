// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;

    public abstract partial class ODataCmdletBase
    {
        private SdkAuthResult Auth()
        {
            try
            {
                if (AuthUtils.UseMsiAuth)
                {
                    return AuthUtils.RefreshMsiAuth();
                }
                else
                {
                    if (AuthUtils.UserHasNeverLoggedIn)
                    {
                        // User has not authenticated
                        string cmdletName = $"{PowerShellCmdlets.Connect.CmdletVerb}-{PowerShellCmdlets.Connect.CmdletNoun}";
                        throw new PSAuthenticationError(
                            new InvalidOperationException($"Not authenticated.  Please use the \"{cmdletName}\" command to authenticate."),
                            "NotAuthenticated",
                            ErrorCategory.AuthenticationError,
                            null);
                    }

                    // Refresh the token if required
                    return AuthUtils.RefreshAdalAuth();

                }
            }
            catch (AdalException ex)
            {
                // Catch and bubble up any ADAL failures (this should never happen)
                throw new PSAuthenticationError(
                    ex,
                    "AuthenticationExpired",
                    ErrorCategory.AuthenticationError,
                    "Failed to obtain access token");
            }
        }

        /// <summary>
        /// Runs a cmdlet.
        /// </summary>
        private void Run()
        {
            // Get all the evaluated values
            string httpMethodString = this.GetHttpMethod();
            string resourcePath = this.GetResourcePath();
            IDictionary<string, string> queryOptions = this.GetUrlQueryOptions();
            HttpRequestHeaders headers = this.GetHeaders();
            object contentObject = this.GetContent();
            string contentType = this.GetContentType();

            // Determine whether or not the call should proceed
            if (!this.ProceedWithCall(
                httpMethodString,
                resourcePath,
                queryOptions,
                contentObject,
                contentType))
            {
                return;
            }

            // Build the URL
            string requestUrl;
            if (resourcePath == null)
            {
                throw new PSGraphSDKException(
                    new ArgumentNullException(nameof(this.GetResourcePath)),
                    "NullResourceUrl",
                    ErrorCategory.InvalidArgument,
                    resourcePath);
            }

            if (Uri.IsWellFormedUriString(resourcePath, UriKind.Relative))
            {
                requestUrl = this.BuildUrl(resourcePath);
            }
            else if (Uri.IsWellFormedUriString(resourcePath, UriKind.Absolute))
            {
                // Since this is an absolute URL, it must be the full request URL
                requestUrl = resourcePath;
            }
            else
            {
                throw new PSGraphSDKException(
                    new ArgumentException("A valid URL could not be constructed - ensure that the provided resource path is a valid relative or absolute URL", nameof(this.GetResourcePath)),
                    "InvalidResourceUrl",
                    ErrorCategory.InvalidArgument,
                    resourcePath);
            }

            // Add the query options to the URL
            if (queryOptions != null && queryOptions.Any())
            {
                string queryOptionsString;
                if (requestUrl.Contains("?"))
                {
                    // Query options already exist in the URL
                    queryOptionsString = "&";
                }
                else
                {
                    // Query options don't already exist in the URL
                    queryOptionsString = "?";
                }

                // Construct the query options string
                queryOptionsString += string.Join("&", queryOptions.Select((entry) => $"{entry.Key}={entry.Value}"));

                // Append the query options to the URL
                requestUrl += queryOptionsString;
            }

            // Get HTTP method
            if (string.IsNullOrWhiteSpace(httpMethodString))
            {
                throw new PSGraphSDKException(
                    new ArgumentNullException(nameof(this.GetHttpMethod)),
                    "InvalidHttpMethod",
                    ErrorCategory.InvalidArgument,
                    httpMethodString);
            }
            HttpMethod httpMethod = new HttpMethod(httpMethodString);

            // Get content
            HttpContent content = null;
            if (contentObject != null)
            {
                // Create the HttpContent object if there is any content
                content = this.WriteContent(contentObject);
            }

            // Prepare the HTTP request
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(httpMethod, requestUrl);
            foreach (var entry in headers)
            {
                // Add the headers
                requestMessage.Headers.Add(entry.Key, entry.Value);
            }
            requestMessage.Headers.UserAgent.Add(new ProductInfoHeaderValue(AssemblyName, AssemblyVersion));
            string requestContent = null;
            if (content != null)
            {
                // Set the content type
                content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

                // Get the content before making the call
                requestMessage.Content = content;

                // We need to evaluate the raw content value before making the call otherwise the content object will get disposed
                requestContent = requestMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            // Debug request message
            this.WriteDebug(
$@"
-----------
| Request |
-----------
{requestMessage.Method.Method} {requestMessage.RequestUri.ToString()}
{JsonUtils.WriteJson(headers, true)}

{requestContent ?? "<No request content>"}
");

            // Make the HTTP request
            HttpResponseMessage responseMessage = httpClient.SendAsync(requestMessage).GetAwaiter().GetResult();
            string responseContent = responseMessage.Content?.ReadAsStringAsync().GetAwaiter().GetResult();

            // Debug response message
            this.WriteDebug(
$@"
------------
| Response |
------------
Status: {responseMessage.ReasonPhrase}
{JsonUtils.WriteJson(responseMessage.Headers, true)}

{responseContent ?? "<No response content>"}
");

            // Handle the result
            if (responseMessage.IsSuccessStatusCode)
            {
                // Get the result
                object cmdletResult = null;
                if (!string.IsNullOrWhiteSpace(responseContent))
                {
                    cmdletResult = this.ReadResponse(responseContent);
                }

                // Write the result to the pipeline
                if (cmdletResult != null)
                {
                    if (cmdletResult is IEnumerable collectionResult)
                    {
                        // Write the items in the collection to the pipeline
                        try
                        {
                            this.WriteObject(collectionResult, true);
                        }
                        catch (PipelineStoppedException)
                        {
                            // The pipeline was stopped, so swallow the exception and don't output anything else
                        }
                    }
                    else
                    {
                        // Write the single object to the pipeline
                        this.WriteObject(cmdletResult);
                    }
                }
            }
            else
            {
                // Build the error message
                string errorMessage = $"{(int)responseMessage.StatusCode} {responseMessage.ReasonPhrase}";
                if (responseContent != null)
                {
                    errorMessage += Environment.NewLine + responseContent;
                }

                // Convert request message to a PowerShell object
                PSObject powerShellRequestObject = new PSObject();
                powerShellRequestObject.Members.Add(new PSNoteProperty("HttpMethod", requestMessage.Method.Method));
                powerShellRequestObject.Members.Add(new PSNoteProperty("URL", requestMessage.RequestUri.ToString()));
                PSObject powerShellRequestObjectHeaders = new PSObject();
                foreach (var header in requestMessage.Headers)
                {
                    powerShellRequestObjectHeaders.Members.Add(new PSNoteProperty(header.Key, string.Join(",", header.Value)));
                }
                powerShellRequestObject.Members.Add(new PSNoteProperty("Headers", powerShellRequestObjectHeaders));
                if (requestContent != null)
                {
                    powerShellRequestObject.Members.Add(new PSNoteProperty("Content", requestContent));
                }

                // Convert response message to a PowerShell object
                PSObject powerShellResponseObject = new PSObject();
                powerShellResponseObject.Members.Add(new PSNoteProperty("HttpStatusCode", (int)responseMessage.StatusCode));
                powerShellResponseObject.Members.Add(new PSNoteProperty("HttpStatusPhrase", responseMessage.ReasonPhrase));
                PSObject powerShellResponseObjectHeaders = new PSObject();
                foreach (var header in responseMessage.Headers)
                {
                    powerShellResponseObjectHeaders.Members.Add(new PSNoteProperty(header.Key, string.Join(",", header.Value)));
                }
                powerShellResponseObject.Members.Add(new PSNoteProperty("Headers", powerShellResponseObjectHeaders));
                powerShellResponseObject.Members.Add(new PSNoteProperty("Content",
                    JsonUtils.TryReadAsPowerShellObject(responseContent, out object powerShellErrorResponseObject)
                        ? powerShellErrorResponseObject
                        : responseContent));

                // Create PowerShell error object
                PSObject powerShellErrorObject = new PSObject();
                powerShellErrorObject.Members.Add(new PSNoteProperty("Request", powerShellRequestObject));
                powerShellErrorObject.Members.Add(new PSNoteProperty("Response", powerShellResponseObject));

                throw new PSGraphSDKException(
                    new HttpRequestException(errorMessage),
                    "HttpRequestError",
                    ErrorCategory.ConnectionError,
                    powerShellErrorObject);
            }
        }
    }
}
