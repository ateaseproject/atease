namespace AtEase.Extensions
{
    public static class CharExtensions
    {
        public static bool IsWhiteSpace(this char @char)
        {
            return char.IsWhiteSpace(@char);
        }

        public static bool IsNumber(this char @char)
        {
            return char.IsNumber(@char);
        }

        public static bool IsControl(this char @char)
        {
            return char.IsControl(@char);
        }

        public static bool IsDigit(this char @char)
        {
            return char.IsDigit(@char);
        }

        public static bool IsLetter(this char @char)
        {
            return char.IsLetter(@char);
        }
    }
}