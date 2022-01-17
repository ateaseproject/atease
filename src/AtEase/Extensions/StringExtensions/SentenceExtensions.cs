using System.Linq;
using System.Text;

namespace AtEase.Extensions
{
    public static class SentenceExtensions
    {
        /// <summary>
        ///  Check the text is one word or not. word should be at least one character
        /// </summary>
        /// <param name="text">text</param>
        /// <returns>is word or not</returns>
        public static bool IsWord(this string text)
        {
            var trimmedText = text.Trim();
            if (trimmedText.Length == 0)
            {
                return false;
            }

            var index = trimmedText.IndexOf(' ');
            return index < 0;
        }


        /// <summary>
        ///  Space the text, TheBook should be The Book
        /// </summary>
        /// <param name="sentence">concatenated words</param>
        /// <param name="preserveAcronyms">check acronyms</param>
        /// <returns>separate words by capital letter</returns>
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

                if (char.IsDigit(sentence[i]))
                {
                    if (sentence[i - 1] != ' ' && !char.IsDigit(sentence[i - 1]) ||
                        i < sentence.Length - 1 && !char.IsDigit(sentence[i + 1]))
                    {
                        spacedText.Append(' ');
                    }
                }

                spacedText.Append(sentence[i]);
            }

            return spacedText.ToString();
        }

        /// <summary>
        ///  Space the text, first letter will be in upper and rest will be lower case, TheBook should be The book
        /// </summary>
        /// <param name="sentence">concatenated words</param>
        /// <param name="preserveAcronyms">check acronyms</param>
        /// <returns>separate words by capital letter</returns>
        public static string ToSentence(this string sentence, bool preserveAcronyms = true)
        {
            if (sentence.IsNullOrEmptyOrWhiteSpace())
            {
                return sentence;
            }

            var spaced = sentence.ToSpacingSentence(preserveAcronyms).ToLower();

            return CapitalFirstLetterWithoutCheckForBeingEmpty(spaced);
        }


        /// <summary>
        ///  Convert text to snake case. One Two should be one_two
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string ToSnakeCase(this string sentence)
        {
            if (sentence.IsNullOrEmptyOrWhiteSpace())
            {
                return sentence;
            }

            var spaced = sentence.ToSpacingSentence().ToLower();
            return spaced.Replace(' ', '_');
        }

        /// <summary>
        ///     capital first letter of text
        /// </summary>
        /// <param name="text">the text</param>
        /// <returns>capitalized first letter text</returns>
        public static string CapitalFirstLetter(this string text)
        {
            if (text.IsNullOrEmptyOrWhiteSpace())
            {
                return text;
            }

            return CapitalFirstLetterWithoutCheckForBeingEmpty(text);
        }

        /// <summary>
        ///     capital first letter of text without checking for text being empty.
        ///     if text be an empty text, raise exception
        /// </summary>
        /// <param name="text">the text</param>
        /// <returns>capitalized first letter text</returns>
        public static string CapitalFirstLetterWithoutCheckForBeingEmpty(this string text)
        {
            return text.First().ToString().ToUpper() + text.Substring(1);
        }
    }
}