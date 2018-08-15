using System;
using Paran.Framework.Resources;

namespace Paran.Framework.Validation
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