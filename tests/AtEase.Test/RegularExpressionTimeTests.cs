using AtEase.Extensions.RegularExpression;
using Xunit;

namespace AtEase.Test
{
    public class RegularExpressionTimeTests
    {
        [Theory]
        [InlineData("01:00")]
        [InlineData("00:01")]
        [InlineData("12:00")]
        [InlineData("12:00:00")]
        [InlineData("12:59")]
        [InlineData("12:00:59")]
        [InlineData("12:59:59")]
        [InlineData("23:00")]
        [InlineData("23:59")]
        [InlineData("23:00:59")]
        [InlineData("23:59:59")]
        [InlineData("01:00:00")]
        [InlineData("00:01:00")]
        [InlineData("00:00:01")]
        public void time_is_valid(string time)
        {
            Assert.True(time.IsValidTime());
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(":")]
        [InlineData("0:0")]
        [InlineData("00:0")]
        [InlineData("0:00")]
        [InlineData("::")]
        [InlineData("0::")]
        [InlineData(":0:")]
        [InlineData("::0")]
        [InlineData("0:0:")]
        [InlineData(":0:0")]
        [InlineData("0::0")]
        [InlineData("0:0:0")]
        [InlineData("00:0:0")]
        [InlineData("00:00:0")]
        [InlineData("0:00:0")]
        [InlineData("-1:00")]
        [InlineData("25:00")]
        [InlineData("00:-1")]
        [InlineData("00:60")]
        [InlineData("00:61")]
        [InlineData("00:00:-1")]
        [InlineData("00:00:60")]
        [InlineData("00:00:61")]
        [InlineData("24:00:00")]
        [InlineData("24:00")]
        public void time_is_invalid(string time)
        {
            Assert.False(time.IsValidTime());
        }
    }
}