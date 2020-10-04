using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWebProject.E2ETests.Pages
{
    public class FizzBuzzPage
    {
        private IWebDriver _driver;
        public IList<IWebElement> fizzBuzzResults => _driver.FindElements(By.Name("FBli"));
        public IWebElement fizzBuzzElement => _driver.FindElement(By.Id("44"));
        public IWebElement fizzElement => _driver.FindElement(By.Id("2"));
        public IWebElement buzzElement => _driver.FindElement(By.Id("4"));
        public IWebElement numberElement => _driver.FindElement(By.Id("0"));
        public IWebElement runTestButton => _driver.FindElement(By.Id("RunTestButton"));
        public IWebElement cleanButton => _driver.FindElement(By.Id("CleanButton"));
        public IWebElement aboutLink => _driver.FindElement(By.XPath("//a[contains(text(), 'About')]"));

        public FizzBuzzPage(IWebDriver driver) => _driver = driver;
        public void GotoFizzBuzzPage() => _driver.Url = "https://localhost:5001/";
    }
}
