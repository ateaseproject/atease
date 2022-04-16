using System;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class TrimDateTimeExtensionsTests
    {
        [Fact]
        public void TrimUntilSeconds_should_trim_the_milliseconds()
        {
            DateTime dateTime = DateTime.Now;

            DateTime expectedTime = new DateTime(dateTime.Year,
                                                 dateTime.Month,
                                                 dateTime.Day,
                                                 dateTime.Hour,
                                                 dateTime.Minute,
                                                 dateTime.Second,
                                                 0);

            DateTime actualTime = dateTime.TrimUntilSeconds();

            actualTime.Should().Be(expectedTime);
        }


        [Fact]
        public void TrimUntilMinutes_should_trim_the_seconds()
        {
            DateTime dateTime = DateTime.Now;

            DateTime expectedTime = new DateTime(dateTime.Year,
                                                 dateTime.Month,
                                                 dateTime.Day,
                                                 dateTime.Hour,
                                                 dateTime.Minute,
                                                 0,
                                                 0);

            DateTime actualTime = dateTime.TrimUntilMinutes();

            actualTime.Should().Be(expectedTime);
        }

        [Fact]
        public void TrimUntilHours_should_trim_the_minutes()
        {
            DateTime dateTime = DateTime.Now;

            DateTime expectedTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0, 0);

            DateTime actualTime = dateTime.TrimUntilHours();

            actualTime.Should().Be(expectedTime);
        }

        [Fact]
        public void TrimUntilDays_should_trim_the_hourse()
        {
            DateTime dateTime = DateTime.Now;

            DateTime expectedTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, 0);

            DateTime actualTime = dateTime.TrimUntilDays();

            actualTime.Should().Be(expectedTime);
        }
    }
}