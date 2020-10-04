using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWebProject.E2ETests.Pages
{
    public class AboutPage
    {
        private IWebDriver _driver;
        public IWebElement fizzBuzzDescription => _driver.FindElement(By.TagName("p"));
        public AboutPage(IWebDriver driver) => _driver = driver;
    }
}
