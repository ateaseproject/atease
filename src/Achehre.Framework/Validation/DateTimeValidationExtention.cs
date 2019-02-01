using System;
using Achehre.Framework.Resources;

namespace Achehre.Framework.Validation
{
    public static class DateTimeExtention
    {
        public static void AssertArgumentIsNotNullOrMinValue(this DateTime time, string name)
        {
            if (time == null)
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