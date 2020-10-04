using FizzBuzzWebProject.E2ETests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzWebProject.E2ETests.Steps
{
    public class CleaningTheBoardE2ETest : TestBase
    {
        private FizzBuzzPage fizzBuzzPage;
        public CleaningTheBoardE2ETest() => fizzBuzzPage = new FizzBuzzPage(driver);

        [Fact]
        public void CleaningTheBoard_WhenCleanButtonisClicked_NumbersAreErased()
        {
            fizzBuzzPage.GotoFizzBuzzPage();
            fizzBuzzPage.runTestButton.Click();

            fizzBuzzPage.cleanButton.Click();

            Assert.Empty(fizzBuzzPage.fizzBuzzResults);
        }
    }
}
