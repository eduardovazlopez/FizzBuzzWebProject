using FizzBuzzWebProject.E2ETests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzWebProject.E2ETests.Steps
{
    public class FizzBuzzTestE2ETest : TestBase
    {
        private FizzBuzzPage fizzBuzzPage;
        public FizzBuzzTestE2ETest() => fizzBuzzPage = new FizzBuzzPage(driver);

        [Fact]
        public void FizzBuzzTest_WhenCalled_ReturnStringAccordingFizzBuzzTesT()
        {
            fizzBuzzPage.GotoFizzBuzzPage();

            fizzBuzzPage.runTestButton.Click();

            Assert.Equal(100, fizzBuzzPage.fizzBuzzResults.Count);
            Assert.Equal("Fizz", fizzBuzzPage.fizzElement.Text);
            Assert.Equal("Buzz", fizzBuzzPage.buzzElement.Text);
            Assert.Equal("FizzBuzz", fizzBuzzPage.fizzBuzzElement.Text);
        }
    }
}
