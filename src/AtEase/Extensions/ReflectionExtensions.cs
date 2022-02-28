using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace AtEase.Extensions
{
    public static class ReflectionExtensions
    {
        
        [DebuggerStepThrough]
        public static bool HasAttribute<T>(this Type type) where T : Attribute
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return type.GetCustomAttribute<T>() != null;
        }

        /// <summary>
        ///     Get property value of object by property name.
        /// </summary>
        [DebuggerStepThrough]
        public static object GetPropertyValue(this object src, string propertyName)
        {
            return src.GetType().GetProperty(propertyName)?.GetValue(src, null);
        }

        /// <summary>
        ///     Get field value of object by field name.
        /// </summary>
        [DebuggerStepThrough]
        public static object GetFieldValue(this object src, string fieldName)
        {
            return src.GetType().GetField(fieldName)?.GetValue(src);
        }

        /// <summary>
        ///     Get single attribute field value. Note that attribute should be single.
        /// </summary>
        [DebuggerStepThrough]
        public static string SingleAttributeValue<TAttribute>(this Type type, string propertyName, string attributeName)
            where TAttribute : Attribute
        {
            PropertyInfo[] props = type.GetProperties();
            var prop = props.Single(p => p.Name == propertyName);
            object attr = prop.GetCustomAttributes(true).Single(a => a.GetType() == typeof(TAttribute));
            return attr.GetFieldValue(attributeName).ToString();
        }
    }
}