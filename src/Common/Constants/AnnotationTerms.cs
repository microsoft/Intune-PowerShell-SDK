// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.ODataConstants
{
    /// <summary>
    /// OData annotation term names.
    /// </summary>
    public static class AnnotationTerms
    {
        /// <summary>
        /// The "Computed" term.  This annotation (if set to "true") identifies a
        /// property which cannot be written to with an insert, update or delete operation.
        /// </summary>
        public const string Computed = "Org.OData.Core.V1.Computed";

        /// <summary>
        /// The "Immutable" term.  This annotation (if set to "true") identifies a
        /// property which cannot be written to with an update or delete operation.
        /// </summary>
        public const string Immutable = "Org.OData.Core.V1.Immutable";

        /// <summary>
        /// The "InsertRestrictions" term.  This annotation (if the containing record's
        /// "Insertable" property is set to "true") identifies a resource which cannot be
        /// created through the given property.
        /// </summary>
        public const string InsertRestrictions = "Org.OData.Core.V1.InsertRestrictions";

        /// <summary>
        /// Indicates that the given property does not support insert operations.
        /// </summary>
        public const string Insertable = "Insertable";

        /// <summary>
        /// The "UpdateRestrictions" term.  This annotation (if the containing record's
        /// "Updatable" property is set to "true") identifies a resource which cannot be
        /// updated through the given property.
        /// </summary>
        public const string UpdateRestrictions = "Org.OData.Core.V1.UpdateRestrictions";

        /// <summary>
        /// Indicates that the given property does not support update operations.
        /// </summary>
        public const string Updatable = "Updatable";

        /// <summary>
        /// The "DeleteRestrictions" term.  This annotation (if the containing record's
        /// "Deletable" property is set to "true") identifies a resource which cannot be
        /// deleted through the given property.
        /// </summary>
        public const string DeleteRestrictions = "Org.OData.Core.V1.DeleteRestrictions";

        /// <summary>
        /// Indicates that the given property does not support delete operations.
        /// </summary>
        public const string Deletable = "Deletable";
    }
}
