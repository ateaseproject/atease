using System.Collections.Generic;
using AtEase.Extensions;
using Xunit;

namespace AtEase.Test
{
    public class EnumExtensionsTests
    {
        public enum TestEnum
        {
            Enum1 = 1,
            Enum2 = 2,
            Enum3 = 3
        }

        public static IEnumerable<object[]> EnumToInt =>
            new List<object[]>
            {
                new object[] {TestEnum.Enum1, 1},
                new object[] {TestEnum.Enum2, 2},
                new object[] {TestEnum.Enum3, 3}
            };


        [Theory]
        [MemberData(nameof(EnumToInt))]
        public void enum_to_int(TestEnum @enum, int expectedValue)
        {
            var enumValue = @enum.ToInt();
            Assert.Equal(expectedValue, enumValue);
        }

        public static IEnumerable<object[]> IntToEnum =>
            new List<object[]>
            {
                new object[] {1,TestEnum.Enum1},
                new object[] {2,TestEnum.Enum2},
                new object[] {3,TestEnum.Enum3}
            };


        [Theory]
        [MemberData(nameof(IntToEnum))]
        public void int_to_enum(int value, TestEnum expectedValue)
        {
            var @enum = value.AsEnum<TestEnum>();
            Assert.Equal(expectedValue, @enum);
        }

    }
}