using System.Collections.Generic;
using AtEase.Extensions.RegularExpression;
using Xunit;

namespace AtEase.Test
{
    public class RegularExpressionEmailIsEmailTests
    {
        public static IEnumerable<object[]> Email =>
            new List<object[]>
            {
                new object[] {" ", false},
                new object[] {"david.jones@proseware.com", true},
                new object[] {"d.j@server1.proseware.com", true},
                new object[] {"jones@ms1.proseware.com", true},
                new object[] {"j.@server1.proseware.com", false},
                new object[] {"j@proseware.com9", true},
                new object[] {"js#internal@proseware.com", true},
                new object[] {"j_9@[129.126.118.1]", true},
                new object[] {"j..s@proseware.com", false},
                new object[] {"js*@proseware.com", false},
                new object[] {"js@proseware..com", false},
                new object[] {"js@proseware.com9", true},
                new object[] {"j.s@server1.proseware.com", true},
                new object[] {"\"j\\\"s\\\"\"@proseware.com", true},
                new object[] {"js@proseware.ایران", true},
                new object[] {"js@contoso.中国", true},
            };


        [Theory]
        [MemberData(nameof(Email))]
        public void email_is_valid(string email, bool isValid)
        {
            Assert.Equal(isValid, email.IsValidEmail());
        }
    }
}