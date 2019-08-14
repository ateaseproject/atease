using System;

namespace AtEase.Extensions
{
    public static partial class NumbersToTimeSpanExtensions
    {
        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Ticks</c>.
        /// </summary>
        public static TimeSpan Ticks(this short number)
        {
            return TimeSpan.FromTicks(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Milliseconds</c>.
        /// </summary>
        public static TimeSpan Milliseconds(this short number)
        {
            return TimeSpan.FromMilliseconds(number);
        }


        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Seconds</c>.
        /// </summary>
        public static TimeSpan Seconds(this short number)
        {
            return TimeSpan.FromSeconds(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Minutes</c>.
        /// </summary>
        public static TimeSpan Minutes(this short number)
        {
            return TimeSpan.FromMinutes(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Hours</c>.
        /// </summary>
        public static TimeSpan Hours(this short number)
        {
            return TimeSpan.FromHours(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Days</c>.
        /// </summary>
        public static TimeSpan Days(this short number)
        {
            return TimeSpan.FromDays(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Weeks</c>.
        /// </summary>
        public static TimeSpan Weeks(this short number)
        {
            return TimeSpan.FromDays(number * 7);
        }
    }
}