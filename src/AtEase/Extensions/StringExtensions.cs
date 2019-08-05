namespace AtEase.Extensions
{
    public static class StringExtensions
    {
        public static string ToObfuscatedMobile(this string mobileNumber)
        {
            var mobileArray = mobileNumber.ToCharArray();
            mobileArray[4] = '*';
            mobileArray[5] = '*';
            mobileArray[6] = '*';

            return new string(mobileArray);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !value.IsNullOrEmpty();
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(this string value)
        {
            return !value.IsNullOrEmptyOrWhiteSpace();
        }

        public static string ToPersianNumber(this string value)
        {
            return value
                .Replace("0", "۰")
                .Replace("1", "۱")
                .Replace("2", "۲")
                .Replace("3", "۳")
                .Replace("4", "۴")
                .Replace("5", "۵")
                .Replace("6", "۶")
                .Replace("7", "۷")
                .Replace("8", "۸")
                .Replace("9", "۹");
        }

        public static string Format(this string value, object arg0)
        {
            return string.Format(value, arg0);
        }

        public static string Format(this string value, object arg0, object arg1)
        {
            return string.Format(value, arg0, arg1);
        }

        public static string Format(this string value, object arg0, object arg1, object arg2)
        {
            return string.Format(value, arg0, arg1, arg2);
        }
    }
}