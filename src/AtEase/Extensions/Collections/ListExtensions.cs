using System.Collections.Generic;
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
        public static bool IsNullOrEmpty<T>(this IList<T> items)
        {
            return items == null || !items.Any();
        }


        public static bool IsNotNullOrEmpty<T>(this IList<T> items)
        {
            return items != null && items.Any();
        }
    }
}