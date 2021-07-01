using System;
using AtEase.Extensions;
using Xunit;
using Xunit.Abstractions;

namespace AtEase.Test
{
    public class GuidExtensionsTests
    {
        private readonly ITestOutputHelper _output;

        public GuidExtensionsTests(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// Just for showing methods output
        /// </summary>
        [Fact]
        public void Test()
        {
            _output.WriteLine("\nEf:");
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfCoreSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfCoreSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfCoreSequentialGuid().ToString());

            _output.WriteLine("\nComb:\n");
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
        }
    }
}