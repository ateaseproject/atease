using System;
using Paran.Framework.Resources;

namespace Paran.Framework.Validation
{
    public static class IntValidationExtention
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