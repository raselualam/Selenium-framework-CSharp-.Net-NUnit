using OpenQA.Selenium;

namespace MyNamespace
{
    public class PageTwo : BasePage
    {
        public PageTwo(IWebDriver driver) : base(driver)
        {
        }

        protected IWebElement PGobj1 = null;
        protected IWebElement PGobj2 = null;
        protected IWebElement PGobj3 = null;

        public IWebElement DDPGobj1()
        {
            PGobj1 = driver.FindElement(By.XPath("//*[@id='Sampleid1']"));
            return PGobj1;
        }

        public IWebElement TxtPGobj2()
        {
            PGobj2 = driver.FindElement(By.XPath("//*[@id='Sampleid2']"));
            return PGobj2;
        }

        public IWebElement BtnPGobj3()
        {
            PGobj3 = driver.FindElement(By.XPath("//*[@id='Sampleid3']"));
            return PGobj3;
        }
    }
}
