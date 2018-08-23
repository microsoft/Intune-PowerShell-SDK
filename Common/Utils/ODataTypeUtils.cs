// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Management.Automation;
    using System.Reflection;

    /// <summary>
    /// Utility methods for OData (Edm) type conversions.
    /// </summary>
    internal static class ODataTypeUtils
    {
        internal static ODataTypeAttribute GetODataTypeAttribute(this PropertyInfo cmdletProperty)
        {
            if (cmdletProperty == null)
            {
                throw new ArgumentNullException(nameof(cmdletProperty));
            }

            return cmdletProperty.GetCustomAttribute<ODataTypeAttribute>(false);
        }

        internal static ODataTypeAttribute GetODataTypeAttribute(this Cmdlet cmdlet)
        {
            if (cmdlet == null)
            {
                throw new ArgumentNullException(nameof(cmdlet));
            }

            return cmdlet.GetType().GetCustomAttribute<ODataTypeAttribute>();
        }

        /// <summary>
        /// Gets the name of a parameter which can accept a reference URL for the given type.
        /// </summary>
        /// <param name="typeFullName">The fully qualified name of the type (i.e. including the namespace)</param>
        /// <returns>The name of the parameter</returns>
        internal static string GetReferenceUrlParameterName(string typeFullName)
        {
            if (string.IsNullOrWhiteSpace(typeFullName))
            {
                throw new ArgumentException("Type name cannot be null or whitespace", nameof(typeFullName));
            }

            // Get the short name of the type
            string shortTypeName = GetShortTypeName(typeFullName);

            return $"{shortTypeName}ReferenceUrl";
        }

        /// <summary>
        /// Gets the short name of a type given its full type name.
        /// </summary>
        /// <param name="typeFullName">The type's full name</param>
        /// <returns>The type's short name.</returns>
        internal static string GetShortTypeName(string typeFullName)
        {
            if (string.IsNullOrWhiteSpace(typeFullName))
            {
                throw new ArgumentException("Type name cannot be null or whitespace", nameof(typeFullName));
            }

            return typeFullName.Substring(typeFullName.LastIndexOf('.') + 1);
        }

        internal static string ToODataString(this object value, string oDataTypeFullName, bool isArray = false, bool isUrlValue = false)
        {
            if (string.IsNullOrWhiteSpace(oDataTypeFullName))
            {
                throw new ArgumentException("The OData type name cannot be null or whitespace", nameof(oDataTypeFullName));
            }

            // Null value
            if (value == null)
            {
                if (isArray)
                {
                    return "[]";
                }
                else
                {
                    return "null";
                }
            }
            // Boolean
            else if (value is bool boolean)
            {
                return boolean ? "true" : "false";
            }
            // String
            else if (value is string stringValue)
            {
                if (isUrlValue)
                {
                    return $"'{stringValue}'";
                }
                else
                {
                    return $"\"{stringValue}\"";
                }
            }
            // Date, DateTime or DateTimeOffset
            else if (value is DateTimeOffset date)
            {
                // Date
                if (oDataTypeFullName == "Edm.Date")
                {
                    string dateString = date.ToString("yyyy-MM-dd");

                    if (isUrlValue)
                    {
                        return $"'{dateString}'";
                    }
                    else
                    {
                        return $"\"{dateString}\"";
                    }
                }
                // DateTime or DateTimeOffset
                else if (oDataTypeFullName == "Edm.DateTime" || oDataTypeFullName == "Edm.DateTimeOffset")
                {
                    string dateTimeString = date.ToString("o"); // yyyy-MM-ddTHH:mm:ssZ

                    if (isUrlValue)
                    {
                        return $"'{dateTimeString}'";
                    }
                    else
                    {
                        return $"\"{dateTimeString}\"";
                    }
                }
            }
            // Time or TimeOfDay
            else if (value is TimeSpan timeSpan)
            {
                // Time or TimeOfDay
                if (oDataTypeFullName == "Edm.Time" || oDataTypeFullName == "Edm.TimeOfDay")
                {
                    string timeString = $"{timeSpan.Hours}:{timeSpan.Minutes}{(timeSpan.TotalSeconds > 0 ? ":" + timeSpan.TotalSeconds : string.Empty)}";

                    if (isUrlValue)
                    {
                        return $"'{timeString}'";
                    }
                    else
                    {
                        return $"\"{timeString}\"";
                    }
                }
                // Duration
                else if (oDataTypeFullName == "Edm.Duration")
                {
                    string durationString;
                    if (timeSpan == TimeSpan.Zero)
                    {
                        durationString = "PT0S";
                    }
                    else
                    {
                        string negative = timeSpan < TimeSpan.Zero ? "-" : string.Empty;
                        TimeSpan absoluteDuration = timeSpan.Duration();
                        string days = absoluteDuration.Days > 0 ? absoluteDuration.Days.ToString() + "D" : string.Empty;
                        string hours = absoluteDuration.Hours > 0 ? absoluteDuration.Hours.ToString() + "H" : string.Empty;
                        string minutes = absoluteDuration.Minutes > 0 ? absoluteDuration.Minutes.ToString() + "M" : string.Empty;
                        string seconds = absoluteDuration.Seconds > 0 ? absoluteDuration.Seconds.ToString() + "S" : string.Empty;
                        durationString = $"{negative}P{days}";

                        string timeString = $"{hours}{minutes}{seconds}";
                        if (timeString != string.Empty)
                        {
                            durationString += $"T{timeString}";
                        }
                    }

                    if (isUrlValue)
                    {
                        return $"duration'{durationString}'";
                    }
                    else
                    {
                        return $"\"{durationString}\"";
                    }
                }
            }
            else
            {
                // TODO: Find a way to call the "ToODataString()" method for properties inside this object
                return JsonUtils.WriteJson(value, false);
            }

            // We should never get here
            throw new ArgumentException($"Invalid parameter type ({value.GetType()}) for '{oDataTypeFullName}' OData property.");
        }
    }
}
