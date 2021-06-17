using System.Collections.Generic;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class IsWordTests
    {
        public static IEnumerable<object[]> Sentences
        {
            get
            {
                yield return new object[] { "", false};
                yield return new object[] { " ", false };
                yield return new object[] { "a", true };
                yield return new object[] { "one", true };
                yield return new object[] { " one", true };
                yield return new object[] { "one ", true };
                yield return new object[] { "One", true };
                yield return new object[] { "one two", false };
                yield return new object[] { "OneTwo", true };
            }
        }

        [Theory]
        [MemberData(nameof(Sentences))]
        public void IsWord_should_return_true_if_sentence_is_one_word(string sentence, bool isWord)
        {
            sentence.IsWord().Should().Be(isWord);
        }
    }

}