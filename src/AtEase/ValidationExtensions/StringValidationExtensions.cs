using System;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class StringValidationExtensions
    {
        public static void AssertArgumentIsNotNullOrWhiteSpace(this string str, string name)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }
        }
    }
}