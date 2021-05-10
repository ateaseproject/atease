using System.Collections.Generic;
using System.Text;
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
                yield return new object[] { "", "" };
                yield return new object[] { " ", " " };
                yield return new object[] { "a", "a" };
                yield return new object[] { "one", "one" };
                yield return new object[] { "One", "One" };
                //yield return new object[] { "one two", "one_two" };
                yield return new object[] { "OneTwo", "One_Two" };
                //yield return new object[] {"OneTwo", "OneTwo"};


                //yield return new object[] { "one two", "one_two" };
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

    public static class EX
    {
        public static string ToSnakeCase(this string sentence)
        {
            if (sentence.IsNullOrEmptyOrWhiteSpace())
            {
                return sentence;
            }

            StringBuilder newText = new StringBuilder(sentence.Length * 2);
            newText.Append(sentence[0]);
            for (int i = 1; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                {
                    if (sentence[i - 1] != ' ' && !char.IsUpper(sentence[i - 1]) && char.IsUpper(sentence[i - 1]) &&
                        i < sentence.Length - 1 && !char.IsUpper(sentence[i + 1]))
                    {
                        newText.Append('_');
                    }
                }
                //if (sentence[i].IsWhiteSpace())
                //{
                //    if (sentence[i - 1] != '_' && !char.IsUpper(sentence[i - 1]) && char.IsUpper(sentence[i - 1]) &&
                //        i < sentence.Length - 1 && !char.IsUpper(sentence[i + 1]))
                //    {
                //        newText.Append('_');
                //    }
                //}


                newText.Append(sentence[i]);
            }

            return newText.ToString();

        }
    }

}