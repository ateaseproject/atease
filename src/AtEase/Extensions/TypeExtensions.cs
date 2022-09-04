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





        internal static readonly Type[] PredefinedTypes = new Type[20]
        {
            typeof(object),
            typeof(bool),
            typeof(char),
            typeof(string),
            typeof(sbyte),
            typeof(byte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(DateTime),
            typeof(TimeSpan),
            typeof(Guid),
            typeof(Math),
            typeof(Convert)
        };

        /// <summary>
        /// Check type is C# predefined type;
        /// </summary>
        [DebuggerStepThrough]
        public static bool IsPredefinedType(this Type type)
        {
            foreach (var predefinedType in PredefinedTypes)
            {
                if (predefinedType == type) return true;
            }

            return false;
        }

        /// <summary>
        /// Check type is Interface
        /// </summary>
        [DebuggerStepThrough]
        internal static bool IsInterface(this Type type)
        {
            return type.GetTypeInfo().IsInterface;
        }

        /// <summary>
        /// Check type is nullable
        /// </summary>
        [DebuggerStepThrough]
        internal static bool IsNullableType(this Type type)
        {
            return type.IsGenericType() && type.GetGenericTypeDefinition() == (object)typeof(Nullable<>);
        }

        /// <summary>
        /// Check type is not nullable
        /// </summary>
        [DebuggerStepThrough]
        internal static bool IsNotNullableType(this Type type)
        {
            return !IsNullableType(type);
        }

        /// <summary>
        /// Get type default value
        /// </summary>
        [DebuggerStepThrough]

        public static object GetDefaultValue(this Type type)
        {
            return type.IsValueType() ? Activator.CreateInstance(type) : null;
        }





    }
}