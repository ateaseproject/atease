namespace AtEase.Extensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        ///     Convert nullable double to nullable decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Nullable decimal</returns>
        public static decimal? ToNullableDecimal(this double? value)
        {
            return (decimal?) value;
        }

        /// <summary>
        ///     Indicates the value as decimal is 0 or decimal.MinValue value.
        /// </summary>
        /// <param name="value">decimal value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMinValue(this decimal value)
        {
            return value is decimal.MinValue or 0;
        }

        /// <summary>
        ///     Indicates the value as decimal is decimal.MinValue value.
        /// </summary>
        /// <param name="value">decimal value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this decimal value)
        {
            return value is decimal.MinValue;
        }

        /// <summary>
        ///     Indicates the value as decimal is less than int.MinValue value.
        /// </summary>
        /// <param name="value">decimal value</param>
        /// <returns>Returns true if value is less than int min value.</returns>
        public static bool IsLessOrEqualIntMinValue(this decimal value)
        {
            return value <= int.MinValue;
        }
    }
}