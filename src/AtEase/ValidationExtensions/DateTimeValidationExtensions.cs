using System;
using AtEase.Extensions;
using AtEase.Resources;

namespace AtEase.ValidationExtensions
{
    public static class DateTimeValidationExtensions
    {
        public static void AssertArgumentIsNotNullOrMinValue(this DateTime time, string name)
        {
            if (time.IsNull())
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }

            if (time == DateTime.MinValue)
            {
                throw new ArgumentException(name, ErrorMessageResource.ArgumentError);
            }
        }
    }
}