using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace AtEase.Extensions
{
    public static class EnumExtensions
    {
        private static readonly Dictionary<Enum, string> Cache = new Dictionary<Enum, string>();

        public static T AsEnum<T>(this int value) where T : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            return (T) Enum.ToObject(typeof(T), value);
        }


        /// <summary>
        ///     Converts the value of the specified Enum to a 32-bit signed integer.
        /// </summary>
        /// <param name="value">Enum</param>
        /// <returns>Int32</returns>
        public static int ToInt(this Enum value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        ///     Converts the value of the specified Enum to a 16-bit signed integer.
        /// </summary>
        /// <param name="value">Enum</param>
        /// <returns>Int16</returns>
        public static int ToInt16(this Enum value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>
        ///     Converts the value of the specified Enum to an 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">Enum</param>
        /// <returns>Byte</returns>
        public static int ToByte(this Enum value)
        {
            return Convert.ToByte(value);
        }

        public static string GetDescription(this Enum value)
        {
            {
                var fi = value.GetType().GetField(value.ToString());

                var attributes =
                    (DescriptionAttribute[]) fi.GetCustomAttributes(
                        typeof(DescriptionAttribute),
                        false);

                if (attributes.Length > 0)
                {
                    return attributes[0].Description;
                }

                return value.ToString();
            }
        }

        public static string GetDescriptionWithCache(this Enum value)
        {
            if (Cache.ContainsKey(value))
            {
                return Cache[value];
            }

            var enumType = value.GetType();
            var enumName = Enum.GetName(enumType, value);
            var member = enumType.GetMember(enumName)[0];

            var attributes = member.GetCustomAttributes(typeof(DescriptionAttribute), false).ToList();
            var outString = ((DescriptionAttribute) attributes[0]).Description;
            Cache.Add(value, outString);

            return outString;
        }

        public static IEnumerable<TEnum> Values<TEnum>() where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);

            if (!enumType.GetTypeInfo().IsEnum)
            {
                throw new ArgumentException();
            }

            return Enum.GetValues(enumType).Cast<TEnum>();
        }

        public static List<T> EnumToList<T>()
        {
            var enumType = typeof(T);

            // Can't use type constraints on value types, so have to do check like this
            if (enumType.GetTypeInfo().BaseType != typeof(Enum))
            {
                throw new ArgumentException("T must be of type System.Enum");
            }

            var enumValArray = Enum.GetValues(enumType);

            var enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray)
            {
                enumValList.Add((T) Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }

        public static string GetDisplayName(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes[0].ResourceType != null)
            {
                return lookupResource(descriptionAttributes[0].ResourceType, descriptionAttributes[0].Name);
            }

            if (descriptionAttributes == null)
            {
                return string.Empty;
            }

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Name : value.ToString();
        }

        public static IEnumerable<KeyValuePair<int, string>> ToKeyValueList<T>() where T : struct
        {
            return Enum.GetValues(typeof(T)).Cast<Enum>()
                .Select(e => new KeyValuePair<int, string>(Convert.ToInt32(e), GetDisplayName(e))).ToList();
        }

        private static string lookupResource(Type resourceManagerProvider, string resourceKey)
        {
            foreach (var staticProperty in resourceManagerProvider.GetProperties(
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (staticProperty.PropertyType == typeof(ResourceManager))
                {
                    var resourceManager = (ResourceManager) staticProperty.GetValue(null, null);
                    return resourceManager.GetString(resourceKey);
                }
            }

            return resourceKey; // Fallback with the key name
        }
    }
}