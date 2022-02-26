using System;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class SpanTests
    {
        [Fact]
        public void Span_should_be_available()
        {
            ReadOnlySpan<char> span = new ReadOnlySpan<char>(new[] { 'a', 'b', 'c' });

          bool actual =  span.IsNullOrEmptyOrWhitespace();

          actual.Should().BeFalse();

        }
    }
}