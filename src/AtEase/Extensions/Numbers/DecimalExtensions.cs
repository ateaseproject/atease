namespace AtEase.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal? ToNullableDecimal(this double? value)
        {
            if (value == null)
            {
                return null;
            }

            return (decimal) value;
        }
    }
}