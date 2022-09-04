using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AtEase.Extensions.Collections
{
    public static class ListExtensions
    {
        /// <summary>
        ///     Determines whether a collection is null or has no elements without having to enumerate the entire collection to get
        ///     a count.  Uses LINQ.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The items.</param>
        /// <returns>
        ///     <c>true</c> if this list is null or empty; otherwise, <c>false</c>.
        /// </returns>
        [DebuggerStepThrough]
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)]this IList<T> items)
        {
            return items == null || !items.Any();
        }


        [DebuggerStepThrough]
        public static bool IsNotNullOrEmpty<T>([NotNullWhen(true)]this IList<T> items)
        {
            return items != null && items.Any();
        }

        [DebuggerStepThrough]
        public static bool NotAny<TSource>(this IList<TSource> source)
        {
            return !source.Any();
        }

        [DebuggerStepThrough]
        public static bool NotAny<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }

    }
}