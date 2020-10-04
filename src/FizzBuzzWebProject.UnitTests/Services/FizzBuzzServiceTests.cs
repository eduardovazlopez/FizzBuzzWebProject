using FizzBuzzWebProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzWebProject.UnitTests.Services
{
    public class FizzBuzzServiceTests
    {
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(1, "1")]
        public void FizzBuzzSingleOutput_WhenCalled_ReturnStringAccordingFizzBuzzTes(int input, string expectedResult)
        {
            var result = FizzBuzzService.FizzBuzzSingleOutput(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ExecuteFizzBuzz_PassingNoLength_Returning100Elements()
        {
            var result = new List<string>();

            FizzBuzzService.ExecuteFizzBuzz(result);

            Assert.Equal(100, result.Count);
        }
    }
}
