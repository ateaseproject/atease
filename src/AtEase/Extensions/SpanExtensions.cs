using System;
using System.Diagnostics.CodeAnalysis;

namespace AtEase.Extensions
{
    public static class SpanExtensions
    {
        public static bool IsNullOrEmptyOrWhitespace([NotNullWhen(false)] this ReadOnlySpan<char> value)
        {
            return value == null || value.IsEmpty || value.IsWhiteSpace();
        }
    }
}