namespace AtEase.Extensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        ///     Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has no a valid value of its
        ///     underlying type.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the current <see cref="T:System.Nullable`1" /> object has no a value;
        ///     <see langword="false" /> if the current <see cref="T:System.Nullable`1" /> object has value.
        /// </returns>
        public static bool HasNoValue(this decimal? value)
        {
            return !value.HasValue;
        }


        /// <summary>
        ///     Convert nullable double to nullable decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Nullable decimal</returns>
        public static decimal? ToNullableDecimal(this double? value)
        {
            return (decimal?)value;
        }

        /// <summary>
        ///     Indicates the value as decimal is 0.
        /// </summary>
        /// <param name="value">decimal value</param>
        /// <returns>Returns true if value is 0 .</returns>
        public static bool IsZero(this decimal value)
        {
            return value is 0;
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