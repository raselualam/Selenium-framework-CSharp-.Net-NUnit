using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MyNamespace
{
    public class PageOne : BasePage
    {

        public PageOne(IWebDriver driver) : base(driver)
        {
        }

        protected IWebElement UserName = null;
        protected IWebElement Password = null;
        protected IWebElement Login = null;
        protected IWebElement SearchBy = null;
        protected IWebElement Option = null;

        public IWebElement TxtUserName()
        {
            UserName = driver.FindElement(By.XPath("//*[@id='myUname']"));
            return UserName;
        }

        public IWebElement TxtPassword()
        {
            Password = driver.FindElement(By.XPath("//*[@id='myUpass']"));
            return Password;
        }

        public IWebElement BtnNext()
        {
            Login = driver.FindElement(By.XPath("//*[@id='btnNext']"));
            return Login;
        }

        public IWebElement DDSearchBy()
        {
            SearchBy = driver.FindElement(By.XPath("//*[@id='btnNext']"));
            return SearchBy;
        }

        public IWebElement Option1()
        {
            Option = driver.FindElement(By.XPath("//*[@id='btnNext']"));
            return Option;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='sampleId']/tbody")]
        public IWebElement SamplePageFactory { get; set; }

    }
}