namespace AtEase.Extensions.Numbers
{
    public static class ByteExtensions
    {
        /// <summary>
        ///     Indicates the value as byte  is byte.MinValue value.
        ///     byte min value is zero.
        /// </summary>
        /// <param name="value">byte value</param>
        /// <returns>Returns true if value is min value.</returns>
        public static bool IsMinValue(this byte value)
        {
            return value == byte.MinValue;
        }

        /// <summary>
        ///     Indicates the value is even.
        /// </summary>
        /// <param name="value">byte value</param>
        /// <returns>Returns true if value is even.</returns>
        public static bool IsEven(this byte value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        ///     Indicates the value is odd.
        /// </summary>
        /// <param name="value">byte value</param>
        /// <returns>Returns true if value is odd.</returns>
        public static bool IsOdd(this byte value)
        {
            return !IsEven(value);
        }
    }
}