using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading;
using System;

namespace MyNamespace
{
    public class StepsOne : BaseStep
    {
        public PageOne PageOneModel = null;

        public StepsOne(IWebDriver driver) : base(driver)
        {
            PageOneModel = new PageOne(driver);
        }

        public void FunctionNavigateURL(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        public void FunctionSimple (string UserName, string Password)
        {
            PageOneModel.TxtUserName().Clear();
            PageOneModel.TxtUserName().SendKeys(UserName);
            PageOneModel.TxtPassword().Clear();
            PageOneModel.TxtPassword().SendKeys(Password);
            PageOneModel.BtnNext().Click();
        }

        internal void FunctionAssert(int v)
        {
            throw new NotImplementedException();
        }

        public void FunctionDropDown(string SearchBy)
        {
            SelectElement mydrpdwn = new SelectElement(PageOneModel.DDSearchBy());
            mydrpdwn.SelectByText(SearchBy);
        }

        public void FunctionSwitchWindow(string URL1)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Assert.AreEqual(URL1, driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public void FunctionAssert(string Submit)
        {
            Assert.IsTrue((PageOneModel.BtnNext()).Text.Contains(Submit));
        }

        public void FunctionWait(int time)
        {
            Thread.Sleep(time);
        }
        public void FunctionAlertAccept()
        {
            IAlert Aleart = driver.SwitchTo().Alert();
            Aleart.Accept();
        }
    }
}
