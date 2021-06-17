using System.Collections.Generic;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class SnakeCaseSentenceConvertorTests
    {
        public static IEnumerable<object[]> SnakeCaseSentences
        {
            get
            {
                yield return new object[] {"", ""};
                yield return new object[] {" ", " "};
                yield return new object[] {"a", "a"};
                yield return new object[] {"one", "one"};
                yield return new object[] {"One", "one"};
                yield return new object[] {"one two", "one_two"};
                yield return new object[] {"OneTwo", "one_two"};
            }
        }

        [Theory]
        [MemberData(nameof(SnakeCaseSentences))]
        public void ToSnakeCase_should_convert_sentence_to_snake_case(string sentence, string expectedSnakeCaseSentence)
        {
            string snakeCaseSentence = sentence.ToSnakeCase();
            snakeCaseSentence.Should().Be(expectedSnakeCaseSentence);
        }
    }
}