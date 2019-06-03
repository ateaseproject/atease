using System;
using System.Collections.Generic;
using Achehre.Framework.Extenstions;
using Achehre.Framework.Resources;
using Xunit;

namespace PersianDateTime.Test
{
    public class PersianDateTests
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {new DateTime(1985, 3, 22, 10, 10, 10), "", "1364/01/02 10:10"},
                new object[] {new DateTime(1985, 3, 22, 10, 10, 10), "MMMM", DisplayNameResource.PersianMonthFarvardin},
                new object[]
                {
                    new DateTime(1985, 3, 22, 10, 10, 10), "MMM",
                    DisplayNameResource.PersianMonthFarvardin.Substring(0, 3)
                },
                new object[] {new DateTime(1985, 3, 22, 10, 10, 10), "dddd", DisplayNameResource.WeekFriday},
                new object[]
                    {new DateTime(1985, 3, 22, 10, 10, 10), "ddd", DisplayNameResource.WeekFriday.Substring(0, 3)}
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void ToPersianDateTimeExtension_DateTimeFormat_PersianDateValue(DateTime time, string format,
                                                                               string expectedValue)
        {
            var persianDate = time.ToPersianDateTime(format);
            Assert.Equal(expectedValue, persianDate);
        }
    }
}