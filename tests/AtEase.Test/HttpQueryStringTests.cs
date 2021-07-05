using System;
using System.Web;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class HttpQueryStringTests
    {
        [Fact]
        public void ToHttpQueryString_should_return_value_of_enum_in_result()

        {
            EnumTestClass enumTestClass = new EnumTestClass
            {
                ByteEnum = ByteEnum.Value,
                TestEnum = TestEnum.Value,
                IntEnum = IntEnum.Value,
                NullableTestEnum = TestEnum.Value,
                NullTestEnum = null
            };

            string query = enumTestClass.ToQueryString();

            query.Should().Be(
            $"{nameof(ByteEnum)}={(byte) ByteEnum.Value}&" +
            $"{nameof(IntEnum)}={(int)IntEnum.Value}&" +
            $"{nameof(TestEnum)}={(int)TestEnum.Value}&"+
            $"{nameof(EnumTestClass.NullableTestEnum)}={(int)TestEnum.Value}"
           );
        }


        [Fact]
        public void ToHttpQueryString_should_return_datetime_in_given_format()

        {

            DateTime time = new DateTime(2022, 1, 22, 10, 10, 10);
            string timeInFormat = HttpUtility.UrlEncode( "2022/01/22");
            string format = "yyyy/MM/dd";

            DateTimeTestClass testClass = new DateTimeTestClass()
            {
                NullableDateTime =time,
                DateTime = time,
                DateTimeOffset = new DateTimeOffset(time),
                NullableDateTimeOffset = new DateTimeOffset(time),
                NullDateTime = null,
                NullDateTimeOffset = null
            };

            string query = testClass.ToQueryString(new HttpQueryStringOption()
            {
                DateTimeFormat = format
            });


            query.Should().Be(
            $"{nameof(DateTimeTestClass.DateTime)}={timeInFormat}&" +
            $"{nameof(DateTimeTestClass.NullableDateTime)}={timeInFormat}&" +
            $"{nameof(DateTimeTestClass.DateTimeOffset)}={timeInFormat}&" +
            $"{nameof(DateTimeTestClass.NullableDateTimeOffset)}={timeInFormat}" 
            );
        }

        class DateTimeTestClass
        {
            public DateTime DateTime { get; set; }
            public DateTime? NullableDateTime { get; set; }
            public DateTimeOffset DateTimeOffset { get; set; }
            public DateTimeOffset? NullableDateTimeOffset { get; set; }
            public DateTimeOffset? NullDateTimeOffset { get; set; }
            public DateTime? NullDateTime { get; set; }

        }


        private enum ByteEnum : byte
        {
            Value = 1
        }
        private enum IntEnum : int
        {
            Value = 1
        }
        private enum TestEnum        {
            Value = 1
        }
        private class EnumTestClass
        {
            public ByteEnum ByteEnum { get; set; }
            public IntEnum IntEnum { get; set; }
            public TestEnum TestEnum { get; set; }
            public TestEnum? NullableTestEnum { get; set; }
            public TestEnum? NullTestEnum { get; set; }
        }
    }
}