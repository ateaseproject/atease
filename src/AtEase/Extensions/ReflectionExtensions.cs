using System;
using System.Reflection;

namespace AtEase.Extensions
{
    public static class ReflectionExtensions
    {
        public static bool HasAttribute<T>(this Type type) where T : Attribute
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return type.GetCustomAttribute<T>() != null;
        }
    }
}