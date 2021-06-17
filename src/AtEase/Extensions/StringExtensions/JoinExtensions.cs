using System;
using System.Collections.Generic;

namespace AtEase.Extensions
{
    public static class JoinExtensions
    {
        public static string Join(this int[] value, string separator)
        {
            return string.Join(separator, value);
        }

        public static string Join<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values);
        }

        public static string Join<T>(this List<T> values, string separator)
        {
            return string.Join(separator, values);
        }


        //TODO Implement these
        //public static string Join(this int[] value, char separator)
        //{
        //    return string.Join(separator, value);
        //}

        //public static string Join<T>(this IEnumerable<T> values, char separator)
        //{
        //    return string.Join(separator, values);
        //}
    }
}