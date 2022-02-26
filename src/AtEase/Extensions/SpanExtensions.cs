using System;
namespace AtEase.Extensions
{
#if (NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER)
    public static class SpanExtensions
    {
        public static bool IsNullOrEmptyOrWhitespace(this ReadOnlySpan<char> value)
        {
            return (value == null) || value.IsEmpty || value.IsWhiteSpace();
        }
    }

#endif
}