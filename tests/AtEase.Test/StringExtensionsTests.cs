using System;
using System.Collections.Generic;
using AtEase.Extensions;
using Xunit;

namespace AtEase.Test
{
    public class StringExtensionsTests
    {

        public static IEnumerable<object[]> MergeAdjacentWhiteSpacesData =>
            new List<object[]>
            {
                new object[] {"Ahmad", "Ahmad"},
                new object[] {"Ahmad ", "Ahmad "},
                new object[] {"Ahmad  ", "Ahmad "},
                new object[] {"  Ahmad", " Ahmad"},
                new object[] {"Ahmad Chehre", "Ahmad Chehre"},
                new object[] {"Ahmad  Chehre", "Ahmad Chehre"},
                new object[] {"Ahmad   Chehre", "Ahmad Chehre"},
                new object[] {"Ahmad   Chehre ...", "Ahmad Chehre ..."},
                new object[] {"Ahmad   Chehre  ...", "Ahmad Chehre ..."},
            };


        [Theory]
        [MemberData(nameof(MergeAdjacentWhiteSpacesData))]
        public void MergeAdjacentWhiteSpaces_StringWithSpace_MergedStringWithAdjacentWhiteSpaces(string value, string expectedValue)
        {
            var mergedString = value.MergeAdjacentWhiteSpaces();
            Assert.Equal(expectedValue, mergedString);
        }
    }
}
