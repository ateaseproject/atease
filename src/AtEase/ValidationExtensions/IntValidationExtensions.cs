using System;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class IntValidationExtensions
    {
        public static void AssertArgumentIsGreaterThanOrEqualZero(this int number, string name)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(name, ErrorMessageResource.ArgumentOutOfRangeError);
            }
        }

        public static void AssertArgumentIsGreaterThanZero(this int number, string name)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(name, ErrorMessageResource.ArgumentOutOfRangeError);
            }
        }
    }
}