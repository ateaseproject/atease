using System;
using System.Globalization;

namespace Paran.Framework.Extenstions.DateTime
{
    public struct PersianDateTime
    {
        public static PersianDateTime MinValue => new PersianDateTime(new PersianCalendar().MinSupportedDateTime);

        public static PersianDateTime MaxValue => new PersianDateTime(new PersianCalendar().MaxSupportedDateTime);

        public static PersianDateTime Now => new PersianDateTime(System.DateTime.Now);

        public PersianDateTime(System.DateTime date)
        {
            Calendar = new PersianCalendar();
            DateTime = date;
        }

        public System.DateTime DateTime { get; }
        private PersianCalendar Calendar { get; }

        public int Year => Calendar.GetYear(DateTime);

        public PersianMonths Month => (PersianMonths) Calendar.GetMonth(DateTime);

        public int Day => Calendar.GetDayOfMonth(DateTime);

        public WeekDays DayOfWeek => (WeekDays) Calendar.GetDayOfWeek(DateTime);

        public int Hour => Calendar.GetHour(DateTime);

        public int Minute => Calendar.GetMinute(DateTime);

        public int Second => Calendar.GetSecond(DateTime);

        public double Milliseconds => Calendar.GetMilliseconds(DateTime);

        public static PersianDateTime Parse(string value)
        {
            if (string.IsNullOrEmpty(value?.Trim()))
            {
                throw new FormatException();
            }

            var seprators = new[] {" ", "/", "-", ".", ":"};
            var year = 1;
            var month = 1;
            var day = 1;
            var hour = 0;
            var minute = 0;
            var second = 0;
            var millisecond = 0;

            var segments = value.Split(seprators, StringSplitOptions.RemoveEmptyEntries);

            if (segments.Length > 0)
            {
                if (segments.Length > 0)
                {
                    int.TryParse(segments[0], out year);
                }

                if (segments.Length > 1)
                {
                    int.TryParse(segments[1], out month);
                }

                if (segments.Length > 2)
                {
                    int.TryParse(segments[2], out day);
                }

                if (segments.Length > 3)
                {
                    int.TryParse(segments[3], out hour);
                }

                if (segments.Length > 4)
                {
                    int.TryParse(segments[4], out minute);
                }

                if (segments.Length > 5)
                {
                    int.TryParse(segments[5], out second);
                }

                if (segments.Length > 6)
                {
                    int.TryParse(segments[6], out millisecond);
                }
            }
            else
            {
                throw new FormatException();
            }

            return new PersianDateTime(new PersianCalendar().ToDateTime(year, month, day, hour, minute, second,
                millisecond));
        }

        public override string ToString()
        {
            return ToString("yyyy/MM/dd HH:mm");
        }

        public string ToString(string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                return ToString();
            }

            var value = format;

            value = value.Replace("yyyy", Year.ToString("D4"));
            //value = value.Replace("yyy", Year.ToString("D4").Substring(1));
            //value = value.Replace("yy", Year.ToString("D4").Substring(2));
            //value = value.Replace("y", Year.ToString("D4").Substring(3));

            value = value.Replace("MMMM", Month.GetDisplayName());
            value = value.Replace("MMM", (Month.GetDisplayName() + "   ").Substring(0, 3));
            value = value.Replace("MM", ((int) Month).ToString("D2"));
            value = value.Replace("M", ((int) Month).ToString());

            value = value.Replace("dddd", DayOfWeek.GetDisplayName());
            value = value.Replace("ddd", (DayOfWeek.GetDisplayName() + "   ").Substring(0, 3));
            value = value.Replace("dd", Day.ToString("D2"));
            value = value.Replace("d", Day.ToString());

            value = value.Replace("HH", Hour.ToString("D2"));
            value = value.Replace("H", Hour.ToString());

            value = value.Replace("mm", Minute.ToString("D2"));
            value = value.Replace("m", Minute.ToString());

            value = value.Replace("ss", Second.ToString("D2"));
            value = value.Replace("s", Second.ToString());
            return value;
        }
    }
}