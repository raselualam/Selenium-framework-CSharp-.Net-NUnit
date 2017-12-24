using OpenQA.Selenium;

namespace MyNamespace
{
    public class PageThree : BasePage
    {
        public PageThree(IWebDriver driver) : base(driver)
        {
        }

        protected IWebElement SamplePageObject = null;

        public IWebElement BtnPageObject()
        {
            SamplePageObject = driver.FindElement(By.XPath("//*[@id=myId"));
            return SamplePageObject;
        }
    }
}
