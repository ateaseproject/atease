using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace AtEase.Extensions
{
    public static class TypeExtensions
    {
        [DebuggerStepThrough]
        public static Assembly Assembly(this Type type)
        {
            return type.GetTypeInfo().Assembly;
        }

        [DebuggerStepThrough]
        public static object[] GetCustomAttributes(this Type type, Type attributeType, bool inherit)
        {
            return type.GetTypeInfo()
                .GetCustomAttributes(attributeType, inherit)
                .ToArray();
        }

        [DebuggerStepThrough]
        public static bool IsEnum(this Type type)
        {
            return type.GetTypeInfo().IsEnum;
        }

        [DebuggerStepThrough]
        public static bool IsGenericType(this Type type)
        {
            return type.GetTypeInfo().IsGenericType;
        }

        [DebuggerStepThrough]
        public static bool IsInstanceOfType(this Type type, object obj)
        {
            return type.GetTypeInfo().IsInstanceOfType(obj);
        }

        [DebuggerStepThrough]
        public static bool IsValueType(this Type type)
        {
            return type.GetTypeInfo().IsValueType;
        }
    }
}