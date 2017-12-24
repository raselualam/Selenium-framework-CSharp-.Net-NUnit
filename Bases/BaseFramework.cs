using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyNamespace
{
    [TestFixture]
    public class BaseFramework
    {
        protected IWebDriver driver = null;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Console.WriteLine("Using Nunit SetUp to Open Browser with Selenium Webdriver");

        }

        [TearDown]
        public void CleanUpBrowser()
        {
            driver.Quit();
            Console.WriteLine("Using Nunit TearDown to CleanUp Browser");
        }


        public StepsOne ControllerOne()
        {
            return new StepsOne(driver);
        }

        public StepsTwo ControllerTwo()
        {
            return new StepsTwo(driver);
        }

        public StepsThree ControllerThree()
        {
            return new StepsThree(driver);
        }

        public DataModel TestData()
        {
            return new DataModel(driver);
        }
    }
}
