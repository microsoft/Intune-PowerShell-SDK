// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Management.Automation;
    using System.Reflection;
    using System.Text;

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
            if (!isArray)
            {
                return value.ToODataStringInternal(oDataTypeFullName, isUrlValue);
            }
            else
            {
                if (value == null)
                {
                    // Null values aren't allowed in JSON for arrays, so return an empty array instead
                    return "[]";
                }
                else
                {
                    // This must be an array, so cast it as one
                    object[] values = (object[])value;

                    // We need to build the JSON string for the array of values
                    StringBuilder result = new StringBuilder();
                    result.Append('[');
                    bool first = true;
                    foreach (object val in values)
                    {
                        // Get the JSON value for this object
                        string jsonValue = val.ToODataStringInternal(oDataTypeFullName, isUrlValue);

                        // Append the JSON value to the result
                        if (!first)
                        {
                            // If this isn't the first value, prepend it with a comma
                            result.Append(',');
                        }
                        first = false;
                        result.Append(jsonValue);
                    }
                    result.Append(']');

                    return result.ToString();
                }
            }
        }

        private static string ToODataStringInternal(this object value, string oDataTypeFullName, bool isUrlValue = false)
        {
            // Null value
            if (value == null)
            {
                return "null";
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
                    string jsonStringValue = stringValue
                        .Replace("\\", "\\\\")
                        .Replace("\"", "\\\"")
                        .Replace("\n", "\\n")
                        .Replace("\r", "\\r")
                        .Replace("\t", "\\t")
                        .Replace("\f", "\\f")
                        .Replace("\b", "\\b");
                    return $"\"{jsonStringValue}\"";
                }
            }
            else if (value is byte[] bytes) // && oDataTypeFullName == "Edm.Binary"
            {
                string base64String = System.Convert.ToBase64String(bytes);

                if (isUrlValue)
                {
                    return $"'{base64String}'";
                }
                else
                {
                    return $"\"{base64String}\"";
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
                else // if (oDataTypeFullName == "Edm.DateTime" || oDataTypeFullName == "Edm.DateTimeOffset")
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
                else // if (oDataTypeFullName == "Edm.Duration")
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
            else if (value is Hashtable || value is PSObject)
            {
                // Local function to get property names and values
                IEnumerable<Tuple<string, object>> getPropertyNamesAndValues()
                {
                    if (value is Hashtable hashtable)
                    {
                        foreach (string key in hashtable.Keys)
                        {
                            if (!(key is string stringKey))
                            {
                                throw new ArgumentException($"Found a non-string key in hashtable: {key.ToString()}");
                            }

                            yield return Tuple.Create(stringKey, hashtable[stringKey]);
                        }
                    }
                    else if (value is PSObject psObject)
                    {
                        foreach (PSPropertyInfo prop in psObject.GetDefaultDisplayProperties())
                        {
                            yield return Tuple.Create(prop.Name, prop.Value);
                        }
                    }
                    else
                    {
                        throw new Exception("Value should be Hashtable or PSObject, but was null when casted");
                    }
                }

                // Manually construct the JSON from the properties
                StringBuilder jsonObject = new StringBuilder();
                jsonObject.Append('{');
                bool first = true;
                foreach (Tuple<string, object> keyValuePair in getPropertyNamesAndValues())
                {
                    bool valueIsArray = keyValuePair.Item2?.GetType().IsArray == true;
                    jsonObject.Append($"{(first ? " " : ", ")}\"{keyValuePair.Item1}\": {keyValuePair.Item2.ToODataString(null, isArray: valueIsArray, isUrlValue: isUrlValue)}");
                    first = false;
                }
                jsonObject.Append('}');

                return jsonObject.ToString();
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
