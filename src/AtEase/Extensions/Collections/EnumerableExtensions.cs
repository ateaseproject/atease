using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AtEase.Extensions.Collections
{
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Index of item in collection
        /// </summary>
        [DebuggerStepThrough]
        public static int IndexOf(this IEnumerable source, object item)
        {
            int num = 0;
            foreach (var value in source)
            {
                if (Equals(value, item))
                {
                    return num;
                }

                ++num;
            }

            return -1;
        }

        /// <summary>
        ///     Element at the index
        /// </summary>
        [DebuggerStepThrough]
        internal static object ElementAt(this IEnumerable source, int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (source is IList {Count: > 0} list)
            {
                return list[index];
            }

            foreach (var obj in source)
            {
                if (index == 0)
                {
                    return obj;
                }

                --index;
            }

            return null;
        }

        [DebuggerStepThrough]
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(
        this IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                return DefaultReadOnlyCollection<T>.Empty;
            }

            return sequence is ReadOnlyCollection<T> readOnlyCollection
                ? readOnlyCollection
                : new ReadOnlyCollection<T>(sequence.ToArray());
        }


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


        /// <summary>
        ///     Run action on each item in collection
        /// </summary>
        [DebuggerStepThrough]
        public static void Each<T>(this IEnumerable<T> instance, Action<T, int> action)
        {
            int num = 0;
            foreach (T obj in instance)
            {
                action(obj, num++);
            }
        }

        /// <summary>
        ///     Run action on each item in collection
        /// </summary>
        [DebuggerStepThrough]
        public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
        {
            foreach (T obj in instance)
            {
                action(obj);
            }
        }

        private static class DefaultReadOnlyCollection<T>
        {
            private static ReadOnlyCollection<T> _defaultCollection;

            internal static ReadOnlyCollection<T> Empty => _defaultCollection ??= new ReadOnlyCollection<T>(Array.Empty<T>());
        }
    }
}