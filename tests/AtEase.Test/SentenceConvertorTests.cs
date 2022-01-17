using System.Collections.Generic;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class SpacingSentenceConvertorTests
    {
        public static IEnumerable<object[]> SentencesWithSpace
        {
            get
            {
                yield return new object[] {"", ""};
                yield return new object[] {" ", " "};
                yield return new object[] {"o", "o"};
                yield return new object[] {"one", "one"};
                yield return new object[] {"One", "One"};
                yield return new object[] {"one two", "one two"};
                yield return new object[] {"One Two", "One Two"};
                yield return new object[] {"OneTwo", "One Two"};
                yield return new object[] {"OneTwoThree", "One Two Three"};
                yield return new object[] {"FirstSecond3rd", "First Second 3rd"};
                yield return new object[] {"FirstSecond3rdForth", "First Second 3rd Forth"};
                yield return new object[] {"FirstSecond3Third", "First Second 3 Third"};
            }
        }

        public static IEnumerable<object[]> Sentences
        {
            get
            {
                yield return new object[] {"", ""};
                yield return new object[] {" ", " "};
                yield return new object[] {"o", "O"};
                yield return new object[] {"one", "One"};
                yield return new object[] {"One", "One"};
                yield return new object[] {"one two", "One two"};
                yield return new object[] {"One Two", "One two"};
                yield return new object[] {"OneTwo", "One two"};
                yield return new object[] {"OneTwoThree", "One two three"};
            }
        }

        [Theory]
        [MemberData(nameof(Sentences))]
        public void ToSentence_should_convert_sentence_to_spaced_with_first_capital_and_other_should_be_lower(
        string sentence,
        string expectedSentence)
        {
            string result = sentence.ToSentence();
            result.Should().Be(expectedSentence);
        }


        [Theory]
        [MemberData(nameof(SentencesWithSpace))]
        public void ToSpacingSentence_should_convert_sentence_to_spaced(string sentence, string expectedSentence)
        {
            string result = sentence.ToSpacingSentence();
            result.Should().Be(expectedSentence);
        }
    }
}