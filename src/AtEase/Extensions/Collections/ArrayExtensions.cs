using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AtEase.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        ///     Determines whether a collection is null or has no elements
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The items.</param>
        /// <returns>
        ///     <c>true</c> if this list is null or empty; otherwise, <c>false</c>.
        /// </returns>
        [DebuggerStepThrough]
        public static bool IsNullOrEmpty([NotNullWhen(false)] this Array items)
        {
            return items == null || items.Length == 0;
        }

        /// <summary>
        ///     Determines whether a collection is not null or has elements.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="items">The items.</param>
        /// <returns>
        ///     <c>true</c> if this list is null or empty; otherwise, <c>false</c>.
        /// </returns>
        [DebuggerStepThrough]
        public static bool IsNotNullOrEmpty([NotNullWhen(true)] this Array items)
        {
            return items is {Length: > 0};
        }
    }
}