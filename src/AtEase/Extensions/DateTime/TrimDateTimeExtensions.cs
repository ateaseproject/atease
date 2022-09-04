using System;
using System.Diagnostics;

namespace AtEase.Extensions
{
    public static class TrimDateTimeExtensions
    {
        [DebuggerStepThrough]
        private static DateTime Trim(this DateTime date, long roundTicks)
        {
            return new DateTime(date.Ticks - date.Ticks % roundTicks, date.Kind);
        }

        /// <summary>
        ///     Trim time of the DateTime
        /// </summary>
        [DebuggerStepThrough]
        public static DateTime TrimUntilDays(this DateTime value)
        {
            return value.Trim(TimeSpan.TicksPerDay);
        }

        /// <summary>
        ///     Trim minute, seconds and milliseconds of the DateTime
        /// </summary>
        [DebuggerStepThrough]
        public static DateTime TrimUntilHours(this DateTime value)
        {
            return value.Trim(TimeSpan.TicksPerHour);
        }

        /// <summary>
        ///     Trim  seconds and milliseconds of the DateTime
        /// </summary>
        [DebuggerStepThrough]
        public static DateTime TrimUntilMinutes(this DateTime value)
        {
            return value.Trim(TimeSpan.TicksPerMinute);
        }

        /// <summary>
        ///     Trim  milliseconds of the DateTime
        /// </summary>
        [DebuggerStepThrough]
        public static DateTime TrimUntilSeconds(this DateTime value)
        {
            return value.Trim(TimeSpan.TicksPerSecond);
        }
    }
}