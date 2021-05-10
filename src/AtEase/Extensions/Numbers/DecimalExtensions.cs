namespace AtEase.Extensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Convert nullable double to nullable decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Nullable decimal</returns>
        public static decimal? ToNullableDecimal(this double? value)
        {
            return (decimal?) value;
        }
    }
}