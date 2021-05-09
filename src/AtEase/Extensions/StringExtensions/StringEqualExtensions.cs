using System;
using System.Diagnostics;

namespace AtEase.Extensions
{
    public static class StringEqualExtensions
    {
        [DebuggerStepThrough]
        public static bool Equals(this string value, string other, StringComparison comparisonType)
        {
            return string.Equals(value, other, comparisonType);
        }
    }
}