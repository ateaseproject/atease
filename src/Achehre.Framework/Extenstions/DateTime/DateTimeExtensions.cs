using System.Globalization;
using Achehre.Framework.Extenstions.DateTime;

namespace Achehre.Framework.Extenstions
{
    public static class DateTimeExtensions
    {
        private static readonly PersianCalendar PersianCalender = new PersianCalendar();

        public static System.DateTime ToGregorianDateTime(this string date)
        {
            var datePart = date.Split(' ')[0];
            var parts = datePart.Split('/');
            var year = int.Parse(parts[0]);
            var month = int.Parse(parts[1]);
            var day = int.Parse(parts[2]);

            return PersianCalender.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static string ToPersianDateTime(this System.DateTime date, string format = null)
        {
            var persianDate = new PersianDateTime(date);
            return string.IsNullOrEmpty(format) ? persianDate.ToString() : persianDate.ToString(format);
        }
    }
}