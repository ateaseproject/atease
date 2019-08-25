using System.Collections.Generic;
using AtEase.Extensions;
using Xunit;

namespace AtEase.Test
{
    public class DecimalExtensionsTests
    {
        public static IEnumerable<object[]> doubles =>
            new List<object[]>
            {
                new object[] {null, null},
                new object[] {(double) 1, (decimal) 1},
                new object[] {1.1, (decimal) 1.1}
            };


        [Theory]
        [MemberData(nameof(doubles))]
        public void nullable_double_to_nullable_decimal(double? value,
            decimal? expectedValue)
        {
            var decimalValue = value.ToNullableDecimal();
            Assert.Equal(expectedValue, decimalValue);
        }
    }
}