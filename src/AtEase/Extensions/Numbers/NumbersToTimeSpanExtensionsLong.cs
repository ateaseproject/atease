using System;

namespace AtEase.Extensions
{
    public static partial class NumbersToTimeSpanExtensions
    {
        /// <summary>
        ///     Returns a new <see cref="T:System.TimeSpan"></see> object represented by <paramref name="number" /> as <c>Ticks</c>
        ///     .
        /// </summary>
        public static TimeSpan Ticks(this long number)
        {
            return TimeSpan.FromTicks(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Milliseconds</c>.
        /// </summary>
        public static TimeSpan Milliseconds(this long number)
        {
            return TimeSpan.FromMilliseconds(number);
        }


        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Seconds</c>.
        /// </summary>
        public static TimeSpan Seconds(this long number)
        {
            return TimeSpan.FromSeconds(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Minutes</c>.
        /// </summary>
        public static TimeSpan Minutes(this long number)
        {
            return TimeSpan.FromMinutes(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Hours</c>.
        /// </summary>
        public static TimeSpan Hours(this long number)
        {
            return TimeSpan.FromHours(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Days</c>.
        /// </summary>
        public static TimeSpan Days(this long number)
        {
            return TimeSpan.FromDays(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Weeks</c>.
        /// </summary>
        public static TimeSpan Weeks(this long number)
        {
            return TimeSpan.FromDays(number * 7);
        }
    }
}