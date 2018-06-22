// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Reflection;

    internal static class PSObjectUtils
    {
        private const string PSStandardMembers = "PSStandardMembers";

        private const string DefaultDisplayPropertySet = "DefaultDisplayPropertySet";

        internal static object ToPowerShellObject(this object obj)
        {
            // Null is valid in PowerShell
            if (obj == null)
            {
                return null;
            }

            // Get the type
            Type type = obj.GetType();

            if (type.IsPrimitive || obj is string || obj is PSObject)
            {
                // If the object is a primitive type, a string or a PSObject, PowerShell understands it
                return obj;
            }
            else if (type.IsEnum)
            {
                // Make sure the enum is visible to the user of the module, otherwise the value is meaningless
                if (type.IsNotPublic)
                {
                    throw new ArgumentException($"The enum \"{type.FullName}\" must be visible outside this assembly to convert it to a PowerShell object", nameof(obj));
                }

                return obj;
            }
            else if (type.IsValueType)
            {
                // If the value type is not visible to the user of the module, convert it as if it were a class
                if (type.IsNotPublic)
                {
                    IEnumerable<PropertyInfo> properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
                    PSObject result = new PSObject();
                    foreach (PropertyInfo property in properties)
                    {
                        result.Properties.Add(new PSNoteProperty(property.Name, ToPowerShellObject(property.GetValue(obj))));
                    }

                    return result;
                }
                else
                {
                    // If the value type is visible to the user, return it as-is
                    return obj;
                }
            }
            else if (obj is IDictionary objDictionary) // Hashtable also implements IDictionary
            {
                // Ensure that the keys are all strings (and not null)
                foreach (object key in objDictionary.Keys)
                {
                    // Check for null keys
                    if (key == null)
                    {
                        throw new ArgumentException($"Unable to convert object of type \"{obj.GetType().FullName}\" because this dictionary or hashtable contains a null key");
                    }

                    // Check for string keys
                    if (!(key is string))
                    {
                        throw new ArgumentException($"Unable to convert object of type \"{obj.GetType().FullName}\" because this dictionary or hashtable contains a key that is not a string");
                    }
                }

                // Create a PSObject and process the values
                PSObject result = new PSObject();
                foreach (object key in objDictionary.Keys)
                {
                    result.Properties.Add(new PSNoteProperty(key as string, objDictionary[key].ToPowerShellObject()));
                }

                return result;
            }
            else if (obj is IEnumerable objArray) // This MUST be after the IDictionary check because IDictionary extends IEnumerable
            {
                // Convert each object in the collection to a PowerShell object and then return them as an array
                return objArray.Cast<object>().Select(o => ToPowerShellObject(o)).ToArray();
            }
            else if (type.Assembly == typeof(object).Assembly)
            {
                // If the object is a built-in type, PowerShell understands it
                return obj;
            }
            else if (type.IsClass)
            {
                // If the object is a class, convert each property to a PowerShell object
                IEnumerable<PropertyInfo> properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
                PSObject result = new PSObject();
                foreach (PropertyInfo property in properties)
                {
                    result.Properties.Add(new PSNoteProperty(property.Name, ToPowerShellObject(property.GetValue(obj))));
                }

                return result;
            }
            else
            {
                throw new ArgumentException($"Unable to convert object of type \"{type.FullName}\" to a PowerShell object", nameof(obj));
            }
        }

        internal static void SetDefaultProperties(this PSObject psObject, Func<PSPropertyInfo, bool> filter)
        {
            if (psObject == null)
            {
                throw new ArgumentNullException(nameof(psObject));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            // Apply the filter and get the member names
            IEnumerable<string> defaultPropertyNames = psObject.Properties.Where(filter).Select(prop => prop.Name);

            // Create the PSMemberSet
            PSMemberSet memberSet = new PSMemberSet(PSStandardMembers, new PSMemberInfo[]
            {
                new PSPropertySet(DefaultDisplayPropertySet, defaultPropertyNames),
            });

            // If the PSStandardMembers property already exists, remove it
            psObject.Members.Remove(PSStandardMembers);

            // Add the "PSStandardMembers" member
            psObject.Members.Add(memberSet);
        }
    }
}
