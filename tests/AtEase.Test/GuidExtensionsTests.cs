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
            _output.WriteLine("\nGeneric:");
            _output.WriteLine(Guid.NewGuid().AsSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorExtensions.NewSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorExtensions.NewSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorExtensions.NewSequentialGuid().ToString());


            _output.WriteLine("\nEf:");
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsEfSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorEfExtensions.NewEfSequentialGuid().ToString());

            _output.WriteLine("\nComb:");
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(Guid.NewGuid().AsCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
            _output.WriteLine(GuidGeneratorCombExtensions.NewCombSequentialGuid().ToString());
        }
    }
}