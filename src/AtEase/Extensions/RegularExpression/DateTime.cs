using System.Text.RegularExpressions;

namespace AtEase.Extensions.RegularExpression
{
    public static class DateTimeRegularExpression
    {
        // time must begin with 1300
        public const string ShamsiYearValidationRegex = @"^([1][3-4]\d{2})$";
        public const string TimeValidationRegex = @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9](:[0-5][0-9])?$";

        public static bool IsValidShamsiYear(this string year)
        {
            return !year.IsNullOrEmptyOrWhiteSpace() && Regex.IsMatch(year, ShamsiYearValidationRegex);
        }

        public static bool IsValidTime(this string time)
        {
            return !time.IsNullOrEmptyOrWhiteSpace() && Regex.IsMatch(time, TimeValidationRegex);
        }
    }
}