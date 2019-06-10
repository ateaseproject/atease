using System;

namespace AtEase.Extensions.Numbers
{
    public static partial class NumbersToTimeSpanExtensions
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="TimeSpan"></see> structure to a specified number of hours, minutes and
        ///     seconds.
        /// </summary>
        /// <param name="value">Tuple(hours, minutes, seconds)</param>
        public static TimeSpan ToTimeSpan(this ValueTuple<int, int, int> value)
        {
            var (hours, minutes, seconds) = value;
            return new TimeSpan(hours, minutes, seconds);
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="TimeSpan"></see> structure to a specified number of days, hours,
        ///     minutes, and seconds.
        /// </summary>
        /// <param name="value">Tuple(days, hours, minutes, seconds)</param>
        public static TimeSpan ToTimeSpan(this ValueTuple<int, int, int, int> value)
        {
            var (days, hours, minutes, seconds) = value;
            return new TimeSpan(days, hours, minutes, seconds);
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="TimeSpan"></see> structure to a specified number of days, hours,
        ///     minutes, seconds, and milliseconds.
        /// </summary>
        /// <param name="value">Tuple(days, hours, minutes, seconds, milliseconds)</param>
        public static TimeSpan ToTimeSpan(this ValueTuple<int, int, int, int, int> value)
        {
            var (days, hours, minutes, seconds, milliseconds) = value;
            return new TimeSpan(days, hours, minutes, seconds, milliseconds);
        }


        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Ticks</c>.
        /// </summary>
        public static TimeSpan Ticks(this int number)
        {
            return TimeSpan.FromTicks(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Milliseconds</c>.
        /// </summary>
        public static TimeSpan Milliseconds(this int number)
        {
            return TimeSpan.FromMilliseconds(number);
        }


        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Seconds</c>.
        /// </summary>
        public static TimeSpan Seconds(this int number)
        {
            return TimeSpan.FromSeconds(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Minutes</c>.
        /// </summary>
        public static TimeSpan Minutes(this int number)
        {
            return TimeSpan.FromMinutes(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Hours</c>.
        /// </summary>
        public static TimeSpan Hours(this int number)
        {
            return TimeSpan.FromHours(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Days</c>.
        /// </summary>
        public static TimeSpan Days(this int number)
        {
            return TimeSpan.FromDays(number);
        }

        /// <summary>
        ///     Returns a new <see cref="TimeSpan"></see> object represented by <paramref name="number" /> as <c>Weeks</c>.
        /// </summary>
        public static TimeSpan Weeks(this int number)
        {
            return TimeSpan.FromDays(number * 7);
        }
    }
}