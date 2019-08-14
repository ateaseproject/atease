namespace AtEase.Extensions
{
    public static class StringPersianExtensions
    {
        public const char ArabicKChar = (char) 1603;
        public const char ArabicYChar1 = (char) 1609;
        public const char ArabicYChar2 = (char) 1610;
        public const char PersianKChar = (char) 1705;
        public const char PersianYChar = (char) 1740;

        public static string FixPersianKeyboardLayout(this string value)
        {
            if (value.IsNullOrEmptyOrWhiteSpace())
            {
                return value;
            }

            return value.Replace(ArabicYChar1, PersianYChar)
                .Replace(ArabicYChar2, PersianYChar)
                .Replace(ArabicKChar, PersianKChar);
        }
    }
}