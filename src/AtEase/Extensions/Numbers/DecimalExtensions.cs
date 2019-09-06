namespace AtEase.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal? ToNullableDecimal(this double? value)
        {
            return (decimal?) value;
        }
    }
}