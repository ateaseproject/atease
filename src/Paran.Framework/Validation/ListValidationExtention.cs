using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Paran.Framework.Resources;

namespace Paran.Framework.Validation
{
    public static class ListValidationExtention
    {
        public static void AssertListIsNotNullOrEmpty<T>(this IList<T> list, string name)
        {
            if (list.IsNullOrEmpty())
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }

            var collection = enumerable as ICollection<T>;

            if (collection != null)
            {
                return collection.Count < 1;
            }

            return !enumerable.Any();
        }

        public static bool IsNullOrEmpty<T>(this IList<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }

            return enumerable.Count < 1;
        }

        public static bool IsNullOrEmpty(this IList enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }

            return enumerable.Count < 1;
        }
    }
}