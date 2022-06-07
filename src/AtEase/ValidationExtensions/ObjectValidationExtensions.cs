using System;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class ObjectValidationExtensions
    {
        public static void AssertArgumentIsNotNull(this object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}