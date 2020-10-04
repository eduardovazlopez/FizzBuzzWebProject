using FizzBuzzWebProject.E2ETests.Pages;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace FizzBuzzWebProject.E2ETests.Steps
{
    public class AboutPageLinkE2ETest : TestBase
    {
        private FizzBuzzPage fizzBuzzPage;
        private AboutPage aboutPage;

        public AboutPageLinkE2ETest()
        {
            fizzBuzzPage = new FizzBuzzPage(driver);
            aboutPage = new AboutPage(driver);
        }

        [Fact]
        public void AboutPage_WhenAboutLinkIsClicked_NavegateToAboutPage()
        {
            fizzBuzzPage.GotoFizzBuzzPage();

            fizzBuzzPage.aboutLink.Click();

            Assert.Contains("FizzBuzz test is a program", aboutPage.fizzBuzzDescription.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
