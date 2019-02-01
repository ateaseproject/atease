using System;

namespace Achehre.Framework.Extenstions
{
    public static class ArrayExtensions
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
        public static bool IsNullOrEmpty<T>(this Array items)
        {
            return items == null || items.Length == 0;
        }
    }
}