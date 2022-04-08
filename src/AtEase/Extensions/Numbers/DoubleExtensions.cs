namespace AtEase.Extensions
{
    public static class DoubleExtensions
    {
 /// <summary>
        ///     Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has no a valid value of its
        ///     underlying type.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the current <see cref="T:System.Nullable`1" /> object has no a value;
        ///     <see langword="false" /> if the current <see cref="T:System.Nullable`1" /> object has value.
        /// </returns>
        public static bool HasNoValue(this double? value)
        {
            return !value.HasValue;
        }


        /// <summary>
        ///     Convert nullable double to nullable double
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Nullable double</returns>
        public static double? ToNullableDouble(this double? value)
        {
            return (double?) value;
        }

        /// <summary>
        ///     Indicates the value as double is 0 or double.MinValue value.
        /// </summary>
        /// <param name="value">double value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMinValue(this double value)
        {
            return value is double.MinValue or 0;
        }

        /// <summary>
        ///     Indicates the value as double is double.MinValue value.
        /// </summary>
        /// <param name="value">double value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this double value)
        {
            return value is double.MinValue;
        }

        /// <summary>
        ///     Indicates the value as double is less than int.MinValue value.
        /// </summary>
        /// <param name="value">double value</param>
        /// <returns>Returns true if value is less than int min value.</returns>
        public static bool IsLessOrEqualIntMinValue(this double value)
        {
            return value <= int.MinValue;
        }
    }
}