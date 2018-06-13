// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;

    internal static class JsonUtils
    {
        private static readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.None,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            Formatting = Formatting.None,
            NullValueHandling = NullValueHandling.Include,
            StringEscapeHandling = StringEscapeHandling.EscapeNonAscii,
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };

        /// <summary>
        /// Serializes an object into a JSON string.
        /// </summary>
        /// <param name="obj">The object to serialize</param>
        /// <param name="prettyPrint">Whether or not to pretty print (i.e. indent) the JSON output</param>
        /// <returns>The JSON string.</returns>
        internal static string WriteJson(object obj, bool prettyPrint = false)
        {
            _jsonSettings.Formatting = prettyPrint ? Formatting.Indented : Formatting.None;

            if (obj is PSObject psObject)
            {
                return JsonConvert.SerializeObject(psObject.BaseObject, _jsonSettings);
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _jsonSettings);
            }
        }

        /// <summary>
        /// Deserializes a JSON string into an object of the given type.
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <returns>The deserialized object.</returns>
        internal static T ReadJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _jsonSettings);
        }

        /// <summary>
        /// Deserializes a JSON string into a JToken object.
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <returns>The deserialized JToken object.</returns>
        internal static JToken ReadJson(string json)
        {
            return ReadJson<JToken>(json);
        }

        /// <summary>
        /// Safely deserializes a JSON string into an object of the given type.
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <param name="result">The deserialized object if the string is a valid JSON string, otherwise null</param>
        /// <returns>True if the string is a valid JSON string, otherwise false.</returns>
        internal static bool TryReadJson<T>(string json, out T result)
        {
            try
            {
                result = ReadJson<T>(json);
                return true;
            }
            catch (JsonException)
            {
                result = default(T);
                return false;
            }
        }

        /// <summary>
        /// Safely deserializes a JSON string into a JToken object.
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <param name="result">The deserialized JToken if the string is a valid JSON string, otherwise null</param>
        /// <returns>True if the string is a valid JSON string, otherwise false.</returns>
        internal static bool TryReadJson(string json, out JToken result)
        {
            return TryReadJson<JToken>(json, out result);
        }

        /// <summary>
        /// Safely deserializes a JSON string into a PowerShell object.
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <param name="result">The deserialized PowerShell object if the string is a valid JSON string, otherwise null</param>
        /// <returns>True if the string is a valid JSON string, otherwise false.</returns>
        internal static bool TryReadAsPowerShellObject(string json, out object result)
        {
            if (TryReadJson(json, out JToken jToken))
            {
                result = jToken.ToPowerShellObject();
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Converts a JToken into an object that is native to PowerShell.
        /// </summary>
        /// <param name="json">The JToken representing the json</param>
        /// <returns>The native PowerShell object.</returns>
        internal static object ToPowerShellObject(this JToken json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json), "The provided JToken cannot be null");
            }

            // The token may represent a value or a container (there are no other subtypes in Newtonsoft's Json.NET)
            if (json is JValue jValue) // Handle values
            {
                return jValue.Value;
            }
            else if (json is JContainer container) // Handle containers
            {
                if (container is JConstructor)
                {
                    throw new ArgumentException("The provided JToken should not contain a JConstructor object", nameof(json));
                }
                if (container is JProperty)
                {
                    throw new ArgumentException("The provided JToken should not contain a JProperty object which is not nested inside a JObject", nameof(json));
                }

                if (container is JObject jObj)
                {
                    PSObject psObj = new PSObject();
                    foreach (JProperty property in jObj.Properties())
                    {
                        // Recursively convert this JObject into a PSObject
                        psObj.Members.Add(new PSNoteProperty(property.Name, property.Value.ToPowerShellObject()));
                    }

                    return PSObject.AsPSObject(psObj);
                }
                else if (container is JArray jArray)
                {
                    object[] powerShellArray = new object[jArray.Count];
                    for (int i = 0; i < jArray.Count; i++)
                    {
                        // Recursively convert this JArray into a PSObject array
                        powerShellArray.SetValue(jArray[i].ToPowerShellObject(), i);
                    }

                    return powerShellArray;
                }
                else
                {
                    // This should not be possible - we should have returned earlier unless there is a new JContainer subtype
                    throw new ArgumentException($"The JToken is not a JObject or JArray type - it is a '{json.GetType()}'", nameof(json));
                }
            }
            else
            {
                // This should not be possible - we should have returned earlier unless there is a new JToken subtype
                throw new ArgumentException($"The JToken is not a value or container type - it is a '{json.GetType()}'", nameof(json));
            }
        }
    }
}
