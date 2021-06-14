using System;
using System.Globalization;

namespace AtEase.Extensions
{
    public static class DateTimeExtensions
    {
        private static readonly PersianCalendar PersianCalender = new PersianCalendar();

        public static DateTime ToGregorianDateTime(this string date)
        {
            var datePart = date.Split(' ')[0];
            var parts = datePart.Split('/');
            var year = int.Parse(parts[0]);
            var month = int.Parse(parts[1]);
            var day = int.Parse(parts[2]);

            return PersianCalender.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static string ToPersianDateTime(this DateTime date, string format = null)
        {
            var persianDate = new PersianDateTime(date);
            return string.IsNullOrEmpty(format) ? persianDate.ToString() : persianDate.ToString(format);
        }


        /// <summary>
        /// Get date time with max value 23:59:59
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime AsDayMaxValue(this DateTime date)
        {
           return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }

        /// <summary>
        /// Get date time with zero time 00:00:00
        /// </summary>
        /// <param name="date">date time</param>
        /// <returns>date without time</returns>
        public static DateTime AsDayMinValue(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }
    }
}