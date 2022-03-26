namespace AtEase.Extensions.Numbers
{
    public static class IntExtensions
    {
        /// <summary>
        ///     Indicates the value as int is 0 or int.MinValue value.
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMinValue(this int value)
        {
            return value is int.MinValue or 0;
        }

        /// <summary>
        ///     Indicates the value as int is int.MinValue value.
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this int value)
        {
            return value is int.MinValue;
        }

        /// <summary>
        ///     Indicates the value is even.
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Returns true if value is even.</returns>
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        ///     Indicates the value is odd.
        /// </summary>
        /// <param name="value">Int value</param>
        /// <returns>Returns true if value is odd.</returns>
        public static bool IsOdd(this int value)
        {
            return !IsEven(value);
        }
    }
}