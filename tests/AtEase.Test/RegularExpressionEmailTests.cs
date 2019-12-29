using AtEase.Extensions.RegularExpression;
using Xunit;

namespace AtEase.Test
{
    public class RegularExpressionEmailTests
    {
        [Theory]
        [InlineData("david.jones@proseware.com")]
        [InlineData("d.j@server1.proseware.com")]
        [InlineData("jones@ms1.proseware.com")]
        [InlineData("j@proseware.com9")]
        [InlineData("js#internal@proseware.com")]
        [InlineData("j_9@[129.126.118.1]")]
        [InlineData("js@proseware.com9")]
        [InlineData("j.s@server1.proseware.com")]
        [InlineData("\"j\\\"s\\\"\"@proseware.com")]
        [InlineData("js@proseware.ایران")]
        [InlineData("js@contoso.中国")]
        public void email_is_valid(string email)
        {
            Assert.True(email.IsValidEmail());
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("j.@server1.proseware.com")]
        [InlineData("j..s@proseware.com")]
        [InlineData("js*@proseware.com")]
        [InlineData("js@proseware..com")]
        public void email_is_invalid(string email)
        {
            Assert.False(email.IsValidEmail());
        }
    }
}