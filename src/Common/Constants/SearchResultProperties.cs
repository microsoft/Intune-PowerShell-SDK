// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.ODataConstants
{
    /// <summary>
    /// The properties that can be returned in a search result (i.e. GET on a collection).
    /// </summary>
    public static class SearchResultProperties
    {
        /// <summary>
        /// @odata.context
        /// </summary>
        public const string ODataContext = "@odata.context";

        /// <summary>
        /// @odata.count
        /// </summary>
        public const string ODataCount = "@odata.count";

        /// <summary>
        /// @odata.nextLink
        /// </summary>
        public const string ODataNextLink = "@odata.nextLink";

        /// <summary>
        /// value
        /// </summary>
        public const string Value = "value";

        /// <summary>
        /// @odata.type
        /// </summary>
        public const string ODataType = RequestProperties.ODataType;

        /// <summary>
        /// id
        /// </summary>
        public const string Id = RequestProperties.Id;
    }
}
