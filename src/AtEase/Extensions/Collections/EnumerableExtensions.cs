using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AtEase.Extensions.Collections
{
    public static class EnumerableExtensions
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
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T> items)
        {
            return items == null || items.NotAny();
        }

        [DebuggerStepThrough]
        public static bool IsNotNullOrEmpty<T>([NotNullWhen(true)] this IEnumerable<T> items)
        {
            return items != null && items.Any();
        }

        /// <summary>
        ///     Determines whether not any element of a sequence satisfies a condition.
        /// </summary>
        [DebuggerStepThrough]
        public static bool NotAny<TSource>(this IEnumerable<TSource> source)
        {
            return !source.Any();
        }

        /// <summary>
        ///     Determines whether not any element of a sequence satisfies a condition.
        /// </summary>
        [DebuggerStepThrough]
        public static bool NotAny<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }
}