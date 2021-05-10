using System.Linq;
using System.Text;

namespace AtEase.Extensions
{
    public static class SentenceExtensions
    {
        public static string ToSpacingSentence(this string sentence, bool preserveAcronyms = true)
        {
            if (sentence.IsNullOrEmptyOrWhiteSpace())
            {
                return sentence;
            }

            var spacedText = new StringBuilder(sentence.Length * 2);
            spacedText.Append(sentence[0]);
            for (var i = 1; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                {
                    if (sentence[i - 1] != ' ' && !char.IsUpper(sentence[i - 1]) ||
                        preserveAcronyms && char.IsUpper(sentence[i - 1]) &&
                        i < sentence.Length - 1 && !char.IsUpper(sentence[i + 1]))
                    {
                        spacedText.Append(' ');
                    }
                }

                spacedText.Append(sentence[i]);
            }

            return spacedText.ToString();
        }

        public static string ToSentence(this string sentence, bool preserveAcronyms = true)
        {
            if (sentence.IsNullOrEmptyOrWhiteSpace())
            {
                return sentence;
            }

            var spaced = sentence.ToSpacingSentence(preserveAcronyms).ToLower();

            return spaced.First().ToString().ToUpper() + spaced.Substring(1);
        }
    }
}